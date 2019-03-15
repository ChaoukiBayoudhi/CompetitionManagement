using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompetitionManagement
{
    public partial class AddPlayerForm : Form
    {
        internal static Competition C1 = new Competition();
        private string TeamName;
        private DataGridView datgridView1;
        private bool stateValidation = false;

        public AddPlayerForm()
        {
            InitializeComponent();
            datgridView1 = null;
        }

        public AddPlayerForm(string text, DataGridView dataGridView1)
        {
            InitializeComponent();
            TeamName = text;
            this.datgridView1 = dataGridView1;
        }

        private void bt_Add_Click(object sender, EventArgs e)
        {
            if (stateValidation)
            {
                Player P = new Player();
                P.Id = int.Parse(txt_Id.Text);
                P.Name = txt_Name.Text;
                P.BirthDay = dtp_BirthDay.Value;
                // P.TshirtNumer = int.Parse(cmb_TshirtNumber.Text);
                string teamName = cmb_Team.Text;
                bool res = C1.AddPlayerToTeam(P, teamName);


                if (res)
                {
                    MessageBox.Show("Player has been added");
                    if (datgridView1 != null)
                    {
                        try
                        {
                            datgridView1.DataSource = null;
                            datgridView1.DataSource = C1.TeamPlayers(teamName);
                        }
                        catch(Exception ex)//if the teamName is unavailable it'll be an exception
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                else
                    MessageBox.Show("Player is already exist");
            }
            else
                errorProvider1.SetError(bt_Add, "You should correct errors");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmb_Team.DataSource = C1.TeamNames();
            //lab_Team.Hide();
            //cmb_Team.Hide();
        }

        private void bt_Close_Click(object sender, EventArgs e)
        {
            this.Close();
            //datgridView.DataSource = null;
            //datgridView.DataSource = C1.TeamPlayers(TeamName);

        }

        private void txt_Id_TextChanged(object sender, EventArgs e)
        {
            
            if (txt_Id.Text.Trim() == string.Empty)
            {
                errorProvider1.SetError(txt_Id, "You should Enter an Id");
                stateValidation = false;
            }
            else
            {

                int result;
                if (!int.TryParse(txt_Id.Text, out result))
                {
                    // number is not a numeric
                    
                    errorProvider1.SetError(txt_Id, "You should Enter a numeric for the Id");
                    stateValidation = false;
                }
                else
                {
                    // is a number
                   
                    errorProvider1.SetError(txt_Id, "");
                    stateValidation = true;
                }
            }
        }

        private void txt_Id_Validating(object sender, CancelEventArgs e)
        {

            
        }

       

       
        private void bt_Add_MouseHover(object sender, EventArgs e)
        {
            if (!stateValidation)
            {
                errorProvider1.SetError(bt_Add, "You have to correct errors above");
            }
            else
            {
                errorProvider1.SetError(bt_Add, "");
            }
        }

        private void bt_Add_MouseMove(object sender, MouseEventArgs e)
        {
            //mouseHover or MouseMove choose one of these tow events

            //if (!stateValidation)
            //{
            //    errorProvider1.SetError(bt_Add, "You should correct errors above");
            //}
            //else
            //{
            //    errorProvider1.SetError(bt_Add, "");
            //}
        }
    }
}
