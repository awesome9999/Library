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
    public partial class BorrowBook : Form
    {
        ConectDatabase cnd = new ConectDatabase();
        public BorrowBook()
        {
            InitializeComponent();
            cnd.GetBook(lb_Book);
            cnd.GetPeople(lb_People);
            cnd.GetUsers(lb_User);
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bt_borrow_Click(object sender, EventArgs e)
        {
            cnd.BorrowBook(cnd.GetPeopleID(lb_People.SelectedItem.ToString()), cnd.GetUserID(lb_User.SelectedItem.ToString()), cnd.GetBookID(lb_Book.SelectedItem.ToString()), dtp_from.Value, dtp_to.Value);
            this.Hide();
        }
    }
}
