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
    public partial class DeleteUser : Form
    {
        ConectDatabase cnd = new ConectDatabase();
        public DeleteUser()
        {
            InitializeComponent();
            cnd.GetUsers(lb_Users);
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            cnd.DeleteUser(lb_Users.SelectedItem.ToString());
            lb_Users.Items.RemoveAt(lb_Users.SelectedIndex);
        }

        private void bt_ok_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
