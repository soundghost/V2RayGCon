﻿using Statistics.Resources.Langs;
using System;
using System.Windows.Forms;

namespace Statistics.Views.WinForms
{
    public partial class FormMain : Form
    {
        Services.Settings settings;
        VgcApis.Models.IServersService vgcServers;
        Controllers.FormMainCtrl formMainCtrl;

        public FormMain(
            Services.Settings settings,
            VgcApis.Models.IServersService vgcServers)
        {
            this.settings = settings;
            this.vgcServers = vgcServers;
            InitializeComponent();

            this.FormClosing += (s, a) => formMainCtrl?.Cleanup();
            VgcApis.Libs.UI.AutoSetFormIcon(this);
            formMainCtrl = InitFormMainCtrl();
        }

        private void FormMain_Shown(object sender, EventArgs e)
        {
            this.Text = Properties.Resources.Name + " v" + Properties.Resources.Version;
            formMainCtrl.Run();
        }

        #region private methods
        Controllers.FormMainCtrl InitFormMainCtrl()
        {
            var ctrl = new Controllers.FormMainCtrl(
                settings,
                vgcServers,

                lvStatsTable,

                resetToolStripMenuItem,
                resizeByTitleToolStripMenuItem,
                resizeByContentToolStripMenuItem);
            return ctrl;
        }
        #endregion

        #region UI event
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (VgcApis.Libs.UI.Confirm(I18N.ConfirmCloseForm))
            {
                this.Close();
            }
        }
        #endregion
    }
}
