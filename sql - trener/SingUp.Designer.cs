
namespace sql___trener
{
    partial class SingUp
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
            this.label1 = new System.Windows.Forms.Label();
            this.back_btn = new System.Windows.Forms.Button();
            this.reg_btn = new System.Windows.Forms.Button();
            this.log_txt = new System.Windows.Forms.TextBox();
            this.pass_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.skill_comb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.birth_date = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.mail_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(54, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин";
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(12, 145);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(75, 23);
            this.back_btn.TabIndex = 1;
            this.back_btn.Text = "Назад";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // reg_btn
            // 
            this.reg_btn.Location = new System.Drawing.Point(205, 145);
            this.reg_btn.Name = "reg_btn";
            this.reg_btn.Size = new System.Drawing.Size(75, 23);
            this.reg_btn.TabIndex = 2;
            this.reg_btn.Text = "Создать";
            this.reg_btn.UseVisualStyleBackColor = true;
            this.reg_btn.Click += new System.EventHandler(this.reg_btn_Click);
            // 
            // log_txt
            // 
            this.log_txt.Location = new System.Drawing.Point(12, 30);
            this.log_txt.Name = "log_txt";
            this.log_txt.Size = new System.Drawing.Size(131, 20);
            this.log_txt.TabIndex = 3;
            // 
            // pass_txt
            // 
            this.pass_txt.Location = new System.Drawing.Point(149, 30);
            this.pass_txt.Name = "pass_txt";
            this.pass_txt.Size = new System.Drawing.Size(131, 20);
            this.pass_txt.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(181, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пароль";
            // 
            // skill_comb
            // 
            this.skill_comb.FormattingEnabled = true;
            this.skill_comb.Location = new System.Drawing.Point(12, 73);
            this.skill_comb.Name = "skill_comb";
            this.skill_comb.Size = new System.Drawing.Size(131, 21);
            this.skill_comb.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Уровень навыков";
            // 
            // birth_date
            // 
            this.birth_date.Location = new System.Drawing.Point(149, 74);
            this.birth_date.Name = "birth_date";
            this.birth_date.Size = new System.Drawing.Size(131, 20);
            this.birth_date.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(164, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Дата рождения";
            // 
            // mail_txt
            // 
            this.mail_txt.Location = new System.Drawing.Point(79, 119);
            this.mail_txt.Name = "mail_txt";
            this.mail_txt.Size = new System.Drawing.Size(131, 20);
            this.mail_txt.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(121, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Почта";
            // 
            // SingUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 184);
            this.Controls.Add(this.mail_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.birth_date);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.skill_comb);
            this.Controls.Add(this.pass_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.log_txt);
            this.Controls.Add(this.reg_btn);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.label1);
            this.Name = "SingUp";
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button reg_btn;
        private System.Windows.Forms.TextBox log_txt;
        private System.Windows.Forms.TextBox pass_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox skill_comb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker birth_date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox mail_txt;
        private System.Windows.Forms.Label label5;
    }
}