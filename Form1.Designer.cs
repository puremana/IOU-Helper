﻿namespace IOU_Helper
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iOUHelperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iOUChatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iOUForumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iOUWikiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startAutoClickerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.closeTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxKongUser = new System.Windows.Forms.TextBox();
            this.groupBoxAccount = new System.Windows.Forms.GroupBox();
            this.textBoxKongToken = new System.Windows.Forms.TextBox();
            this.textBoxKongID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonStartClient = new System.Windows.Forms.Button();
            this.IOUtitle = new System.Windows.Forms.Label();
            this.AutoSave = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.oldIOUclient = new System.Windows.Forms.WebBrowser();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.startAutoClickerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshTimer = new System.Windows.Forms.Timer(this.components);
            this.autoClickTimer = new System.Windows.Forms.Timer(this.components);
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.IOUclient = new WebKit.WebKitBrowser();
            this.menuStrip1.SuspendLayout();
            this.groupBoxAccount.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.linksToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 49);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.newTabToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(75, 45);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(213, 46);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // newTabToolStripMenuItem
            // 
            this.newTabToolStripMenuItem.Name = "newTabToolStripMenuItem";
            this.newTabToolStripMenuItem.Size = new System.Drawing.Size(213, 46);
            this.newTabToolStripMenuItem.Text = "New Tab";
            this.newTabToolStripMenuItem.Click += new System.EventHandler(this.newTabToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(213, 46);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(213, 46);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(213, 46);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(210, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(213, 46);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(137, 45);
            this.optionsToolStripMenuItem.Text = "Settings";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // linksToolStripMenuItem
            // 
            this.linksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iOUHelperToolStripMenuItem,
            this.iOUChatToolStripMenuItem,
            this.iOUForumToolStripMenuItem,
            this.iOUWikiToolStripMenuItem});
            this.linksToolStripMenuItem.Name = "linksToolStripMenuItem";
            this.linksToolStripMenuItem.Size = new System.Drawing.Size(96, 45);
            this.linksToolStripMenuItem.Text = "Links";
            // 
            // iOUHelperToolStripMenuItem
            // 
            this.iOUHelperToolStripMenuItem.Name = "iOUHelperToolStripMenuItem";
            this.iOUHelperToolStripMenuItem.Size = new System.Drawing.Size(244, 46);
            this.iOUHelperToolStripMenuItem.Text = "IOU Helper";
            this.iOUHelperToolStripMenuItem.Click += new System.EventHandler(this.iOUHelperToolStripMenuItem_Click);
            // 
            // iOUChatToolStripMenuItem
            // 
            this.iOUChatToolStripMenuItem.Name = "iOUChatToolStripMenuItem";
            this.iOUChatToolStripMenuItem.Size = new System.Drawing.Size(244, 46);
            this.iOUChatToolStripMenuItem.Text = "IOU Chat";
            this.iOUChatToolStripMenuItem.Click += new System.EventHandler(this.iOUChatToolStripMenuItem_Click);
            // 
            // iOUForumToolStripMenuItem
            // 
            this.iOUForumToolStripMenuItem.Name = "iOUForumToolStripMenuItem";
            this.iOUForumToolStripMenuItem.Size = new System.Drawing.Size(244, 46);
            this.iOUForumToolStripMenuItem.Text = "IOU Forum";
            this.iOUForumToolStripMenuItem.Click += new System.EventHandler(this.iOUForumToolStripMenuItem_Click);
            // 
            // iOUWikiToolStripMenuItem
            // 
            this.iOUWikiToolStripMenuItem.Name = "iOUWikiToolStripMenuItem";
            this.iOUWikiToolStripMenuItem.Size = new System.Drawing.Size(244, 46);
            this.iOUWikiToolStripMenuItem.Text = "IOU Wiki";
            this.iOUWikiToolStripMenuItem.Click += new System.EventHandler(this.iOUWikiToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startAutoClickerToolStripMenuItem1,
            this.refreshToolStripMenuItem1,
            this.closeTabToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(102, 45);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // startAutoClickerToolStripMenuItem1
            // 
            this.startAutoClickerToolStripMenuItem1.Name = "startAutoClickerToolStripMenuItem1";
            this.startAutoClickerToolStripMenuItem1.Size = new System.Drawing.Size(317, 46);
            this.startAutoClickerToolStripMenuItem1.Text = "Start AutoClicker";
            this.startAutoClickerToolStripMenuItem1.Click += new System.EventHandler(this.startAutoClickerToolStripMenuItem1_Click);
            // 
            // refreshToolStripMenuItem1
            // 
            this.refreshToolStripMenuItem1.Name = "refreshToolStripMenuItem1";
            this.refreshToolStripMenuItem1.Size = new System.Drawing.Size(317, 46);
            this.refreshToolStripMenuItem1.Text = "Refresh";
            this.refreshToolStripMenuItem1.Click += new System.EventHandler(this.refreshToolStripMenuItem1_Click);
            // 
            // closeTabToolStripMenuItem
            // 
            this.closeTabToolStripMenuItem.Name = "closeTabToolStripMenuItem";
            this.closeTabToolStripMenuItem.Size = new System.Drawing.Size(317, 46);
            this.closeTabToolStripMenuItem.Text = "Close Tab";
            this.closeTabToolStripMenuItem.Click += new System.EventHandler(this.closeTabToolStripMenuItem_Click);
            // 
            // textBoxKongUser
            // 
            this.textBoxKongUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.textBoxKongUser.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxKongUser.Location = new System.Drawing.Point(412, 87);
            this.textBoxKongUser.Name = "textBoxKongUser";
            this.textBoxKongUser.Size = new System.Drawing.Size(432, 38);
            this.textBoxKongUser.TabIndex = 2;
            // 
            // groupBoxAccount
            // 
            this.groupBoxAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxAccount.Controls.Add(this.textBoxKongToken);
            this.groupBoxAccount.Controls.Add(this.textBoxKongID);
            this.groupBoxAccount.Controls.Add(this.label3);
            this.groupBoxAccount.Controls.Add(this.label2);
            this.groupBoxAccount.Controls.Add(this.label1);
            this.groupBoxAccount.Controls.Add(this.textBoxKongUser);
            this.groupBoxAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.groupBoxAccount.Location = new System.Drawing.Point(182, 190);
            this.groupBoxAccount.Name = "groupBoxAccount";
            this.groupBoxAccount.Size = new System.Drawing.Size(910, 326);
            this.groupBoxAccount.TabIndex = 3;
            this.groupBoxAccount.TabStop = false;
            this.groupBoxAccount.Text = "Account Details";
            // 
            // textBoxKongToken
            // 
            this.textBoxKongToken.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.textBoxKongToken.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxKongToken.Location = new System.Drawing.Point(412, 215);
            this.textBoxKongToken.Name = "textBoxKongToken";
            this.textBoxKongToken.Size = new System.Drawing.Size(432, 38);
            this.textBoxKongToken.TabIndex = 7;
            // 
            // textBoxKongID
            // 
            this.textBoxKongID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.textBoxKongID.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxKongID.Location = new System.Drawing.Point(412, 151);
            this.textBoxKongID.Name = "textBoxKongID";
            this.textBoxKongID.Size = new System.Drawing.Size(432, 38);
            this.textBoxKongID.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.label3.Location = new System.Drawing.Point(32, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kongregate Token :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.label2.Location = new System.Drawing.Point(32, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kongregate ID : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.label1.Location = new System.Drawing.Point(32, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kongregate Username : ";
            // 
            // buttonStartClient
            // 
            this.buttonStartClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonStartClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.buttonStartClient.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.buttonStartClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStartClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.buttonStartClient.Location = new System.Drawing.Point(407, 593);
            this.buttonStartClient.Name = "buttonStartClient";
            this.buttonStartClient.Size = new System.Drawing.Size(495, 143);
            this.buttonStartClient.TabIndex = 4;
            this.buttonStartClient.Text = "Start Client";
            this.buttonStartClient.UseVisualStyleBackColor = false;
            this.buttonStartClient.Click += new System.EventHandler(this.buttonStartClient_Click);
            // 
            // IOUtitle
            // 
            this.IOUtitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IOUtitle.AutoSize = true;
            this.IOUtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IOUtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.IOUtitle.Location = new System.Drawing.Point(389, 50);
            this.IOUtitle.Name = "IOUtitle";
            this.IOUtitle.Size = new System.Drawing.Size(510, 105);
            this.IOUtitle.TabIndex = 5;
            this.IOUtitle.Text = "IOU Helper";
            // 
            // AutoSave
            // 
            this.AutoSave.FileName = "openFileDialog1";
            // 
            // oldIOUclient
            // 
            this.oldIOUclient.AllowWebBrowserDrop = false;
            this.oldIOUclient.IsWebBrowserContextMenuEnabled = false;
            this.oldIOUclient.Location = new System.Drawing.Point(0, 0);
            this.oldIOUclient.Margin = new System.Windows.Forms.Padding(0);
            this.oldIOUclient.MinimumSize = new System.Drawing.Size(20, 20);
            this.oldIOUclient.Name = "oldIOUclient";
            this.oldIOUclient.ScrollBarsEnabled = false;
            this.oldIOUclient.Size = new System.Drawing.Size(290, 214);
            this.oldIOUclient.TabIndex = 6;
            this.oldIOUclient.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startAutoClickerToolStripMenuItem,
            this.refreshToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.contextMenuStrip1.Size = new System.Drawing.Size(318, 96);
            // 
            // startAutoClickerToolStripMenuItem
            // 
            this.startAutoClickerToolStripMenuItem.Name = "startAutoClickerToolStripMenuItem";
            this.startAutoClickerToolStripMenuItem.Size = new System.Drawing.Size(317, 46);
            this.startAutoClickerToolStripMenuItem.Text = "Start AutoClicker";
            this.startAutoClickerToolStripMenuItem.Click += new System.EventHandler(this.startAutoClickerToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(317, 46);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // refreshTimer
            // 
            this.refreshTimer.Interval = 1800;
            this.refreshTimer.Tick += new System.EventHandler(this.refreshTimer_Tick);
            // 
            // autoClickTimer
            // 
            this.autoClickTimer.Tick += new System.EventHandler(this.autoClickTimer_Tick);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Location = new System.Drawing.Point(0, 52);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1274, 881);
            this.tabControl.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.tabPage1.Controls.Add(this.IOUclient);
            this.tabPage1.Controls.Add(this.IOUtitle);
            this.tabPage1.Controls.Add(this.buttonStartClient);
            this.tabPage1.Controls.Add(this.groupBoxAccount);
            this.tabPage1.Controls.Add(this.oldIOUclient);
            this.tabPage1.Location = new System.Drawing.Point(4, 40);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1266, 837);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Client";
            // 
            // IOUclient
            // 
            this.IOUclient.BackColor = System.Drawing.Color.White;
            this.IOUclient.Location = new System.Drawing.Point(-4, 0);
            this.IOUclient.Name = "IOUclient";
            this.IOUclient.Size = new System.Drawing.Size(319, 214);
            this.IOUclient.TabIndex = 7;
            this.IOUclient.Url = null;
            this.IOUclient.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(1264, 926);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IOU Helper v1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxAccount.ResumeLayout(false);
            this.groupBoxAccount.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iOUHelperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iOUForumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iOUChatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxKongUser;
        private System.Windows.Forms.GroupBox groupBoxAccount;
        private System.Windows.Forms.TextBox textBoxKongToken;
        private System.Windows.Forms.TextBox textBoxKongID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonStartClient;
        private System.Windows.Forms.Label IOUtitle;
        private System.Windows.Forms.OpenFileDialog AutoSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.WebBrowser oldIOUclient;
        private System.Windows.Forms.ToolStripMenuItem iOUWikiToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem startAutoClickerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem startAutoClickerToolStripMenuItem1;
        private System.Windows.Forms.Timer refreshTimer;
        private System.Windows.Forms.Timer autoClickTimer;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ToolStripMenuItem newTabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeTabToolStripMenuItem;
        private WebKit.WebKitBrowser IOUclient;
    }
}

