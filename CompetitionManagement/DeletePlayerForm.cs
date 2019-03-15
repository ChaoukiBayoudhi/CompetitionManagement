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
    public partial class DeletePlayerForm : Form
    {
        public DeletePlayerForm()
        {
            InitializeComponent();
        }

        private void DeletePlayerForm_Load(object sender, EventArgs e)
        {
           cmb_Team.DataSource = AddPlayerForm.C1.TeamNames();
           groupBox1.Hide();
           cmb_IdPlayer.Enabled = false;
           btDelete.Enabled = false;
           
        }

        private void cmb_IdPlayer_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBox1.Show();
            string teamName = cmb_Team.Text;
            int idPlayer = int.Parse(cmb_IdPlayer.Text);
            Player P = AddPlayerForm.C1.PlayerOfTeam(teamName, idPlayer);
            Lab_PlayerName.Text = P.Name;
            Lab_tshirtNumber.Text = P.TshirtNumer.ToString();
            btDelete.Enabled = true;
        }

        private void cmb_Team_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_IdPlayer.Enabled = true;
            string teamName = cmb_Team.Text;
            cmb_IdPlayer.DataSource = AddPlayerForm.C1.TeamPlayersIds(teamName);
        }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            bool ok=AddPlayerForm.C1.DeletePlayerOfTeam(cmb_Team.Text, int.Parse(cmb_IdPlayer.Text));
            if (ok)
            {
                MessageBox.Show("Player has been deleted....");
                //update the content of the combobox "Id Player"
                cmb_IdPlayer.DataSource = AddPlayerForm.C1.TeamPlayersIds(cmb_Team.Text);
            }
            else
            {
                MessageBox.Show("Player was not deleted...");
            }
        }
    }
}
