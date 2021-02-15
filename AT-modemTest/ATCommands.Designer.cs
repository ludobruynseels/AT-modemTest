namespace AT_modemTest
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.scinScript = new ScintillaNET.Scintilla();
            this.copyCommandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.logContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyCommandToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.scriptContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyCommandToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clearWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runScriptToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.logContextMenu.SuspendLayout();
            this.scriptContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // scinLog
            // 
            this.scinLog.ContextMenuStrip = this.logContextMenu;
            this.scinLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.scinLog.Location = new System.Drawing.Point(0, 25);
            this.scinLog.Margin = new System.Windows.Forms.Padding(25);
            this.scinLog.Name = "scinLog";
            this.scinLog.ScrollWidth = 500;
            this.scinLog.Size = new System.Drawing.Size(266, 349);
            this.scinLog.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ContextMenuStrip = this.logContextMenu;
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
            this.saveLogToolStripMenuItem,
            this.openScriptToolStripMenuItem,
            this.runScriptToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // saveLogToolStripMenuItem
            // 
            this.saveLogToolStripMenuItem.Name = "saveLogToolStripMenuItem";
            this.saveLogToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveLogToolStripMenuItem.Text = "Save &log";
            this.saveLogToolStripMenuItem.Click += new System.EventHandler(this.saveLogToolStripMenuItem_Click);
            // 
            // openScriptToolStripMenuItem
            // 
            this.openScriptToolStripMenuItem.Name = "openScriptToolStripMenuItem";
            this.openScriptToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openScriptToolStripMenuItem.Text = "Open &script";
            this.openScriptToolStripMenuItem.Click += new System.EventHandler(this.openScriptToolStripMenuItem_Click);
            // 
            // runScriptToolStripMenuItem
            // 
            this.runScriptToolStripMenuItem.Name = "runScriptToolStripMenuItem";
            this.runScriptToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.runScriptToolStripMenuItem.Text = "Run Script";
            this.runScriptToolStripMenuItem.Click += new System.EventHandler(this.runScriptToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(0, 76);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.scinLog);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.scinScript);
            this.splitContainer1.Size = new System.Drawing.Size(800, 374);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 7;
            // 
            // scinScript
            // 
            this.scinScript.ContextMenuStrip = this.scriptContextMenu;
            this.scinScript.Location = new System.Drawing.Point(0, 25);
            this.scinScript.Name = "scinScript";
            this.scinScript.Size = new System.Drawing.Size(530, 350);
            this.scinScript.TabIndex = 0;
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
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 33);
            this.panel1.TabIndex = 8;
            // 
            // txtCommand
            // 
            this.txtCommand.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCommand.Location = new System.Drawing.Point(3, 3);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(514, 20);
            this.txtCommand.TabIndex = 3;
            this.txtCommand.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCommand_KeyPress);
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
            // logContextMenu
            // 
            this.logContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyCommandToolStripMenuItem1,
            this.clearWindowToolStripMenuItem});
            this.logContextMenu.Name = "logContextMenu";
            this.logContextMenu.Size = new System.Drawing.Size(163, 48);
            // 
            // copyCommandToolStripMenuItem1
            // 
            this.copyCommandToolStripMenuItem1.Name = "copyCommandToolStripMenuItem1";
            this.copyCommandToolStripMenuItem1.Size = new System.Drawing.Size(162, 22);
            this.copyCommandToolStripMenuItem1.Text = "Copy Command";
            this.copyCommandToolStripMenuItem1.Click += new System.EventHandler(this.copyCommandToolStripMenuItem1_Click);
            // 
            // scriptContextMenu
            // 
            this.scriptContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyCommandToolStripMenuItem2,
            this.runScriptToolStripMenuItem1});
            this.scriptContextMenu.Name = "scriptContextMenu";
            this.scriptContextMenu.Size = new System.Drawing.Size(181, 70);
            // 
            // copyCommandToolStripMenuItem2
            // 
            this.copyCommandToolStripMenuItem2.Name = "copyCommandToolStripMenuItem2";
            this.copyCommandToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.copyCommandToolStripMenuItem2.Text = "Copy command";
            this.copyCommandToolStripMenuItem2.Click += new System.EventHandler(this.copyCommandToolStripMenuItem2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "at command log";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(146, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "at command script";
            // 
            // clearWindowToolStripMenuItem
            // 
            this.clearWindowToolStripMenuItem.Name = "clearWindowToolStripMenuItem";
            this.clearWindowToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clearWindowToolStripMenuItem.Text = "Clear window";
            this.clearWindowToolStripMenuItem.Click += new System.EventHandler(this.clearWindowToolStripMenuItem_Click);
            // 
            // runScriptToolStripMenuItem1
            // 
            this.runScriptToolStripMenuItem1.Name = "runScriptToolStripMenuItem1";
            this.runScriptToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.runScriptToolStripMenuItem1.Text = "Run Script";
            this.runScriptToolStripMenuItem1.Click += new System.EventHandler(this.runScriptToolStripMenuItem1_Click);
            // 
            // AtCommands
            // 
            this.AcceptButton = this.btnSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AtCommands";
            this.Text = "AT commands";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.logContextMenu.ResumeLayout(false);
            this.scriptContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ScintillaNET.Scintilla scinLog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openScriptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private ScintillaNET.Scintilla scinScript;
        private System.Windows.Forms.ToolStripMenuItem runScriptToolStripMenuItem;
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
    }
}

