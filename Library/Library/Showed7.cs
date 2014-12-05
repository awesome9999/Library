using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Library
{
    class Showed7
    {
        SqlConnection cnn = new SqlConnection("Server=Jirka-PC\\SQLEXPRESS; Database=Knihovna; User Id=george; Password=141997;");
        SqlCommand cmd;
        public void GetBorrowed(ListBox books)
        {
            string quest = "SELECT * FROM Borrow";
            cmd = new SqlCommand(quest, cnn);
            cnn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                books.Items.Add(reader["BookID"]);
            }
            cnn.Close();
        }

        public int GetUserID(string bookID)
        {
            int userID = 0;
            string quest = "SELECT UserID FROM Borrow WHERE BookID=@bookID";
            
            cmd = new SqlCommand(quest, cnn);
            cnn.Open();
            cmd.Parameters.AddWithValue("@bookID", bookID);
            SqlDataReader reader = cmd.ExecuteReader();
            
            while (reader.Read())
            {
                userID=(int)reader["UserID"];
            }
            cnn.Close();

            return userID;
        }

        public int GetPeopleID(string bookID)
        {
            int userID = 0;
            string quest = "SELECT PeopleID FROM Borrow WHERE BookID=@bookID";
            
            cmd = new SqlCommand(quest, cnn);
            cnn.Open();
            cmd.Parameters.AddWithValue("@bookID", bookID);
            SqlDataReader reader = cmd.ExecuteReader();
            
            while (reader.Read())
            {
                userID = (int)reader["PeopleID"];
            }
            cnn.Close();

            return userID;
        }

        public DateTime GetFrom(string bookID)
        {
            DateTime userID = new DateTime(2011,6,20);
            string quest = "SELECT [From] FROM Borrow WHERE BookID=@bookID";
            
            cmd = new SqlCommand(quest, cnn);
            cnn.Open();
            cmd.Parameters.AddWithValue("@bookID", bookID);
            SqlDataReader reader = cmd.ExecuteReader();
            
            while (reader.Read())
            {
                userID = (DateTime)reader["From"];
            }
            cnn.Close();

            return userID;
        }
        public DateTime GetTo(string bookID)
        {
            DateTime userID = new DateTime(2011, 6, 20); ;
            string quest = "SELECT [To] FROM Borrow WHERE BookID=@bookID";
            
            cmd = new SqlCommand(quest, cnn);
            cnn.Open();
            cmd.Parameters.AddWithValue("@bookID", bookID);
            SqlDataReader reader = cmd.ExecuteReader();
            
            while (reader.Read())
            {
                userID = (DateTime)reader["To"];
            }
            cnn.Close();

            return userID;

        }

    }
}
