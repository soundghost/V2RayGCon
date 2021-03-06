﻿namespace ProxySetter.Views.WinForms
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabBasic = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboxBasicPacProtocol = new System.Windows.Forms.ComboBox();
            this.chkBasicUseCustomPac = new System.Windows.Forms.CheckBox();
            this.cboxBasicPacMode = new System.Windows.Forms.ComboBox();
            this.cboxBasicSysProxyMode = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBasicBrowseCustomPac = new System.Windows.Forms.Button();
            this.chkBasicAutoUpdateSysProxy = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkBasicPacAlwaysOn = new System.Windows.Forms.CheckBox();
            this.tboxBasicCustomPacPath = new System.Windows.Forms.TextBox();
            this.tboxBaiscPacPort = new System.Windows.Forms.TextBox();
            this.tboxBasicGlobalPort = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBasicClearSysProxy = new System.Windows.Forms.Button();
            this.lbBasicProxyLink = new System.Windows.Forms.Label();
            this.lbBasicCurPacServerStatus = new System.Windows.Forms.Label();
            this.btnBaiscCopyProxyLink = new System.Windows.Forms.Button();
            this.btnBasicDebugPacServer = new System.Windows.Forms.Button();
            this.btnBasicStartPacServer = new System.Windows.Forms.Button();
            this.btnBasicStopPacServer = new System.Windows.Forms.Button();
            this.tabPac = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rtboxPacWhiteList = new System.Windows.Forms.RichTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rtboxPacBlackList = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabBasic.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPac.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabBasic);
            this.tabControl1.Controls.Add(this.tabPac);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tabBasic
            // 
            this.tabBasic.Controls.Add(this.tableLayoutPanel2);
            resources.ApplyResources(this.tabBasic, "tabBasic");
            this.tabBasic.Name = "tabBasic";
            this.tabBasic.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboxBasicPacProtocol);
            this.groupBox1.Controls.Add(this.chkBasicUseCustomPac);
            this.groupBox1.Controls.Add(this.cboxBasicPacMode);
            this.groupBox1.Controls.Add(this.cboxBasicSysProxyMode);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnBasicBrowseCustomPac);
            this.groupBox1.Controls.Add(this.chkBasicAutoUpdateSysProxy);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.chkBasicPacAlwaysOn);
            this.groupBox1.Controls.Add(this.tboxBasicCustomPacPath);
            this.groupBox1.Controls.Add(this.tboxBaiscPacPort);
            this.groupBox1.Controls.Add(this.tboxBasicGlobalPort);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // cboxBasicPacProtocol
            // 
            this.cboxBasicPacProtocol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxBasicPacProtocol.FormattingEnabled = true;
            this.cboxBasicPacProtocol.Items.AddRange(new object[] {
            resources.GetString("cboxBasicPacProtocol.Items"),
            resources.GetString("cboxBasicPacProtocol.Items1")});
            resources.ApplyResources(this.cboxBasicPacProtocol, "cboxBasicPacProtocol");
            this.cboxBasicPacProtocol.Name = "cboxBasicPacProtocol";
            // 
            // chkBasicUseCustomPac
            // 
            resources.ApplyResources(this.chkBasicUseCustomPac, "chkBasicUseCustomPac");
            this.chkBasicUseCustomPac.Name = "chkBasicUseCustomPac";
            this.toolTip1.SetToolTip(this.chkBasicUseCustomPac, resources.GetString("chkBasicUseCustomPac.ToolTip"));
            this.chkBasicUseCustomPac.UseVisualStyleBackColor = true;
            // 
            // cboxBasicPacMode
            // 
            this.cboxBasicPacMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxBasicPacMode.FormattingEnabled = true;
            this.cboxBasicPacMode.Items.AddRange(new object[] {
            resources.GetString("cboxBasicPacMode.Items"),
            resources.GetString("cboxBasicPacMode.Items1")});
            resources.ApplyResources(this.cboxBasicPacMode, "cboxBasicPacMode");
            this.cboxBasicPacMode.Name = "cboxBasicPacMode";
            // 
            // cboxBasicSysProxyMode
            // 
            this.cboxBasicSysProxyMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxBasicSysProxyMode.FormattingEnabled = true;
            this.cboxBasicSysProxyMode.Items.AddRange(new object[] {
            resources.GetString("cboxBasicSysProxyMode.Items"),
            resources.GetString("cboxBasicSysProxyMode.Items1"),
            resources.GetString("cboxBasicSysProxyMode.Items2")});
            resources.ApplyResources(this.cboxBasicSysProxyMode, "cboxBasicSysProxyMode");
            this.cboxBasicSysProxyMode.Name = "cboxBasicSysProxyMode";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.toolTip1.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.toolTip1.SetToolTip(this.label2, resources.GetString("label2.ToolTip"));
            // 
            // btnBasicBrowseCustomPac
            // 
            resources.ApplyResources(this.btnBasicBrowseCustomPac, "btnBasicBrowseCustomPac");
            this.btnBasicBrowseCustomPac.Name = "btnBasicBrowseCustomPac";
            this.btnBasicBrowseCustomPac.UseVisualStyleBackColor = true;
            // 
            // chkBasicAutoUpdateSysProxy
            // 
            resources.ApplyResources(this.chkBasicAutoUpdateSysProxy, "chkBasicAutoUpdateSysProxy");
            this.chkBasicAutoUpdateSysProxy.Name = "chkBasicAutoUpdateSysProxy";
            this.toolTip1.SetToolTip(this.chkBasicAutoUpdateSysProxy, resources.GetString("chkBasicAutoUpdateSysProxy.ToolTip"));
            this.chkBasicAutoUpdateSysProxy.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            this.toolTip1.SetToolTip(this.label3, resources.GetString("label3.ToolTip"));
            // 
            // chkBasicPacAlwaysOn
            // 
            resources.ApplyResources(this.chkBasicPacAlwaysOn, "chkBasicPacAlwaysOn");
            this.chkBasicPacAlwaysOn.Name = "chkBasicPacAlwaysOn";
            this.toolTip1.SetToolTip(this.chkBasicPacAlwaysOn, resources.GetString("chkBasicPacAlwaysOn.ToolTip"));
            this.chkBasicPacAlwaysOn.UseVisualStyleBackColor = true;
            // 
            // tboxBasicCustomPacPath
            // 
            resources.ApplyResources(this.tboxBasicCustomPacPath, "tboxBasicCustomPacPath");
            this.tboxBasicCustomPacPath.Name = "tboxBasicCustomPacPath";
            // 
            // tboxBaiscPacPort
            // 
            resources.ApplyResources(this.tboxBaiscPacPort, "tboxBaiscPacPort");
            this.tboxBaiscPacPort.Name = "tboxBaiscPacPort";
            // 
            // tboxBasicGlobalPort
            // 
            resources.ApplyResources(this.tboxBasicGlobalPort, "tboxBasicGlobalPort");
            this.tboxBasicGlobalPort.Name = "tboxBasicGlobalPort";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBasicClearSysProxy);
            this.groupBox2.Controls.Add(this.lbBasicProxyLink);
            this.groupBox2.Controls.Add(this.lbBasicCurPacServerStatus);
            this.groupBox2.Controls.Add(this.btnBaiscCopyProxyLink);
            this.groupBox2.Controls.Add(this.btnBasicDebugPacServer);
            this.groupBox2.Controls.Add(this.btnBasicStartPacServer);
            this.groupBox2.Controls.Add(this.btnBasicStopPacServer);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // btnBasicClearSysProxy
            // 
            resources.ApplyResources(this.btnBasicClearSysProxy, "btnBasicClearSysProxy");
            this.btnBasicClearSysProxy.Name = "btnBasicClearSysProxy";
            this.toolTip1.SetToolTip(this.btnBasicClearSysProxy, resources.GetString("btnBasicClearSysProxy.ToolTip"));
            this.btnBasicClearSysProxy.UseVisualStyleBackColor = true;
            // 
            // lbBasicProxyLink
            // 
            resources.ApplyResources(this.lbBasicProxyLink, "lbBasicProxyLink");
            this.lbBasicProxyLink.AutoEllipsis = true;
            this.lbBasicProxyLink.Name = "lbBasicProxyLink";
            this.toolTip1.SetToolTip(this.lbBasicProxyLink, resources.GetString("lbBasicProxyLink.ToolTip"));
            // 
            // lbBasicCurPacServerStatus
            // 
            resources.ApplyResources(this.lbBasicCurPacServerStatus, "lbBasicCurPacServerStatus");
            this.lbBasicCurPacServerStatus.Name = "lbBasicCurPacServerStatus";
            // 
            // btnBaiscCopyProxyLink
            // 
            resources.ApplyResources(this.btnBaiscCopyProxyLink, "btnBaiscCopyProxyLink");
            this.btnBaiscCopyProxyLink.Name = "btnBaiscCopyProxyLink";
            this.toolTip1.SetToolTip(this.btnBaiscCopyProxyLink, resources.GetString("btnBaiscCopyProxyLink.ToolTip"));
            this.btnBaiscCopyProxyLink.UseVisualStyleBackColor = true;
            // 
            // btnBasicDebugPacServer
            // 
            resources.ApplyResources(this.btnBasicDebugPacServer, "btnBasicDebugPacServer");
            this.btnBasicDebugPacServer.Name = "btnBasicDebugPacServer";
            this.toolTip1.SetToolTip(this.btnBasicDebugPacServer, resources.GetString("btnBasicDebugPacServer.ToolTip"));
            this.btnBasicDebugPacServer.UseVisualStyleBackColor = true;
            // 
            // btnBasicStartPacServer
            // 
            resources.ApplyResources(this.btnBasicStartPacServer, "btnBasicStartPacServer");
            this.btnBasicStartPacServer.Name = "btnBasicStartPacServer";
            this.toolTip1.SetToolTip(this.btnBasicStartPacServer, resources.GetString("btnBasicStartPacServer.ToolTip"));
            this.btnBasicStartPacServer.UseVisualStyleBackColor = true;
            // 
            // btnBasicStopPacServer
            // 
            resources.ApplyResources(this.btnBasicStopPacServer, "btnBasicStopPacServer");
            this.btnBasicStopPacServer.Name = "btnBasicStopPacServer";
            this.toolTip1.SetToolTip(this.btnBasicStopPacServer, resources.GetString("btnBasicStopPacServer.ToolTip"));
            this.btnBasicStopPacServer.UseVisualStyleBackColor = true;
            // 
            // tabPac
            // 
            this.tabPac.Controls.Add(this.tableLayoutPanel3);
            resources.ApplyResources(this.tabPac, "tabPac");
            this.tabPac.Name = "tabPac";
            this.tabPac.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.groupBox3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBox4, 1, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rtboxPacWhiteList);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // rtboxPacWhiteList
            // 
            resources.ApplyResources(this.rtboxPacWhiteList, "rtboxPacWhiteList");
            this.rtboxPacWhiteList.Name = "rtboxPacWhiteList";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rtboxPacBlackList);
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // rtboxPacBlackList
            // 
            resources.ApplyResources(this.rtboxPacBlackList, "rtboxPacBlackList");
            this.rtboxPacBlackList.Name = "rtboxPacBlackList";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSave);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormMain";
            this.Shown += new System.EventHandler(this.FormPluginMain_Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabBasic.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPac.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabBasic;
        private System.Windows.Forms.TextBox tboxBasicGlobalPort;
        private System.Windows.Forms.TextBox tboxBaiscPacPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboxBasicSysProxyMode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPac;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox chkBasicAutoUpdateSysProxy;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox chkBasicPacAlwaysOn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBasicBrowseCustomPac;
        private System.Windows.Forms.TextBox tboxBasicCustomPacPath;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbBasicCurPacServerStatus;
        private System.Windows.Forms.Button btnBasicDebugPacServer;
        private System.Windows.Forms.Button btnBasicStartPacServer;
        private System.Windows.Forms.Button btnBasicStopPacServer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox rtboxPacWhiteList;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox rtboxPacBlackList;
        private System.Windows.Forms.ComboBox cboxBasicPacMode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbBasicProxyLink;
        private System.Windows.Forms.Button btnBaiscCopyProxyLink;
        private System.Windows.Forms.CheckBox chkBasicUseCustomPac;
        private System.Windows.Forms.ComboBox cboxBasicPacProtocol;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBasicClearSysProxy;
    }
}