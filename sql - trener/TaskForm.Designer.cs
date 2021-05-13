
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
            this.refresh_brn = new System.Windows.Forms.Button();
            this.right_ans_btn = new System.Windows.Forms.Button();
            this.ans_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.task_txt = new System.Windows.Forms.TextBox();
            this.result_datagrid = new System.Windows.Forms.DataGridView();
            this.check_right_ans_datagrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.result_datagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.check_right_ans_datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ans_txt
            // 
            this.ans_txt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ans_txt.Location = new System.Drawing.Point(12, 110);
            this.ans_txt.Multiline = true;
            this.ans_txt.Name = "ans_txt";
            this.ans_txt.Size = new System.Drawing.Size(555, 105);
            this.ans_txt.TabIndex = 0;
            // 
            // refresh_brn
            // 
            this.refresh_brn.Location = new System.Drawing.Point(12, 415);
            this.refresh_brn.Name = "refresh_brn";
            this.refresh_brn.Size = new System.Drawing.Size(75, 23);
            this.refresh_brn.TabIndex = 2;
            this.refresh_brn.Text = "Очистить";
            this.refresh_brn.UseVisualStyleBackColor = true;
            this.refresh_brn.Click += new System.EventHandler(this.refresh_brn_Click);
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
            this.ans_btn.Click += new System.EventHandler(this.ans_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ввод запроса:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(8, 218);
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
            this.task_txt.Size = new System.Drawing.Size(556, 72);
            this.task_txt.TabIndex = 7;
            this.task_txt.Text = "TaskTxt";
            // 
            // result_datagrid
            // 
            this.result_datagrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.result_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.result_datagrid.Location = new System.Drawing.Point(12, 241);
            this.result_datagrid.Name = "result_datagrid";
            this.result_datagrid.Size = new System.Drawing.Size(555, 150);
            this.result_datagrid.TabIndex = 9;
            // 
            // check_right_ans_datagrid
            // 
            this.check_right_ans_datagrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.check_right_ans_datagrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.check_right_ans_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.check_right_ans_datagrid.Location = new System.Drawing.Point(328, 160);
            this.check_right_ans_datagrid.Name = "check_right_ans_datagrid";
            this.check_right_ans_datagrid.Size = new System.Drawing.Size(240, 150);
            this.check_right_ans_datagrid.TabIndex = 10;
            this.check_right_ans_datagrid.Visible = false;
            // 
            // TaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 450);
            this.Controls.Add(this.check_right_ans_datagrid);
            this.Controls.Add(this.result_datagrid);
            this.Controls.Add(this.task_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ans_btn);
            this.Controls.Add(this.right_ans_btn);
            this.Controls.Add(this.refresh_brn);
            this.Controls.Add(this.ans_txt);
            this.Name = "TaskForm";
            this.Text = "TaskForm";
            ((System.ComponentModel.ISupportInitialize)(this.result_datagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.check_right_ans_datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ans_txt;
        private System.Windows.Forms.Button refresh_brn;
        private System.Windows.Forms.Button right_ans_btn;
        private System.Windows.Forms.Button ans_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox task_txt;
        private System.Windows.Forms.DataGridView result_datagrid;
        private System.Windows.Forms.DataGridView check_right_ans_datagrid;
    }
}