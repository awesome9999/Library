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
    public partial class AddBook : Form
    {
        ConectDatabase conn = new ConectDatabase();
        public AddBook()
        {
            InitializeComponent();
            
        }

        private void bt_ok_Click(object sender, EventArgs e)
        {
            if (tb_BookName.Text!=""&&tb_BookAuthor.Text!=""&&cb_BookCategory.SelectedItem!=null&&cb_BookPublisher.SelectedItem!=null&&tb_isbn.Text!=""&&num_BookCopy.Value!=0)
            {
                conn.AddBook(tb_BookName.Text, tb_BookAuthor.Text, cb_BookPublisher.SelectedIndex, cb_BookCategory.SelectedIndex, tb_isbn.Text, (int)num_BookCopy.Value);
                this.Hide();
            }
           
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
