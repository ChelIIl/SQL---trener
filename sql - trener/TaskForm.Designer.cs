
namespace sql___trener
{
    partial class TaskForm
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
            this.ans_txt = new System.Windows.Forms.TextBox();
            this.res_txt = new System.Windows.Forms.TextBox();
            this.refresh_brn = new System.Windows.Forms.Button();
            this.right_ans_btn = new System.Windows.Forms.Button();
            this.ans_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.task_txt = new System.Windows.Forms.TextBox();
            this.sel_item_list = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ans_txt
            // 
            this.ans_txt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ans_txt.Location = new System.Drawing.Point(12, 165);
            this.ans_txt.Multiline = true;
            this.ans_txt.Name = "ans_txt";
            this.ans_txt.Size = new System.Drawing.Size(275, 209);
            this.ans_txt.TabIndex = 0;
            // 
            // res_txt
            // 
            this.res_txt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.res_txt.Location = new System.Drawing.Point(292, 165);
            this.res_txt.Multiline = true;
            this.res_txt.Name = "res_txt";
            this.res_txt.Size = new System.Drawing.Size(275, 209);
            this.res_txt.TabIndex = 1;
            // 
            // refresh_brn
            // 
            this.refresh_brn.Location = new System.Drawing.Point(12, 415);
            this.refresh_brn.Name = "refresh_brn";
            this.refresh_brn.Size = new System.Drawing.Size(75, 23);
            this.refresh_brn.TabIndex = 2;
            this.refresh_brn.Text = "Очистить";
            this.refresh_brn.UseVisualStyleBackColor = true;
            // 
            // right_ans_btn
            // 
            this.right_ans_btn.Location = new System.Drawing.Point(232, 409);
            this.right_ans_btn.Name = "right_ans_btn";
            this.right_ans_btn.Size = new System.Drawing.Size(111, 35);
            this.right_ans_btn.TabIndex = 3;
            this.right_ans_btn.Text = "Показать правильный ответ";
            this.right_ans_btn.UseVisualStyleBackColor = true;
            this.right_ans_btn.Click += new System.EventHandler(this.right_ans_btn_Click);
            // 
            // ans_btn
            // 
            this.ans_btn.Location = new System.Drawing.Point(493, 415);
            this.ans_btn.Name = "ans_btn";
            this.ans_btn.Size = new System.Drawing.Size(75, 23);
            this.ans_btn.TabIndex = 4;
            this.ans_btn.Text = "Ответ";
            this.ans_btn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ввод запроса:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(289, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Результаты запроса:";
            // 
            // task_txt
            // 
            this.task_txt.BackColor = System.Drawing.SystemColors.Menu;
            this.task_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.task_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.task_txt.Location = new System.Drawing.Point(12, 12);
            this.task_txt.Multiline = true;
            this.task_txt.Name = "task_txt";
            this.task_txt.ReadOnly = true;
            this.task_txt.Size = new System.Drawing.Size(556, 119);
            this.task_txt.TabIndex = 7;
            this.task_txt.Text = "TaskTxt";
            // 
            // sel_item_list
            // 
            this.sel_item_list.BackColor = System.Drawing.SystemColors.Menu;
            this.sel_item_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sel_item_list.FormattingEnabled = true;
            this.sel_item_list.Location = new System.Drawing.Point(12, 122);
            this.sel_item_list.Name = "sel_item_list";
            this.sel_item_list.Size = new System.Drawing.Size(115, 13);
            this.sel_item_list.TabIndex = 8;
            // 
            // TaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 450);
            this.Controls.Add(this.sel_item_list);
            this.Controls.Add(this.task_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ans_btn);
            this.Controls.Add(this.right_ans_btn);
            this.Controls.Add(this.refresh_brn);
            this.Controls.Add(this.res_txt);
            this.Controls.Add(this.ans_txt);
            this.Name = "TaskForm";
            this.Text = "TaskForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ans_txt;
        private System.Windows.Forms.TextBox res_txt;
        private System.Windows.Forms.Button refresh_brn;
        private System.Windows.Forms.Button right_ans_btn;
        private System.Windows.Forms.Button ans_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox task_txt;
        public System.Windows.Forms.ListBox sel_item_list;
    }
}