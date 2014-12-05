using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Library
{
    class ConectDatabase
    {
        private List<string> UserName = new List<string>();
        private List<string> Password = new List<string>();
        SqlConnection cnn = new SqlConnection("Server=Jirka-PC\\SQLEXPRESS; Database=Knihovna; User Id=george; Password=141997;");
        SqlCommand cmd;
        public void Conect()
        {
            SqlCommand UserCommand = new SqlCommand("SELECT Username, Password FROM [User]",cnn);
            cnn.Open();
            SqlDataReader reader = UserCommand.ExecuteReader();
            while (reader.Read())
            {
                UserName.Add(reader["Username"].ToString());
                Password.Add(reader["Password"].ToString());
            }
          //  MessageBox.Show ("Conected");
            cnn.Close();
        }

        public bool Login(TextBox tb, TextBox pass, Form core, Form login)
        {
            bool name = false;
            bool password = false;
            for (int i = 0; i < UserName.Count; i++)
            {
                if (UserName[i] == tb.Text)
                {
                    name = true;
                    break;
                }
            }

            if (name==true)
            {            
            for (int j = 0; j < Password.Count; j++)
            {
                if (Password[j]==pass.Text)
                {
                    password = true;
                    break;
                }
            }
            }
            if (name == true && password == true)
            {
                //MessageBox.Show("Logged");
                core.Show();
                login.Visible = false;
                core.BringToFront();

                return true;              
            }
            else
            {
                //MessageBox.Show("NELogged");
                return false;
            } 
        }

        public void AddBook(string bookName, string author, int publisherID, int categoryID, string isbn, int numberOfCopy)
        {
            string dotaz = "INSERT INTO Book (Name, Author, PublisherID, CategoryID, ISBN, NumberOfCopy) VALUES (@bookName, @author, @publisherID, @categoryID, @isbn,@numberOfCopy)";
            using (SqlCommand cmd = new SqlCommand(dotaz, cnn))
            {
                cnn.Open();
                cmd.Parameters.AddWithValue("@bookName", bookName);
                cmd.Parameters.AddWithValue("@author", author);
                cmd.Parameters.AddWithValue("@publisherID", publisherID);
                cmd.Parameters.AddWithValue("@categoryID", categoryID);
                cmd.Parameters.AddWithValue("@isbn", isbn);
                cmd.Parameters.AddWithValue("@numberOfCopy", numberOfCopy);
                //MessageBox.Show(cmd.ExecuteNonQuery().ToString());
                cnn.Close();
            }
        }

        public void AddUser(string username, string pass, int roleID)
        {
            string dotaz = "INSERT INTO [User] (Username, Password, RoleID) VALUES (@username, @pass, @roleID)";
            using (SqlCommand cmd = new SqlCommand(dotaz, cnn))
            {
                cnn.Open();
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@pass", pass);
                cmd.Parameters.AddWithValue("@roleID", roleID);
              //  MessageBox.Show(cmd.ExecuteNonQuery().ToString());
                cnn.Close();
            }
        }

        public void DeleteUser(string name)
        {
            string quest = "DELETE [User] WHERE Username=@name";
            using (SqlCommand cmd = new SqlCommand(quest, cnn)) 
            {
                cnn.Open();
                cmd.Parameters.AddWithValue("@name", name);
               // MessageBox.Show(cmd.ExecuteNonQuery().ToString());
                cnn.Close();
            }
        }

        public void GetUsers(ListBox users)
        {
            SqlCommand UserCommand = new SqlCommand("SELECT Username FROM [User]", cnn);
            cnn.Open();
            SqlDataReader reader = UserCommand.ExecuteReader();
            while (reader.Read())
            {
                users.Items.Add(reader["Username"].ToString());     
            }
            //  MessageBox.Show ("Conected");
            cnn.Close();
        }

        public void DeleteBook(string BookName)
        {
            string quest = "DELETE Book WHERE Name=@bookName";
            using (SqlCommand cmd = new SqlCommand(quest, cnn))
            {
                cnn.Open();
                cmd.Parameters.AddWithValue("@bookName", BookName);
                //MessageBox.Show(cmd.ExecuteNonQuery().ToString());
                cnn.Close();
            }
        }

        public void GetBook(ListBox Books)
        {
            SqlCommand UserCommand = new SqlCommand("SELECT Name FROM Book", cnn);
            cnn.Open();
            SqlDataReader reader = UserCommand.ExecuteReader();
            while (reader.Read())
            {
                Books.Items.Add(reader["Name"].ToString());
            }
            cnn.Close();
        }

        public void BorrowBook(int PeopleID, int UserID, int BookID, DateTime From, DateTime To)
        {
            string quest = "INSERT INTO Borrow (PeopleID, UserID, BookID, [From], [To]) VALUES (@PeopleID, @UserID, @BookID, @From, @To)";
            using(cmd = new SqlCommand(quest,cnn))
            {
                cnn.Open();
                cmd.Parameters.AddWithValue("@PeopleID", PeopleID);
                cmd.Parameters.AddWithValue("@UserID", UserID);
                cmd.Parameters.AddWithValue("@BookID", BookID);
                cmd.Parameters.AddWithValue("@From", From);
                cmd.Parameters.AddWithValue("@To", To);
                MessageBox.Show(cmd.ExecuteNonQuery().ToString());
                cnn.Close();
            }
        }

        public int GetUserID(string username)
        {
            int userID = 0;
            cmd =  new SqlCommand("SELECT ID FROM [User] WHERE Username = @username", cnn);
            cmd.Parameters.AddWithValue("@username", username);
            cnn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                userID = (int)reader["ID"];
            }
            cnn.Close();
            //MessageBox.Show(userID.ToString());
            return userID;
        }

        public int GetPeopleID(string name)
        {
            int userID = 0;
            cmd = new SqlCommand("SELECT ID FROM People WHERE FirstName = @username", cnn);
            cmd.Parameters.AddWithValue("@username", name);
            cnn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                userID = (int)reader["ID"];
            }
            cnn.Close();
            //MessageBox.Show(userID.ToString());
            return userID;
        }

        public int GetBookID(string book)
        {
            int userID = 0;
            cmd = new SqlCommand("SELECT ID FROM Book WHERE Name = @username", cnn);
            cmd.Parameters.AddWithValue("@username", book);
            cnn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                userID = (int)reader["ID"];
            }
            cnn.Close();
            //MessageBox.Show(userID.ToString());
            return userID;
        }

        public void GetPeople(ListBox people)
        {
            cmd = new SqlCommand("SELECT FirstName FROM People", cnn);
            cnn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                people.Items.Add(reader["FirstName"].ToString());
            }
            cnn.Close();
        }
    }
}
