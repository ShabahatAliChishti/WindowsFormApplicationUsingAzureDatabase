using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperVoters.Forms
{
    public partial class StartPage : Form
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            registration.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VoteResults voteResults = new VoteResults();
            voteResults.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CandidateForm candidate = new CandidateForm();
            candidate.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            VoterForm voter = new VoterForm();
            voter.Visible = true;
        }
    }
}
