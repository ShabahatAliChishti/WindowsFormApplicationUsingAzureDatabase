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
    public partial class VoterForm : Form
    {
        List<Voter> list = new List<Voter>();
        public VoterForm()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (votedCheckBox.Checked)
            {
                votedCheckBox.Text = "Yes";
            }
            else
            {
                votedCheckBox.Text = "No";
            }
        }

        private void load_data()
        {
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("VName", typeof(string));
            table.Columns.Add("FName", typeof(string));
            table.Columns.Add("LName", typeof(string));
            table.Columns.Add("Email", typeof(string));
            table.Columns.Add("Voted", typeof(bool));

            for (int i = 0; i < list.Count; i++)
            {
                table.Rows.Add(list[i].voterId, list[i].voterName, list[i].firstName, list[i].lastName, list[i].email, list[i].isVoted);
            }

            dataGridView1.DataSource = table;
            dataGridView1.Rows[0].ReadOnly = true;
            dataGridView1.ClearSelection();

            votedCheckBox.Checked = true;
        }

        private void setData()
        {
            Voter v1 = new Voter();
            Voter v2 = new Voter();
            v1.voterId = 1;
            v1.voterName = "ABC";
            v1.firstName = "A";
            v1.middleName = "B";
            v1.lastName = "C";
            v1.email = "ABC@gmail.com";
            v1.isVoted = true;
            v1.address = "abc";
            v1.dateOfBirth = "1/3/2022";
            v1.phoneNumber = "1234567";

            v2.voterId = 2;
            v2.voterName = "XYZ";
            v2.firstName = "X";
            v2.middleName = "Y";
            v2.lastName = "Z";
            v2.email = "XYZ@gmail.com";
            v2.isVoted = false;
            v2.address = "xyz";
            v2.dateOfBirth = "2/3/2022";
            v2.phoneNumber = "1234567";

            list.Add(v1);
            list.Add(v2);
        }

        private void VoterForm_Load(object sender, EventArgs e)
        {
            setData();
            load_data();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                for (int i = 0; i < list.Count; i++)
                {
                    if (id == list[i].voterId)
                    {
                        idTextBox.Text = list[i].voterId.ToString();
                        nameTextBox.Text = list[i].voterName;
                        fnameTextBox.Text = list[i].firstName;
                        mnameTextBox.Text = list[i].middleName;
                        lnameTextBox.Text = list[i].lastName;
                        dobTextBox.Text = list[i].dateOfBirth;
                        emailTextBox.Text = list[i].email;
                        addressTextBox.Text = list[i].address;
                        votedCheckBox.Checked = list[i].isVoted;
                        numberTextBox.Text = list[i].phoneNumber;
                        break;
                    }
                }
            }
        }

        private void clearFields()
        {
        
            idTextBox.Text = string.Empty;
            nameTextBox.Text = string.Empty;
            fnameTextBox.Text = string.Empty;
            mnameTextBox.Text = string.Empty;
            lnameTextBox.Text = string.Empty;
            dobTextBox.Text = string.Empty;
            emailTextBox.Text = string.Empty;
            addressTextBox.Text = string.Empty;
            votedCheckBox.Checked = false;
            numberTextBox.Text = string.Empty;
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                for (int i = 0; i < list.Count; i++)
                {
                    if (id == list[i].voterId)
                    {
                        list.RemoveAt(i);
                        break;
                    }
                }
                load_data();
                clearFields();
            }
            else
            {
                MessageBox.Show("Kindly select any row from Grid");
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 && idTextBox.Text != "" && nameTextBox.Text != "" && fnameTextBox.Text != ""
                && lnameTextBox.Text != "" && dobTextBox.Text != "" && emailTextBox.Text != "" && addressTextBox.Text != "" && numberTextBox.Text != "")
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                for (int i = 0; i < list.Count; i++)
                {
                    if (id == list[i].voterId)
                    {          
                        list[i].voterName = nameTextBox.Text;
                        list[i].firstName = fnameTextBox.Text;

                        if(mnameTextBox.Text != "")
                            list[i].middleName = mnameTextBox.Text;
                        else
                            list[i].middleName = string.Empty;

                        list[i].lastName = lnameTextBox.Text;
                        list[i].dateOfBirth = dobTextBox.Text;
                        list[i].email = emailTextBox.Text;
                        list[i].address = addressTextBox.Text;
                        list[i].isVoted = votedCheckBox.Checked;
                        list[i].phoneNumber = numberTextBox.Text;
                        break;
                    }
                }
                load_data();
                clearFields();
            }
            else
            {
                MessageBox.Show("Kindly select any row from Grid");
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {

            if (idTextBox.Text != "" && nameTextBox.Text != "" && fnameTextBox.Text != "" && lnameTextBox.Text != "" && 
                dobTextBox.Text != "" && emailTextBox.Text != "" && addressTextBox.Text != "" && numberTextBox.Text != "")
            {
                if(!isPresent(Convert.ToInt32(idTextBox.Text)))
                {
                    Voter temp = new Voter();

                    temp.voterId = Convert.ToInt32(idTextBox.Text);
                    temp.voterName = nameTextBox.Text;
                    temp.firstName = fnameTextBox.Text;

                    if (mnameTextBox.Text != "")
                        temp.middleName = mnameTextBox.Text;
                    else
                        temp.middleName = string.Empty;

                    temp.lastName = lnameTextBox.Text;
                    temp.dateOfBirth = dobTextBox.Text;
                    temp.email = emailTextBox.Text;
                    temp.address = addressTextBox.Text;
                    temp.isVoted = votedCheckBox.Checked;
                    temp.phoneNumber = numberTextBox.Text;

                    list.Add(temp);
                    load_data();
                    clearFields();
                }
                else
                {
                    MessageBox.Show("This Voter ID is already Present");
                }
            }
            else 
            {
                MessageBox.Show("Data must be required in ( * ) Field's");
            }
        }

        private bool isPresent(int id)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (id == list[i].voterId)
                    return true;
            }
            return false;
        }
    }
}
