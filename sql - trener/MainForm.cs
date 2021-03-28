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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            AutoForm af = new AutoForm();

            af.ShowDialog();

            InitializeComponent();

            this.Fill();
        }

        public void Fill()
        {
            tasks_list.Items.Clear();

            List<Task> li = DBConnection.Entities.Tasks.ToList();

            foreach (Task t in li)
            {
                tasks_list.Items.Add(t);
            }
        }

        public void Fill(List<Task> li)
        {
            tasks_list.Items.Clear();

            foreach (Task t in li)
            {
                tasks_list.Items.Add(t);
            }
        }

        private void tasks_list_DoubleClick(object sender, EventArgs e)
        {
            Task task = (Task)tasks_list.SelectedItem;

            if (task == null)
            {
                this.Fill();
            }

            else
            {
                TaskForm tf = new TaskForm(task);

                tf.ShowDialog();

                this.Fill();
            }
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            Search();
        }

        public void Search()
        {
            List<Task> li = DBConnection.Entities.Tasks.ToList();
            List<Task> l = new List<Task>();

            if (easy_radio.Checked)
            {
                foreach (Task t in li)
                {
                    if (t.Difficulty.DifName == "Легко")
                        l.Add(t);
                }

                this.Fill(l);
            }

            else if(normal_radio.Checked)
            {
                foreach (Task t in li)
                {
                    if (t.Difficulty.DifName == "Средне")
                        l.Add(t);
                }

                this.Fill(l);
            }

            else if(hard_radio.Checked)
            {
                foreach (Task t in li)
                {
                    if (t.Difficulty.DifName == "Сложно")
                        l.Add(t);
                }

                this.Fill(l);
            }

            if(begin_radio.Checked)
            {
                foreach (Task t in li)
                {
                    if (t.Skill.SkillName == "Начинающий")
                        l.Add(t);
                }

                this.Fill(l);
            }

            else if(adv_radio.Checked)
            {
                foreach (Task t in li)
                {
                    if (t.Skill.SkillName == "Продвинутый")
                        l.Add(t);
                }

                this.Fill(l);
            }

            else if(prof_radio.Checked)
            {
                foreach (Task t in li)
                {
                    if (t.Skill.SkillName == "Профессионал")
                        l.Add(t);
                }

                this.Fill(l);
            }
        }

        private void refresh_brn_Click(object sender, EventArgs e)
        {
            this.Fill();

            easy_radio.Checked = false;
            normal_radio.Checked = false;
            hard_radio.Checked = false;
            begin_radio.Checked = false;
            adv_radio.Checked = false;
            prof_radio.Checked = false;
        }
    }
}
