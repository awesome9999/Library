using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Core : Form
    {
        public Core()
        {
            InitializeComponent();
        }
        ConectDatabase cnd = new ConectDatabase();
        private void Core_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void bt_addBook_Click(object sender, EventArgs e)
        {
            AddBook addBook = new AddBook();
            addBook.Show();
        }

        private void bt_addUser_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();
            addUser.Show();
        }

        private void bt_deleteUser_Click(object sender, EventArgs e)
        {
            DeleteUser dltU = new DeleteUser();
            dltU.Show();
        }

        private void bt_deleteBook_Click(object sender, EventArgs e)
        {
            DeleteBook dltB = new DeleteBook();
            dltB.Show();
        }

        private void bt_borrow_Click(object sender, EventArgs e)
        {
            BorrowBook bb = new BorrowBook();
            bb.Show();
        }

        private void bt_showBorrowed_Click(object sender, EventArgs e)
        {
            Borrowed b = new Borrowed();
            b.Show();
        }
    }
}
