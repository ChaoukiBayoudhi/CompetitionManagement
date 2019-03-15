using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompetitionManagement
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
          DialogResult res=MessageBox.Show("Would you really exit?", "Exit Confirmation",  MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
                Application.Exit();
        }

        private void addPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPlayerForm f1 = new AddPlayerForm();
            f1.MdiParent = this;
            f1.Show();
        }

        private void deletePlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeletePlayerForm f1 = new DeletePlayerForm();
            f1.MdiParent = this;
            f1.Show();
        }

        private void addTeamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTeamForm f1 = new AddTeamForm(playerMangementToolStripMenuItem,addPlayerToolStripMenuItem);
            f1.MdiParent = this;
            f1.Show();
        }

        private void showPlayersOfTeamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowPlayersOfATeam f1 = new ShowPlayersOfATeam();
            f1.MdiParent = this;
            f1.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void playerMangementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AddPlayerForm.C1.Teams.Count == 0)
            {
                playerMangementToolStripMenuItem.Enabled = false;
                deletePlayerToolStripMenuItem.Enabled = false;
                addPlayerToolStripMenuItem.Enabled = false;
                modifyPlayerToolStripMenuItem.Enabled = false;
                showPlayerToolStripMenuItem.Enabled = false;
            }else
            {
                playerMangementToolStripMenuItem.Enabled = true;

                
                if (AddPlayerForm.C1.Teams[0].LstPlayers.Count > 0)
                {
                    deletePlayerToolStripMenuItem.Enabled = true;
                    addPlayerToolStripMenuItem.Enabled = true;
                    modifyPlayerToolStripMenuItem.Enabled = true;
                    showPlayerToolStripMenuItem.Enabled = true;
                }
                }

        }
    }
}
