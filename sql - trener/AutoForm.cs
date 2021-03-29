using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sql___trener
{
    public partial class AutoForm : Form
    {
		public AutoForm()
        {
            InitializeComponent();
        }

        private void enter_btn_Click(object sender, EventArgs e)
        {
            Auth();
        }

        public void Auth()
        {
            List<User> usli = DBConnection.Entities.Users.ToList();

            foreach (User user in usli)
            {
                if (login_txt.Text == user.Login || pass_txt.Text == user.Password)
                {
                    goto Finish;
                }
            }

            MessageBox.Show("Неверный логин или пароль!");

        Finish:
            this.Close();
        }

        private void create_acc_lbl_Click(object sender, EventArgs e)
        {
            SingUp su = new SingUp();

            su.Show();
        }
    }
}
