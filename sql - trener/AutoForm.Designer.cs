
namespace sql___trener
{
    partial class AutoForm
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
            this.enter_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.login_txt = new System.Windows.Forms.TextBox();
            this.pass_txt = new System.Windows.Forms.TextBox();
            this.create_acc_lbl = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // enter_btn
            // 
            this.enter_btn.Location = new System.Drawing.Point(178, 59);
            this.enter_btn.Name = "enter_btn";
            this.enter_btn.Size = new System.Drawing.Size(75, 23);
            this.enter_btn.TabIndex = 1;
            this.enter_btn.Text = "Войти";
            this.enter_btn.UseVisualStyleBackColor = true;
            this.enter_btn.Click += new System.EventHandler(this.enter_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Логин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пароль:";
            // 
            // login_txt
            // 
            this.login_txt.Location = new System.Drawing.Point(96, 6);
            this.login_txt.Name = "login_txt";
            this.login_txt.Size = new System.Drawing.Size(157, 20);
            this.login_txt.TabIndex = 4;
            // 
            // pass_txt
            // 
            this.pass_txt.Location = new System.Drawing.Point(96, 32);
            this.pass_txt.Name = "pass_txt";
            this.pass_txt.Size = new System.Drawing.Size(157, 20);
            this.pass_txt.TabIndex = 5;
            // 
            // create_acc_lbl
            // 
            this.create_acc_lbl.AutoSize = true;
            this.create_acc_lbl.LinkColor = System.Drawing.Color.Blue;
            this.create_acc_lbl.Location = new System.Drawing.Point(12, 64);
            this.create_acc_lbl.Name = "create_acc_lbl";
            this.create_acc_lbl.Size = new System.Drawing.Size(72, 13);
            this.create_acc_lbl.TabIndex = 6;
            this.create_acc_lbl.TabStop = true;
            this.create_acc_lbl.Text = "Регистрация";
            this.create_acc_lbl.Click += new System.EventHandler(this.create_acc_lbl_Click);
            // 
            // AutoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 94);
            this.Controls.Add(this.create_acc_lbl);
            this.Controls.Add(this.pass_txt);
            this.Controls.Add(this.login_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.enter_btn);
            this.Name = "AutoForm";
            this.Text = "Вход в учетную запись";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button enter_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox login_txt;
        private System.Windows.Forms.TextBox pass_txt;
        private System.Windows.Forms.LinkLabel create_acc_lbl;
    }
}