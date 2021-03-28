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
    public partial class TaskForm : Form
    {
        public TaskForm(Task task)
        {
            InitializeComponent();

            sel_item_list.Items.Clear();

            task_txt.Text = task.Info;

            sel_item_list.Items.Add(task);

            sel_item_list.Visible = false;
        }

        private void right_ans_btn_Click(object sender, EventArgs e)
        {
            Task t = (Task)sel_item_list.Items[0];

            ans_txt.Text = t.RightAnswer;
        }
    }
}
