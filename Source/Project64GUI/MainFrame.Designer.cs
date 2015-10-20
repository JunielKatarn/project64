namespace Project64.GUI
{
	partial class MainFrame
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
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openROMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.endEmulationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.chooseROMDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.refreshROMListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fullScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.configureGraphicsPluginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.configureAudioPluginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.configureControllerPluginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.supportForumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
			this.aboutProject64ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// statusStrip1
			// 
			this.statusStrip1.Location = new System.Drawing.Point(0, 471);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(624, 22);
			this.statusStrip1.TabIndex = 0;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(624, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openROMToolStripMenuItem,
            this.endEmulationToolStripMenuItem,
            this.toolStripSeparator1,
            this.languageToolStripMenuItem,
            this.toolStripSeparator2,
            this.chooseROMDirectoryToolStripMenuItem,
            this.refreshROMListToolStripMenuItem,
            this.toolStripSeparator3,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// openROMToolStripMenuItem
			// 
			this.openROMToolStripMenuItem.Name = "openROMToolStripMenuItem";
			this.openROMToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.openROMToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
			this.openROMToolStripMenuItem.Text = "Open ROM";
			// 
			// endEmulationToolStripMenuItem
			// 
			this.endEmulationToolStripMenuItem.Name = "endEmulationToolStripMenuItem";
			this.endEmulationToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
			this.endEmulationToolStripMenuItem.Text = "End Emulation";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(201, 6);
			// 
			// languageToolStripMenuItem
			// 
			this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
			this.languageToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
			this.languageToolStripMenuItem.Text = "Language";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(201, 6);
			// 
			// chooseROMDirectoryToolStripMenuItem
			// 
			this.chooseROMDirectoryToolStripMenuItem.Name = "chooseROMDirectoryToolStripMenuItem";
			this.chooseROMDirectoryToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
			this.chooseROMDirectoryToolStripMenuItem.Text = "Choose ROM Directory...";
			// 
			// refreshROMListToolStripMenuItem
			// 
			this.refreshROMListToolStripMenuItem.Name = "refreshROMListToolStripMenuItem";
			this.refreshROMListToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
			this.refreshROMListToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
			this.refreshROMListToolStripMenuItem.Text = "Refresh ROM List";
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(201, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			// 
			// optionsToolStripMenuItem
			// 
			this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fullScreenToolStripMenuItem,
            this.toolStripSeparator4,
            this.configureGraphicsPluginToolStripMenuItem,
            this.configureAudioPluginToolStripMenuItem,
            this.configureControllerPluginToolStripMenuItem,
            this.toolStripSeparator5,
            this.settingsToolStripMenuItem});
			this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
			this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
			this.optionsToolStripMenuItem.Text = "Options";
			// 
			// fullScreenToolStripMenuItem
			// 
			this.fullScreenToolStripMenuItem.Name = "fullScreenToolStripMenuItem";
			this.fullScreenToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
			this.fullScreenToolStripMenuItem.Text = "Full Screen";
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(226, 6);
			// 
			// configureGraphicsPluginToolStripMenuItem
			// 
			this.configureGraphicsPluginToolStripMenuItem.Name = "configureGraphicsPluginToolStripMenuItem";
			this.configureGraphicsPluginToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
			this.configureGraphicsPluginToolStripMenuItem.Text = "Configure Graphics Plugin...";
			// 
			// configureAudioPluginToolStripMenuItem
			// 
			this.configureAudioPluginToolStripMenuItem.Name = "configureAudioPluginToolStripMenuItem";
			this.configureAudioPluginToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
			this.configureAudioPluginToolStripMenuItem.Text = "Configure Audio Plugin...";
			// 
			// configureControllerPluginToolStripMenuItem
			// 
			this.configureControllerPluginToolStripMenuItem.Name = "configureControllerPluginToolStripMenuItem";
			this.configureControllerPluginToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
			this.configureControllerPluginToolStripMenuItem.Text = "Configure Controller Plugin...";
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(226, 6);
			// 
			// settingsToolStripMenuItem
			// 
			this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
			this.settingsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
			this.settingsToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
			this.settingsToolStripMenuItem.Text = "Settings";
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supportForumToolStripMenuItem,
            this.homeToolStripMenuItem,
            this.toolStripSeparator6,
            this.aboutProject64ToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// supportForumToolStripMenuItem
			// 
			this.supportForumToolStripMenuItem.Name = "supportForumToolStripMenuItem";
			this.supportForumToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
			this.supportForumToolStripMenuItem.Text = "Support Forum";
			// 
			// homeToolStripMenuItem
			// 
			this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
			this.homeToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
			this.homeToolStripMenuItem.Text = "Homepage";
			this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
			// 
			// toolStripSeparator6
			// 
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			this.toolStripSeparator6.Size = new System.Drawing.Size(156, 6);
			// 
			// aboutProject64ToolStripMenuItem
			// 
			this.aboutProject64ToolStripMenuItem.Name = "aboutProject64ToolStripMenuItem";
			this.aboutProject64ToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
			this.aboutProject64ToolStripMenuItem.Text = "About Project64";
			// 
			// MainFrame
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(624, 493);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainFrame";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Project 64 {0}";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openROMToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem endEmulationToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem chooseROMDirectoryToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem refreshROMListToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fullScreenToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripMenuItem configureGraphicsPluginToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem configureAudioPluginToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem configureControllerPluginToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem supportForumToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
		private System.Windows.Forms.ToolStripMenuItem aboutProject64ToolStripMenuItem;
	}
}

