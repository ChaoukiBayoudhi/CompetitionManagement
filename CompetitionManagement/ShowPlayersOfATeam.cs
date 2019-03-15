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
    public partial class ShowPlayersOfATeam : Form
    {
        public ShowPlayersOfATeam()
        {
            InitializeComponent();
        }

        private void ShowPlayersOfATeam_Load(object sender, EventArgs e)
        {
            cmb_TeamName.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_TeamName.DataSource = AddPlayerForm.C1.TeamNames();
        }

        private void cmb_TeamName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string TeamName = cmb_TeamName.Text;
            dataGridView1.DataSource = AddPlayerForm.C1.TeamPlayers(TeamName);
        }
    }
}
