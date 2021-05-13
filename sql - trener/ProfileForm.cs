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
    public partial class ProfileForm : Form
    {
        public ProfileForm()
        {
            InitializeComponent();
        }

        public ProfileForm(User user)
        {
            InitializeComponent();

            mail_lbl.Text = user.Mail;
            user_login_lbl.Text = user.Login;
            points_lbl.Text = user.Points.ToString();
            skill_lbl.Text = user.Skill.SkillName;
            date_lbl.Text = user.BirthDate.ToString("d");
        }
    }
}
