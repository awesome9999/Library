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
    public partial class AddUser : Form
    {
        ConectDatabase conn = new ConectDatabase();
        public AddUser()
        {
            InitializeComponent();
        }

        private void bt_ok_Click(object sender, EventArgs e)
        {
            if (tb_username.Text!="" && tb_pass.Text!="" && tb_pass.Text==tb_pass2.Text && cb_role.SelectedItem!=null)
            {
                conn.AddUser(tb_username.Text, tb_pass.Text, cb_role.SelectedIndex);
                this.Hide();
            }
            
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
