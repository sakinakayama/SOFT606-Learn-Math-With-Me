using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace LearnMathWithMe
{
    class GameSetting
    {
        SqlConnection connection;

        public GameSetting()  //connect to SQL database
        {
            string strConnectionString = "Data Source=09207524-SAKI;Initial Catalog=LearnMathsWithMe;Integrated Security=True";
            connection = new SqlConnection(strConnectionString);

            connection.Open();
     
        }

        //Register new user
        public void saveUser(string fName, string lName, string uName, string password, int schoolYear, string teacherName)
        {
            string selectQuery = "SELECT UserName FROM Users WHERE UserName = '" + uName + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            if (dataTable.Rows.Count >= 1)
            {
                System.Windows.Forms.MessageBox.Show("User Name already exsits");
            }

            else
            {
                string query = "INSERT INTO Users VALUES('" + fName + "', '" + lName + "', '" + uName + "', '" + password + "', '" + schoolYear + "', '" + teacherName + "')";
                SqlCommand command = new SqlCommand(query, connection);

                command.ExecuteNonQuery();
                connection.Close();
                command = null;

                System.Windows.Forms.MessageBox.Show("Registered successfully!!");

                Register register = new Register();
                register.Hide();

                Login login = new Login();
                login.Show();
            }
     
        }

        //validate username and password to login
        public void validateUser(string uName, string password)  
        {
            
            string query = "SELECT * FROM Users WHERE UserName = '" + uName + "' AND Password = '" + password + "'";
            SqlDataAdapter sqlData = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            sqlData.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                User.username = dt.Rows[0]["UserName"].ToString();
                User.fName = dt.Rows[0]["FirstName"].ToString();  //set the value 
                User.schoolYear = int.Parse(dt.Rows[0]["SchoolYear"].ToString());  //set the value 
               
                System.Windows.Forms.MessageBox.Show("Login Success!!");

                MainMenu mainMenu = new MainMenu();
                mainMenu.Show();

                Login login = new Login();
                login.Hide();

            }

            else
            {
                System.Windows.Forms.MessageBox.Show("Incorrect username or password");
            }
            connection.Close();
            
        }

        //get game history data
        public DataTable getGameHistory(string uName) 
        {
            string query = "SELECT GameOperation, DatePlayed, Score FROM Score_Report WHERE UserName = '" + uName + "'";
            SqlDataAdapter sqlData = new SqlDataAdapter(query, connection);
            DataTable dtRecord = new DataTable();
            sqlData.Fill(dtRecord);

            return dtRecord;
        }

        //Save score report
        public void saveScoreReport(string op, DateTime date, int sc)
        {
            string query = "INSERT INTO Score_Report VALUES(@UserName, @GameOperation, @DatePlayed, @Score)";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.Add("@UserName", SqlDbType.VarChar).Value = User.username;
            command.Parameters.Add("@GameOperation", SqlDbType.VarChar).Value = op;
            command.Parameters.Add("@DatePlayed", SqlDbType.Date).Value = date;
            command.Parameters.Add("@Score", SqlDbType.Int).Value = sc;

            command.ExecuteNonQuery();

            connection.Close();
            command = null;

        }

        //Update User profile

        public void updateProfile(string fName, string lName, string password, int schoolYear, string teacherName)
        {
            string query = "UPDATE Users SET FirstName = '" + fName + "', LastName = '" + lName + "', Password = '" + password + "', SchoolYear = '" + schoolYear + "', TeacherName = '" + teacherName + "' WHERE UserName = '" + User.username + "'";
            SqlCommand command = new SqlCommand(query, connection);
            int noOfRows = command.ExecuteNonQuery();

            if(noOfRows != 0)
            {
                System.Windows.Forms.MessageBox.Show("Updated profile successfully!!");
            }

            connection.Close();
            command = null;

            
        }
    }


}
