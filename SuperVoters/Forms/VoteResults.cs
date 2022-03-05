using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperVoters.Forms
{
    public partial class VoteResults : Form
    {
        public VoteResults()
        {
            InitializeComponent();
        }

        private void VoteResults_Load(object sender, EventArgs e)
        {
            // Fill election dd box
            string retValue = "";

            try
            {
                List<string> dates = GetElectionDates(ref retValue);
                if (dates.Count > 0)
                {
                    ElectionDates.Items.AddRange(dates.ToArray());
                    ElectionDates.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                Messages.Text = "An error occurred: " + retValue + ", " + ex.Message;
            }

            if (string.IsNullOrWhiteSpace(Messages.Text))
                Messages.Text = retValue;
        }

        private List<string> GetElectionDates(ref string retValue)
        {
            List<string> dates = new List<string>();
            
            try
            {
                var settings = new Properties.Settings();
                var connString = settings.SuperVotersConnectionString;
                SqlDataReader rdr = null;

                using (SqlConnection connection = new SqlConnection(connString))
                {
                    SqlCommand cmd = new SqlCommand("dbo.GetElectionDates", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    rdr = cmd.ExecuteReader();

                    if (rdr.HasRows)
                    {
                        while (rdr.Read())
                        {
                            dates.Add(rdr["ElectionDate"].ToString());
                        }

                        retValue = "Successfully retrieved election dates";
                    }
                    else
                        retValue = "No data returned for election dates";
                }
            }
            catch (Exception ex)
            {
                if (string.IsNullOrWhiteSpace(retValue))
                    retValue = "Error occurred while getting election dates: " + ex.Message;
            }

            return dates;
        }
    }
}
