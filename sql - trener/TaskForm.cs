using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace sql___trener
{
    public partial class TaskForm : Form
    {
        private bool answer = false;
        private SqlConnection con = null;
        private SqlCommandBuilder build = null;
        private SqlDataAdapter adap = null;
        private DataSet dataset = null;
        private DataSet dataset2 = null;
        private Task t;
        private User u;

        public TaskForm(Task task, User us)
        {
            InitializeComponent();

            u = us;
            this.t = task;
            task_txt.Text = t.Info;
        }

        private void right_ans_btn_Click(object sender, EventArgs e)
        {
            ans_txt.Text = t.RightAnswer;

            con = new SqlConnection(@"data source=DESKTOP-FOL4BLU;initial catalog=SQL - trener;integrated security=True;MultipleActiveResultSets=True;");

            con.Open();

            SqlCom(t.RightAnswer);
        }

        public DataSet SqlCom(string com)
        {
            adap = new SqlDataAdapter(com, con);

            build = new SqlCommandBuilder(adap);

            dataset2 = new DataSet();

            adap.Fill(dataset2);

            //result_datagrid.DataSource = dataset.Tables[0];
            answer = true;
            
            return dataset2;
        }

        public DataSet SqlCom()
        {
            try
            {
                adap = new SqlDataAdapter(ans_txt.Text, con);

                build = new SqlCommandBuilder(adap);

                dataset = new DataSet();

                adap.Fill(dataset);

                return dataset;
                //result_datagrid.DataSource = dataset.Tables[0];
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка");
                return dataset = null;
            }
        }

        private void ans_btn_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"data source=DESKTOP-FOL4BLU;initial catalog=SQL - trener;integrated security=True;MultipleActiveResultSets=True;");

            con.Open();

            if(right_check() == true)
            {
                List<User> uli = DBConnection.Entities.Users.ToList();
                CompleteTask complete = new CompleteTask();
                complete.Task = t.TaskId;
                complete.Date = DateTime.Today;
                foreach (User item in uli)
                {
                    if(item.Login == u.Login)
                    {
                        complete.User = item.Login;
                    }    
                }
                DBConnection.Entities.CompleteTasks.Add(complete);
                DBConnection.Entities.SaveChanges();
                result_datagrid.DataSource = SqlCom();
                MessageBox.Show("Задание выполнено!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Неправильный ответ!");
            }

        }

        private void refresh_brn_Click(object sender, EventArgs e)
        {
            ans_txt.Text = null;
            result_datagrid.Columns.Clear();
        }

        public bool right_check()
        {
            check_right_ans_datagrid.DataSource = SqlCom(t.RightAnswer);
            result_datagrid.DataSource = SqlCom();
            int x = 0;
            int y = 0;
            int i = -1;
            int z = 0;
            foreach (DataGridViewRow row in check_right_ans_datagrid.Rows)
            {
                i++;

                if ((check_right_ans_datagrid.Rows[i].Cells[i].Value) == (result_datagrid.Rows[z].Cells[i].Value))
                {
                    x++;
                }
                else
                {
                    y++;
                }
                if (z < result_datagrid.Rows.Count)
                {
                    z++;
                }
                if (z == result_datagrid.Rows.Count)
                {
                    z--; //subtract 1 from the total count because the datagrid is 0 index based.
                }
            }
            if (y == 0)
                return answer = true;
            else
                return answer = false;
        }
    }
}
