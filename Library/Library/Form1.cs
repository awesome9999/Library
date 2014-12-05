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
    public partial class Form1 : Form
    {
        ConectDatabase connection = new ConectDatabase();
        public Form1()
        {
            InitializeComponent();
            connection.Conect();
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            Core core = new Core();
            connection.Login(tb_name, tb_pass, core, this);
        }
    }
}
