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
    public partial class CandidateForm : Form
    {
        List<Candidate> list = new List<Candidate>();

        public CandidateForm()
        {
            InitializeComponent();
        }

        private void CandidateForm_Load(object sender, EventArgs e)
        {
            setData();
            load_data();
        }

        private void addButton_Click(object sender, EventArgs e)
        {

            if (idTextBox.Text != "" && nameTextBox.Text != "" && partyTextBox.Text != "" && descriptionTextBox.Text != "" &&
                votersTextBox.Text != "" && addressTextBox.Text != "" && numberTextBox.Text != "")
            {
                if (!isPresent(Convert.ToInt32(idTextBox.Text)))
                {
                    Candidate temp = new Candidate();

                    temp.candidateId = Convert.ToInt32(idTextBox.Text);
                    temp.candidateName = nameTextBox.Text;
                    temp.party = partyTextBox.Text;
                    temp.description = descriptionTextBox.Text;
                    temp.candidateAddress = addressTextBox.Text;
                    temp.candidatePhone = numberTextBox.Text;
                    temp.numberOfVotes = Convert.ToInt32(votersTextBox.Text);

                    list.Add(temp);
                    load_data();
                    clearFields();
                }
                else
                {
                    MessageBox.Show("This Candidate ID is already Present");
                }
            }
            else
            {
                MessageBox.Show("Data must be required in ( * ) Field's");
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                for (int i = 0; i < list.Count; i++)
                {
                    if (id == list[i].candidateId)
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
            if (dataGridView1.SelectedRows.Count > 0 && idTextBox.Text != "" && nameTextBox.Text != "" && partyTextBox.Text != ""
                && descriptionTextBox.Text != "" && addressTextBox.Text != "" && numberTextBox.Text != "" && votersTextBox.Text != "")
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                for (int i = 0; i < list.Count; i++)
                {
                    if (id == list[i].candidateId)
                    {
                        list[i].candidateName = nameTextBox.Text;
                        list[i].party = partyTextBox.Text;
                        list[i].description = descriptionTextBox.Text;
                        list[i].candidateAddress = addressTextBox.Text;
                        list[i].candidatePhone = numberTextBox.Text;
                        list[i].numberOfVotes = Convert.ToInt32(votersTextBox.Text);
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
        private void clearFields()
        {
            idTextBox.Text = string.Empty;
            nameTextBox.Text = string.Empty;
            partyTextBox.Text = string.Empty;
            numberTextBox.Text = string.Empty;
            addressTextBox.Text = string.Empty;
            descriptionTextBox.Text = string.Empty;
            votersTextBox.Text = string.Empty;
        }

        private void load_data()
        {
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Party", typeof(string));
            table.Columns.Add("Number", typeof(string));
            table.Columns.Add("Voters", typeof(int));

            for (int i = 0; i < list.Count; i++)
            {
                table.Rows.Add(list[i].candidateId, list[i].candidateName, list[i].party, list[i].candidatePhone, list[i].numberOfVotes);
            }

            dataGridView1.DataSource = table;
            dataGridView1.Rows[0].ReadOnly = true;
            dataGridView1.ClearSelection();
        }

        private void setData()
        {
            Candidate v1 = new Candidate();
            Candidate v2 = new Candidate();
            v1.candidateId = 1;
            v1.candidateName = "ABC";
            v1.party = "Part A";
            v1.description = "Part A have Vision.";
            v1.candidateAddress = "abc";
            v1.candidatePhone = "1234567";
            v1.numberOfVotes = 300;

            v2.candidateId = 2;
            v2.candidateName = "XYZ";
            v2.party = "Part X";
            v2.description = "Part X have Dream.";
            v2.candidateAddress = "xyz";
            v2.candidatePhone = "1234567";
            v2.numberOfVotes = 600;

            list.Add(v1);
            list.Add(v2);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                for (int i = 0; i < list.Count; i++)
                {
                    if (id == list[i].candidateId)
                    {
                        idTextBox.Text = list[i].candidateId.ToString();
                        nameTextBox.Text = list[i].candidateName;
                        partyTextBox.Text = list[i].party;
                        descriptionTextBox.Text = list[i].description;
                        addressTextBox.Text = list[i].candidateAddress;
                        numberTextBox.Text = list[i].candidatePhone;
                        votersTextBox.Text = list[i].numberOfVotes.ToString();
                        break;
                    }
                }
            }
        }
        private bool isPresent(int id)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (id == list[i].candidateId)
                    return true;
            }
            return false;
        }

        private void uploadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog Dialog = new OpenFileDialog();
            Dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                string ImgLocation = Dialog.FileName;
                pictureBox1.Image = new Bitmap(Dialog.FileName);
            }
        }
    }
}
