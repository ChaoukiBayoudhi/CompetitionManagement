namespace CompetitionManagement
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.playerMangementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletePlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teamMangementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTeamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyTeamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteTeamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showTeamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllTeamsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPlayersOfTeamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playerMangementToolStripMenuItem,
            this.teamMangementToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(748, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // playerMangementToolStripMenuItem
            // 
            this.playerMangementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPlayerToolStripMenuItem,
            this.modifyPlayerToolStripMenuItem,
            this.deletePlayerToolStripMenuItem,
            this.showPlayerToolStripMenuItem});
            this.playerMangementToolStripMenuItem.Name = "playerMangementToolStripMenuItem";
            this.playerMangementToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.playerMangementToolStripMenuItem.Text = "Player Mangement";
            this.playerMangementToolStripMenuItem.Click += new System.EventHandler(this.playerMangementToolStripMenuItem_Click);
            // 
            // addPlayerToolStripMenuItem
            // 
            this.addPlayerToolStripMenuItem.Name = "addPlayerToolStripMenuItem";
            this.addPlayerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addPlayerToolStripMenuItem.Text = "Add Player";
            this.addPlayerToolStripMenuItem.Click += new System.EventHandler(this.addPlayerToolStripMenuItem_Click);
            // 
            // modifyPlayerToolStripMenuItem
            // 
            this.modifyPlayerToolStripMenuItem.Name = "modifyPlayerToolStripMenuItem";
            this.modifyPlayerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modifyPlayerToolStripMenuItem.Text = "Modify Player";
            // 
            // deletePlayerToolStripMenuItem
            // 
            this.deletePlayerToolStripMenuItem.Name = "deletePlayerToolStripMenuItem";
            this.deletePlayerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deletePlayerToolStripMenuItem.Text = "Delete Player";
            this.deletePlayerToolStripMenuItem.Click += new System.EventHandler(this.deletePlayerToolStripMenuItem_Click);
            // 
            // showPlayerToolStripMenuItem
            // 
            this.showPlayerToolStripMenuItem.Name = "showPlayerToolStripMenuItem";
            this.showPlayerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showPlayerToolStripMenuItem.Text = "Show Player";
            // 
            // teamMangementToolStripMenuItem
            // 
            this.teamMangementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTeamToolStripMenuItem,
            this.modifyTeamToolStripMenuItem,
            this.deleteTeamToolStripMenuItem,
            this.showTeamToolStripMenuItem,
            this.showAllTeamsToolStripMenuItem,
            this.showPlayersOfTeamToolStripMenuItem});
            this.teamMangementToolStripMenuItem.Name = "teamMangementToolStripMenuItem";
            this.teamMangementToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.teamMangementToolStripMenuItem.Text = "Team Mangement";
            // 
            // addTeamToolStripMenuItem
            // 
            this.addTeamToolStripMenuItem.Name = "addTeamToolStripMenuItem";
            this.addTeamToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.addTeamToolStripMenuItem.Text = "Add Team";
            this.addTeamToolStripMenuItem.Click += new System.EventHandler(this.addTeamToolStripMenuItem_Click);
            // 
            // modifyTeamToolStripMenuItem
            // 
            this.modifyTeamToolStripMenuItem.Name = "modifyTeamToolStripMenuItem";
            this.modifyTeamToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.modifyTeamToolStripMenuItem.Text = "Modify Team";
            // 
            // deleteTeamToolStripMenuItem
            // 
            this.deleteTeamToolStripMenuItem.Name = "deleteTeamToolStripMenuItem";
            this.deleteTeamToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.deleteTeamToolStripMenuItem.Text = "Delete Team";
            // 
            // showTeamToolStripMenuItem
            // 
            this.showTeamToolStripMenuItem.Name = "showTeamToolStripMenuItem";
            this.showTeamToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.showTeamToolStripMenuItem.Text = "Show Team";
            // 
            // showAllTeamsToolStripMenuItem
            // 
            this.showAllTeamsToolStripMenuItem.Name = "showAllTeamsToolStripMenuItem";
            this.showAllTeamsToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.showAllTeamsToolStripMenuItem.Text = "Show All Teams";
            // 
            // showPlayersOfTeamToolStripMenuItem
            // 
            this.showPlayersOfTeamToolStripMenuItem.Name = "showPlayersOfTeamToolStripMenuItem";
            this.showPlayersOfTeamToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.showPlayersOfTeamToolStripMenuItem.Text = "show Players Of Team";
            this.showPlayersOfTeamToolStripMenuItem.Click += new System.EventHandler(this.showPlayersOfTeamToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 397);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem playerMangementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyPlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletePlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teamMangementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTeamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyTeamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteTeamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showTeamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAllTeamsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPlayersOfTeamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}