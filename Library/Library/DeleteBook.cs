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
    public partial class DeleteBook : Form
    {
        ConectDatabase cnd = new ConectDatabase();
        public DeleteBook()
        {
            InitializeComponent();
            cnd.GetBook(lb_BookName);
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            cnd.DeleteBook(lb_BookName.SelectedItem.ToString());
            lb_BookName.Items.RemoveAt(lb_BookName.SelectedIndex);
        }

        private void bt_ok_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
