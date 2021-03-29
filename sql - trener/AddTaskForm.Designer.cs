
namespace sql___trener
{
    partial class AddTaskForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.save_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.task_name_txt = new System.Windows.Forms.TextBox();
            this.skill_comb = new System.Windows.Forms.ComboBox();
            this.diff_comb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inf_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.right_ans_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.back_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(333, 253);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(75, 23);
            this.save_btn.TabIndex = 0;
            this.save_btn.Text = "Сохранить";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Наименование задания";
            // 
            // task_name_txt
            // 
            this.task_name_txt.Location = new System.Drawing.Point(280, 24);
            this.task_name_txt.Name = "task_name_txt";
            this.task_name_txt.Size = new System.Drawing.Size(128, 20);
            this.task_name_txt.TabIndex = 2;
            // 
            // skill_comb
            // 
            this.skill_comb.FormattingEnabled = true;
            this.skill_comb.Location = new System.Drawing.Point(146, 24);
            this.skill_comb.Name = "skill_comb";
            this.skill_comb.Size = new System.Drawing.Size(128, 21);
            this.skill_comb.TabIndex = 3;
            // 
            // diff_comb
            // 
            this.diff_comb.FormattingEnabled = true;
            this.diff_comb.Location = new System.Drawing.Point(12, 24);
            this.diff_comb.Name = "diff_comb";
            this.diff_comb.Size = new System.Drawing.Size(128, 21);
            this.diff_comb.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Уровень знаний";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Сложность задания";
            // 
            // inf_txt
            // 
            this.inf_txt.Location = new System.Drawing.Point(12, 64);
            this.inf_txt.Multiline = true;
            this.inf_txt.Name = "inf_txt";
            this.inf_txt.Size = new System.Drawing.Size(190, 155);
            this.inf_txt.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Постановка задачи";
            // 
            // right_ans_txt
            // 
            this.right_ans_txt.Location = new System.Drawing.Point(208, 64);
            this.right_ans_txt.Multiline = true;
            this.right_ans_txt.Name = "right_ans_txt";
            this.right_ans_txt.Size = new System.Drawing.Size(200, 155);
            this.right_ans_txt.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(251, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Правильный ответ";
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(12, 253);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(75, 23);
            this.back_btn.TabIndex = 11;
            this.back_btn.Text = "Назад";
            this.back_btn.UseVisualStyleBackColor = true;
            // 
            // AddTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 288);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.right_ans_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.inf_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.diff_comb);
            this.Controls.Add(this.skill_comb);
            this.Controls.Add(this.task_name_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.save_btn);
            this.Name = "AddTaskForm";
            this.Text = "Добавить/Редактировать задание";
            this.Load += new System.EventHandler(this.AddTaskForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox task_name_txt;
        private System.Windows.Forms.ComboBox skill_comb;
        private System.Windows.Forms.ComboBox diff_comb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inf_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox right_ans_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button back_btn;
    }
}