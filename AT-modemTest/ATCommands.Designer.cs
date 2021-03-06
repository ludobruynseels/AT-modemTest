﻿namespace AT_modemTest
{
    partial class AtCommands
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
            this.scinLog = new ScintillaNET.Scintilla();
            this.logContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyCommandToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clearWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveLogToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PortnameToolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.BaudrateToolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.scinScript = new ScintillaNET.Scintilla();
            this.scriptContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyCommandToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.runScriptToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openScriptToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.copyCommandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusPortname = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusBaudrate = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusModemCommand = new System.Windows.Forms.ToolStripStatusLabel();
            this.logContextMenu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.scriptContextMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // scinLog
            // 
            this.scinLog.ContextMenuStrip = this.logContextMenu;
            this.scinLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scinLog.Location = new System.Drawing.Point(0, 20);
            this.scinLog.Margin = new System.Windows.Forms.Padding(25);
            this.scinLog.Name = "scinLog";
            this.scinLog.ScrollWidth = 500;
            this.scinLog.Size = new System.Drawing.Size(430, 351);
            this.scinLog.TabIndex = 4;
            // 
            // logContextMenu
            // 
            this.logContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyCommandToolStripMenuItem1,
            this.clearWindowToolStripMenuItem,
            this.saveLogToolStripMenuItem1});
            this.logContextMenu.Name = "logContextMenu";
            this.logContextMenu.Size = new System.Drawing.Size(163, 70);
            // 
            // copyCommandToolStripMenuItem1
            // 
            this.copyCommandToolStripMenuItem1.Name = "copyCommandToolStripMenuItem1";
            this.copyCommandToolStripMenuItem1.Size = new System.Drawing.Size(162, 22);
            this.copyCommandToolStripMenuItem1.Text = "Copy Command";
            this.copyCommandToolStripMenuItem1.Click += new System.EventHandler(this.copyCommandToolStripMenuItem1_Click);
            // 
            // clearWindowToolStripMenuItem
            // 
            this.clearWindowToolStripMenuItem.Name = "clearWindowToolStripMenuItem";
            this.clearWindowToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.clearWindowToolStripMenuItem.Text = "Clear window";
            this.clearWindowToolStripMenuItem.Click += new System.EventHandler(this.clearWindowToolStripMenuItem_Click);
            // 
            // saveLogToolStripMenuItem1
            // 
            this.saveLogToolStripMenuItem1.Name = "saveLogToolStripMenuItem1";
            this.saveLogToolStripMenuItem1.Size = new System.Drawing.Size(162, 22);
            this.saveLogToolStripMenuItem1.Text = "Save log";
            this.saveLogToolStripMenuItem1.Click += new System.EventHandler(this.saveLogToolStripMenuItem1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PortnameToolStripComboBox1,
            this.BaudrateToolStripComboBox1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // PortnameToolStripComboBox1
            // 
            this.PortnameToolStripComboBox1.Name = "PortnameToolStripComboBox1";
            this.PortnameToolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            this.PortnameToolStripComboBox1.Text = "COM10";
            this.PortnameToolStripComboBox1.ToolTipText = "Portname";
            this.PortnameToolStripComboBox1.SelectedIndexChanged += new System.EventHandler(this.PortnameComboBox1_SelectedIndexChanged);
            // 
            // BaudrateToolStripComboBox1
            // 
            this.BaudrateToolStripComboBox1.Name = "BaudrateToolStripComboBox1";
            this.BaudrateToolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            this.BaudrateToolStripComboBox1.Text = "19200";
            this.BaudrateToolStripComboBox1.SelectedIndexChanged += new System.EventHandler(this.BaudrateToolStripComboBox1_SelectedIndexChanged);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 57);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.scinLog);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.scinScript);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Size = new System.Drawing.Size(800, 371);
            this.splitContainer1.SplitterDistance = 430;
            this.splitContainer1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "at command log";
            // 
            // scinScript
            // 
            this.scinScript.ContextMenuStrip = this.scriptContextMenu;
            this.scinScript.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scinScript.Location = new System.Drawing.Point(0, 20);
            this.scinScript.Name = "scinScript";
            this.scinScript.Size = new System.Drawing.Size(366, 351);
            this.scinScript.TabIndex = 0;
            // 
            // scriptContextMenu
            // 
            this.scriptContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyCommandToolStripMenuItem2,
            this.runScriptToolStripMenuItem1,
            this.openScriptToolStripMenuItem1,
            this.saveScriptToolStripMenuItem});
            this.scriptContextMenu.Name = "scriptContextMenu";
            this.scriptContextMenu.Size = new System.Drawing.Size(161, 92);
            // 
            // copyCommandToolStripMenuItem2
            // 
            this.copyCommandToolStripMenuItem2.Name = "copyCommandToolStripMenuItem2";
            this.copyCommandToolStripMenuItem2.Size = new System.Drawing.Size(160, 22);
            this.copyCommandToolStripMenuItem2.Text = "Copy command";
            this.copyCommandToolStripMenuItem2.Click += new System.EventHandler(this.copyCommandToolStripMenuItem2_Click);
            // 
            // runScriptToolStripMenuItem1
            // 
            this.runScriptToolStripMenuItem1.Name = "runScriptToolStripMenuItem1";
            this.runScriptToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.runScriptToolStripMenuItem1.Text = "Run Script";
            this.runScriptToolStripMenuItem1.Click += new System.EventHandler(this.runScriptToolStripMenuItem1_Click);
            // 
            // openScriptToolStripMenuItem1
            // 
            this.openScriptToolStripMenuItem1.Name = "openScriptToolStripMenuItem1";
            this.openScriptToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.openScriptToolStripMenuItem1.Text = "Open Script";
            this.openScriptToolStripMenuItem1.Click += new System.EventHandler(this.openScriptToolStripMenuItem1_Click);
            // 
            // saveScriptToolStripMenuItem
            // 
            this.saveScriptToolStripMenuItem.Name = "saveScriptToolStripMenuItem";
            this.saveScriptToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.saveScriptToolStripMenuItem.Text = "Save Script";
            this.saveScriptToolStripMenuItem.Click += new System.EventHandler(this.saveScriptToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "at command script";
            // 
            // copyCommandToolStripMenuItem
            // 
            this.copyCommandToolStripMenuItem.Name = "copyCommandToolStripMenuItem";
            this.copyCommandToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.copyCommandToolStripMenuItem.Text = "Copy -> command";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSend);
            this.panel1.Controls.Add(this.txtCommand);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 33);
            this.panel1.TabIndex = 8;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(523, 3);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Versturen";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // txtCommand
            // 
            this.txtCommand.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCommand.Location = new System.Drawing.Point(3, 5);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(514, 20);
            this.txtCommand.TabIndex = 3;
            this.txtCommand.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCommand_KeyPress);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusPortname,
            this.statusBaudrate,
            this.statusModemCommand});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusPortname
            // 
            this.statusPortname.Name = "statusPortname";
            this.statusPortname.Size = new System.Drawing.Size(118, 17);
            this.statusPortname.Text = "toolStripStatusLabel1";
            // 
            // statusBaudrate
            // 
            this.statusBaudrate.Name = "statusBaudrate";
            this.statusBaudrate.Size = new System.Drawing.Size(118, 17);
            this.statusBaudrate.Text = "toolStripStatusLabel2";
            // 
            // statusModemCommand
            // 
            this.statusModemCommand.Name = "statusModemCommand";
            this.statusModemCommand.Size = new System.Drawing.Size(18, 17);
            this.statusModemCommand.Text = "sa";
            // 
            // AtCommands
            // 
            this.AcceptButton = this.btnSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AtCommands";
            this.Text = "AT commands";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.logContextMenu.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.scriptContextMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ScintillaNET.Scintilla scinLog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private ScintillaNET.Scintilla scinScript;
        private System.Windows.Forms.ToolStripMenuItem copyCommandToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtCommand;
        private System.Windows.Forms.ContextMenuStrip logContextMenu;
        private System.Windows.Forms.ToolStripMenuItem copyCommandToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip scriptContextMenu;
        private System.Windows.Forms.ToolStripMenuItem copyCommandToolStripMenuItem2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem clearWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runScriptToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openScriptToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveLogToolStripMenuItem1;
        private System.Windows.Forms.ToolStripComboBox PortnameToolStripComboBox1;
        private System.Windows.Forms.ToolStripComboBox BaudrateToolStripComboBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusPortname;
        private System.Windows.Forms.ToolStripStatusLabel statusBaudrate;
        private System.Windows.Forms.ToolStripMenuItem saveScriptToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel statusModemCommand;
    }
}

