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
    public partial class Borrowed : Form
    {
        Showed7 showed = new Showed7();
        public Borrowed()
        {
            InitializeComponent();
            showed.GetBorrowed(lb_books);
        }

        private void bt_ok_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void lb_books_SelectedIndexChanged(object sender, EventArgs e)
        {
            label4.Text = showed.GetFrom(lb_books.SelectedItem.ToString()).ToString();
            label5.Text = showed.GetTo(lb_books.SelectedItem.ToString()).ToString();
            lbl_PeopleID.Text = showed.GetPeopleID(lb_books.SelectedItem.ToString()).ToString();
            lbl_userID.Text = showed.GetUserID(lb_books.SelectedItem.ToString()).ToString();
        }
    }
}
