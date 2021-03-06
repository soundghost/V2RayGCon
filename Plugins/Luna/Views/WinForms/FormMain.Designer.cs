﻿namespace Luna.Views.WinForms
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
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbStatusBarMsg = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnStopAllScript = new System.Windows.Forms.Button();
            this.btnKillAllScript = new System.Windows.Forms.Button();
            this.flyScriptUIContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.tabEditor = new System.Windows.Forms.TabPage();
            this.splitContainerTabEditor = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNewScript = new System.Windows.Forms.Button();
            this.cboxScriptName = new System.Windows.Forms.ComboBox();
            this.btnClearOutput = new System.Windows.Forms.Button();
            this.btnKillScript = new System.Windows.Forms.Button();
            this.btnStopScript = new System.Windows.Forms.Button();
            this.btnRunScript = new System.Windows.Forms.Button();
            this.btnRemoveScript = new System.Windows.Forms.Button();
            this.btnSaveScript = new System.Windows.Forms.Button();
            this.pnlScriptEditor = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtBoxOutput = new System.Windows.Forms.RichTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTabEditor)).BeginInit();
            this.splitContainerTabEditor.Panel1.SuspendLayout();
            this.splitContainerTabEditor.Panel2.SuspendLayout();
            this.splitContainerTabEditor.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.statusStrip1);
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tabControl1);
            resources.ApplyResources(this.toolStripContainer1.ContentPanel, "toolStripContainer1.ContentPanel");
            resources.ApplyResources(this.toolStripContainer1, "toolStripContainer1");
            this.toolStripContainer1.Name = "toolStripContainer1";
            // 
            // statusStrip1
            // 
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbStatusBarMsg});
            this.statusStrip1.Name = "statusStrip1";
            // 
            // lbStatusBarMsg
            // 
            this.lbStatusBarMsg.Name = "lbStatusBarMsg";
            resources.ApplyResources(this.lbStatusBarMsg, "lbStatusBarMsg");
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabGeneral);
            this.tabControl1.Controls.Add(this.tabEditor);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.panel2);
            this.tabGeneral.Controls.Add(this.flyScriptUIContainer);
            resources.ApplyResources(this.tabGeneral, "tabGeneral");
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Controls.Add(this.btnStopAllScript);
            this.panel2.Controls.Add(this.btnKillAllScript);
            this.panel2.Name = "panel2";
            // 
            // btnStopAllScript
            // 
            resources.ApplyResources(this.btnStopAllScript, "btnStopAllScript");
            this.btnStopAllScript.Name = "btnStopAllScript";
            this.toolTip1.SetToolTip(this.btnStopAllScript, resources.GetString("btnStopAllScript.ToolTip"));
            this.btnStopAllScript.UseVisualStyleBackColor = true;
            // 
            // btnKillAllScript
            // 
            resources.ApplyResources(this.btnKillAllScript, "btnKillAllScript");
            this.btnKillAllScript.Name = "btnKillAllScript";
            this.toolTip1.SetToolTip(this.btnKillAllScript, resources.GetString("btnKillAllScript.ToolTip"));
            this.btnKillAllScript.UseVisualStyleBackColor = true;
            // 
            // flyScriptUIContainer
            // 
            resources.ApplyResources(this.flyScriptUIContainer, "flyScriptUIContainer");
            this.flyScriptUIContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flyScriptUIContainer.Name = "flyScriptUIContainer";
            // 
            // tabEditor
            // 
            this.tabEditor.Controls.Add(this.splitContainerTabEditor);
            resources.ApplyResources(this.tabEditor, "tabEditor");
            this.tabEditor.Name = "tabEditor";
            this.tabEditor.UseVisualStyleBackColor = true;
            // 
            // splitContainerTabEditor
            // 
            resources.ApplyResources(this.splitContainerTabEditor, "splitContainerTabEditor");
            this.splitContainerTabEditor.Name = "splitContainerTabEditor";
            // 
            // splitContainerTabEditor.Panel1
            // 
            this.splitContainerTabEditor.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainerTabEditor.Panel2
            // 
            this.splitContainerTabEditor.Panel2.Controls.Add(this.groupBox1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlScriptEditor, 0, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnNewScript);
            this.panel1.Controls.Add(this.cboxScriptName);
            this.panel1.Controls.Add(this.btnClearOutput);
            this.panel1.Controls.Add(this.btnKillScript);
            this.panel1.Controls.Add(this.btnStopScript);
            this.panel1.Controls.Add(this.btnRunScript);
            this.panel1.Controls.Add(this.btnRemoveScript);
            this.panel1.Controls.Add(this.btnSaveScript);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // btnNewScript
            // 
            resources.ApplyResources(this.btnNewScript, "btnNewScript");
            this.btnNewScript.Name = "btnNewScript";
            this.toolTip1.SetToolTip(this.btnNewScript, resources.GetString("btnNewScript.ToolTip"));
            this.btnNewScript.UseVisualStyleBackColor = true;
            // 
            // cboxScriptName
            // 
            resources.ApplyResources(this.cboxScriptName, "cboxScriptName");
            this.cboxScriptName.FormattingEnabled = true;
            this.cboxScriptName.Name = "cboxScriptName";
            this.toolTip1.SetToolTip(this.cboxScriptName, resources.GetString("cboxScriptName.ToolTip"));
            // 
            // btnClearOutput
            // 
            resources.ApplyResources(this.btnClearOutput, "btnClearOutput");
            this.btnClearOutput.Name = "btnClearOutput";
            this.toolTip1.SetToolTip(this.btnClearOutput, resources.GetString("btnClearOutput.ToolTip"));
            this.btnClearOutput.UseVisualStyleBackColor = true;
            // 
            // btnKillScript
            // 
            resources.ApplyResources(this.btnKillScript, "btnKillScript");
            this.btnKillScript.Name = "btnKillScript";
            this.toolTip1.SetToolTip(this.btnKillScript, resources.GetString("btnKillScript.ToolTip"));
            this.btnKillScript.UseVisualStyleBackColor = true;
            // 
            // btnStopScript
            // 
            resources.ApplyResources(this.btnStopScript, "btnStopScript");
            this.btnStopScript.Name = "btnStopScript";
            this.toolTip1.SetToolTip(this.btnStopScript, resources.GetString("btnStopScript.ToolTip"));
            this.btnStopScript.UseVisualStyleBackColor = true;
            // 
            // btnRunScript
            // 
            resources.ApplyResources(this.btnRunScript, "btnRunScript");
            this.btnRunScript.Name = "btnRunScript";
            this.toolTip1.SetToolTip(this.btnRunScript, resources.GetString("btnRunScript.ToolTip"));
            this.btnRunScript.UseVisualStyleBackColor = true;
            // 
            // btnRemoveScript
            // 
            resources.ApplyResources(this.btnRemoveScript, "btnRemoveScript");
            this.btnRemoveScript.Name = "btnRemoveScript";
            this.toolTip1.SetToolTip(this.btnRemoveScript, resources.GetString("btnRemoveScript.ToolTip"));
            this.btnRemoveScript.UseVisualStyleBackColor = true;
            // 
            // btnSaveScript
            // 
            resources.ApplyResources(this.btnSaveScript, "btnSaveScript");
            this.btnSaveScript.Name = "btnSaveScript";
            this.toolTip1.SetToolTip(this.btnSaveScript, resources.GetString("btnSaveScript.ToolTip"));
            this.btnSaveScript.UseVisualStyleBackColor = true;
            // 
            // pnlScriptEditor
            // 
            resources.ApplyResources(this.pnlScriptEditor, "pnlScriptEditor");
            this.pnlScriptEditor.Name = "pnlScriptEditor";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtBoxOutput);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // rtBoxOutput
            // 
            this.rtBoxOutput.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.rtBoxOutput, "rtBoxOutput");
            this.rtBoxOutput.Name = "rtBoxOutput";
            this.rtBoxOutput.ReadOnly = true;
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStripContainer1);
            this.KeyPreview = true;
            this.Name = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabEditor.ResumeLayout(false);
            this.splitContainerTabEditor.Panel1.ResumeLayout(false);
            this.splitContainerTabEditor.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTabEditor)).EndInit();
            this.splitContainerTabEditor.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbStatusBarMsg;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.Button btnKillAllScript;
        private System.Windows.Forms.Button btnStopAllScript;
        private System.Windows.Forms.FlowLayoutPanel flyScriptUIContainer;
        private System.Windows.Forms.TabPage tabEditor;
        private System.Windows.Forms.SplitContainer splitContainerTabEditor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboxScriptName;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnKillScript;
        private System.Windows.Forms.Button btnStopScript;
        private System.Windows.Forms.Button btnRunScript;
        private System.Windows.Forms.Button btnRemoveScript;
        private System.Windows.Forms.Button btnSaveScript;
        private System.Windows.Forms.Panel pnlScriptEditor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtBoxOutput;
        private System.Windows.Forms.Button btnClearOutput;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnNewScript;
    }
}
