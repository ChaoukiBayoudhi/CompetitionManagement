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
    public partial class AddTeamForm : Form
    {
        private ToolStripMenuItem playerMangementToolStripMenuItem;
        private ToolStripMenuItem addPlayerToolStripMenuItem;
        private bool stateValidation1;
        private bool stateValidation2;
        private bool stateValidation3;

        public AddTeamForm()
        {
            InitializeComponent();
        }

        public AddTeamForm(ToolStripMenuItem playerMangementToolStripMenuItem, ToolStripMenuItem addPlayerToolStripMenuItem)
        {
            this.playerMangementToolStripMenuItem = playerMangementToolStripMenuItem;
            this.addPlayerToolStripMenuItem = addPlayerToolStripMenuItem;
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        static bool IsValid(string value)
        {
            return Regex.IsMatch(value, @"^[a-zA-Z0-9]*$");
        }
        private void txt_Name_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!VerificationEnter.IsAlphaNumeric(txt_Name.Text))
                {
                    throw new Exception("Team name must be alphaNumeric");
                }
                else
                    if (VerificationEnter.EmptyOrOnlySpace(txt_Name.Text))
                {
                    throw new Exception("You should enter a team Name");
                }
                else
                {
                    errorProvider1.SetError(txt_Name, "");
                    stateValidation2 = true;
                }
            }
            catch(Exception ex)
            {
                errorProvider1.SetError(txt_Name, ex.Message);
                stateValidation2 = false;
            }
        }

        private void bt_Add_Click(object sender, EventArgs e)
        {
            if (stateValidation1 && stateValidation2 && stateValidation3)
            {
                Team T = new Team();
                T.Code = int.Parse(txt_Code.Text);
                T.Name = txt_Name.Text;
                T.CreationDate = dtp_CreationDate.Value;
                T.NbrOfSubsucribers = int.Parse(txt_NbrSubscribers.Text);
                if (AddPlayerForm.C1.Teams.Contains(T))
                    MessageBox.Show("This team is aleady exist");
                else
                {
                    AddPlayerForm.C1.Teams.Add(T);
                    MessageBox.Show("Team has been added");
                    dataGridView1.DataSource = AddPlayerForm.C1.TeamPlayers(T.Name);
                    bt_AddPlayer.Enabled = true;
                    playerMangementToolStripMenuItem.Enabled = true;
                    addPlayerToolStripMenuItem.Enabled = true;


                }
                errorProvider1.SetError(bt_Add, "");
            }
            else
                errorProvider1.SetError(bt_Add, "You have to correct errors above");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddPlayerForm f1 = new AddPlayerForm(txt_Name.Text,dataGridView1);
            f1.Show();
        }

        private void AddTeamForm_Load(object sender, EventArgs e)
        {
            bt_AddPlayer.Enabled = false;
        }

        private void bt_Close_Click(object sender, EventArgs e)
        {
           DialogResult res=MessageBox.Show("You want to Exit?","Exit Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
                this.Close();
        }

        private void txt_Code_TextChanged(object sender, EventArgs e)
        {
            
            if (txt_Code.Text.Trim() == string.Empty)
            {
                errorProvider1.SetError(txt_Code, "You should Enter an Code");
                stateValidation1 = false;
            }
            else
            {

                int result;
                if (!int.TryParse(txt_Code.Text, out result))
                {
                    // number is not a numeric

                    errorProvider1.SetError(txt_Code, "You should Enter a numeric for the Code");
                    stateValidation1 = false;
                }
                else
                {
                    // is a number

                    errorProvider1.SetError(txt_Code, "");
                    stateValidation1 = true;
                }
            }
        }

        private void bt_Add_MouseHover(object sender, EventArgs e)
        {
            if (!stateValidation1)
            {
                errorProvider1.SetError(bt_Add, "You have to correct errors above");
            }
            else
            {
                errorProvider1.SetError(bt_Add, "");
            }
        }

        private void txt_NbrSubscribers_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!VerificationEnter.IsNumeric(txt_NbrSubscribers.Text))
                {
                    throw new Exception("Number of subscribers must be Numeric");
                }
               
                else
                {
                    errorProvider1.SetError(txt_NbrSubscribers, "");
                    stateValidation3 = true;
                }
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txt_NbrSubscribers, ex.Message);
                stateValidation3 = false;
            }
        }
    }
}
