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
    public partial class AddTaskForm : Form
    {
        List<Skill> sli = DBConnection.Entities.Skills.ToList();
        List<Difficulty> dli = DBConnection.Entities.Difficulties.ToList();

        public AddTaskForm()
        {
            InitializeComponent();

            foreach (Difficulty d in dli)
            {
                diff_comb.Items.Add(d.DifName);
            }

            foreach (Skill s in sli)
            {
                skill_comb.Items.Add(s.SkillName);
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            AddTask();
        }

        public void AddTask()
        {
            Task task = new Task();

            foreach (Skill s in sli)
            {
                if (s.SkillName == skill_comb.Text)
                {
                    task.Skill.SkillId = s.SkillId;
                    break;
                }
            }
            foreach (Difficulty d in dli)
            {
                if (d.DifName == diff_comb.Text)
                {
                    task.Difficulty.DifId = d.DifId;
                }
            }

            task.TaskName = task_name_txt.Text;
            task.Info = inf_txt.Text;
            task.RightAnswer = right_ans_txt.Text;

            DBConnection.Entities.Tasks.Add(task);
            DBConnection.Entities.SaveChanges();
        }

        private void AddTaskForm_Load(object sender, EventArgs e)
        {
        }
    }
}
