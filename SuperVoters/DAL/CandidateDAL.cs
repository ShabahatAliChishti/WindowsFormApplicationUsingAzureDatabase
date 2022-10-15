using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperVoters.DAL
{
    internal class CandidateDAL
    {
        static dynamic settings = new Properties.Settings();
        static dynamic connString = settings.SuperVotersConnectionString;

        public bool Insert(Candidate candidate)
        {
            //Creating Boolean Variable and set its default value to false
            bool isSuccess = false;

            //Sql Connection for DAtabase
            SqlConnection conn = new SqlConnection(connString);

            try
            {
                //SQL Query to insert candidate into database
                string query = "Insert into dbo.Candidate (Name, Party, Description, Phone, Address, myImage)";
                query += " VALUES (@Name, @Party, @Description, @Phone, @Address, @myImage)";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@Name", candidate.candidateName);
                    command.Parameters.AddWithValue("@Party", candidate.party);

                    command.Parameters.AddWithValue("@Description", candidate.description);
                    command.Parameters.AddWithValue("@Phone", candidate.candidatePhone);
                    command.Parameters.AddWithValue("@Address", candidate.candidateAddress);


                    command.Parameters.AddWithValue("@myImage", candidate.imageData);

                    //Opening the Database connection
                    conn.Open();

                    int rows = command.ExecuteNonQuery();

                    //If the query is executed successfully then the value of rows will be greater than 0 else it will be less than 0
                    if (rows > 0)
                    {
                        //Query Executed Successfully
                        isSuccess = true;
                    }
                    else
                    {
                        //FAiled to Execute Query
                        isSuccess = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }
     
        public DataTable Select()
        {
            //Create Sql Connection to connect Databaes

            //DAtaTable to hold the data from database
            DataTable dt = new DataTable();

            SqlConnection connection = null;

            try
            {
               
                //Writing the Query to Select all the candidate from database
                String sql = "SELECT * FROM [dbo].[Candidate] order by CandidateId";

                //Creating SQL Command to Execute Query
                using (connection = new SqlConnection(connString))
                {
                    SqlCommand cmd = new SqlCommand(sql, connection);

                    //SQL Data Adapter to hold the value from database temporarily
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                    //Open DAtabase Connection
                    connection.Open();


                    adapter.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }
        public bool Delete(Candidate c)
        {
            //Create Boolean Variable and Set its default value to false
            bool isSuccess = false;

            //SQL Connection for DB connection
            SqlConnection conn = new SqlConnection(connString);

            try
            {
                //Write Query Candidate from DAtabase
                String sql = "DELETE FROM [dbo].[Candidate] WHERE candidateId=@candidateId";

                //Sql Command to Pass the Value
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Passing the values using cmd
                cmd.Parameters.AddWithValue("@candidateId", c.candidateId);

                //Open Database Connection
                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                //If the query is executed successfullly then the value of rows will be greated than 0 else it will be less than 0
                if (rows > 0)
                {
                    //Query Executed Successfully
                    isSuccess = true;
                }
                else
                {
                    //Failed to Execute Query
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }
    }
}
