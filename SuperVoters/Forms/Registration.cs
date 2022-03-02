using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperVoters
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Registration_Load(object sender, EventArgs e)
        {
            RoleList.SelectedIndex = -1;
            RoleList.Text = "Please select a role";
            RoleList.Items.Add("Voter");
            RoleList.Items.Add("Candidate");
            RoleList.Items.Add("Admin");
        }

        private void SaveRegistration_Click(object sender, EventArgs e)
        {

        }
    }
}
