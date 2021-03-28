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
    public partial class SingUp : Form
    {
        public SingUp()
        {
            InitializeComponent();

            List<Skill> sli = DBConnection.Entities.Skills.ToList();

            foreach (Skill s in sli)
            {
                skill_comb.Items.Add(s.SkillName);
            }
        }

        private void reg_btn_Click(object sender, EventArgs e)
        {
            User u = new User();
            List<User> uli = DBConnection.Entities.Users.ToList();
            List<Skill> sli = DBConnection.Entities.Skills.ToList();

            u.Login = log_txt.Text;
            u.Password = pass_txt.Text;
            foreach (Skill s in sli)
            {
                if (skill_comb.Text == s.SkillName)
                    u.Skills = s.SkillId;
            }
            u.BirthDate = birth_date.Value;
            u.Mail = mail_txt.Text;
            u.Points = 0;
            u.Role = "Пользователь";

            foreach (User us in uli)
            {
                if (u.Login == us.Login)
                {
                    MessageBox.Show("Такой логин уже сужествует!");

                    u.Login = null;

                    break;
                }
            }

            if(u.Login != null)
            {
                DBConnection.Entities.Users.Add(u);
                DBConnection.Entities.SaveChanges();

                this.Close();
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
