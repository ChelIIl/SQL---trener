
namespace sql___trener
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tasks_list = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.easy_radio = new System.Windows.Forms.RadioButton();
            this.normal_radio = new System.Windows.Forms.RadioButton();
            this.hard_radio = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.prof_radio = new System.Windows.Forms.RadioButton();
            this.adv_radio = new System.Windows.Forms.RadioButton();
            this.begin_radio = new System.Windows.Forms.RadioButton();
            this.search_btn = new System.Windows.Forms.Button();
            this.refresh_brn = new System.Windows.Forms.Button();
            this.skill_panel = new System.Windows.Forms.Panel();
            this.dif_panel = new System.Windows.Forms.Panel();
            this.add_btn = new System.Windows.Forms.Button();
            this.skill_panel.SuspendLayout();
            this.dif_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tasks_list
            // 
            this.tasks_list.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tasks_list.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tasks_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tasks_list.FormattingEnabled = true;
            this.tasks_list.ItemHeight = 16;
            this.tasks_list.Location = new System.Drawing.Point(0, 0);
            this.tasks_list.Name = "tasks_list";
            this.tasks_list.Size = new System.Drawing.Size(247, 370);
            this.tasks_list.TabIndex = 0;
            this.tasks_list.DoubleClick += new System.EventHandler(this.tasks_list_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(253, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Сложность";
            // 
            // easy_radio
            // 
            this.easy_radio.AutoSize = true;
            this.easy_radio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.easy_radio.Location = new System.Drawing.Point(3, 3);
            this.easy_radio.Name = "easy_radio";
            this.easy_radio.Size = new System.Drawing.Size(75, 22);
            this.easy_radio.TabIndex = 2;
            this.easy_radio.TabStop = true;
            this.easy_radio.Text = "Легкая";
            this.easy_radio.UseVisualStyleBackColor = true;
            // 
            // normal_radio
            // 
            this.normal_radio.AutoSize = true;
            this.normal_radio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.normal_radio.Location = new System.Drawing.Point(3, 31);
            this.normal_radio.Name = "normal_radio";
            this.normal_radio.Size = new System.Drawing.Size(86, 22);
            this.normal_radio.TabIndex = 3;
            this.normal_radio.TabStop = true;
            this.normal_radio.Text = "Средняя";
            this.normal_radio.UseVisualStyleBackColor = true;
            // 
            // hard_radio
            // 
            this.hard_radio.AutoSize = true;
            this.hard_radio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hard_radio.Location = new System.Drawing.Point(3, 59);
            this.hard_radio.Name = "hard_radio";
            this.hard_radio.Size = new System.Drawing.Size(88, 22);
            this.hard_radio.TabIndex = 4;
            this.hard_radio.TabStop = true;
            this.hard_radio.Text = "Высокая";
            this.hard_radio.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(253, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Уровень умений";
            // 
            // prof_radio
            // 
            this.prof_radio.AutoSize = true;
            this.prof_radio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prof_radio.Location = new System.Drawing.Point(3, 59);
            this.prof_radio.Name = "prof_radio";
            this.prof_radio.Size = new System.Drawing.Size(133, 22);
            this.prof_radio.TabIndex = 8;
            this.prof_radio.TabStop = true;
            this.prof_radio.Text = "Профессионал";
            this.prof_radio.UseVisualStyleBackColor = true;
            // 
            // adv_radio
            // 
            this.adv_radio.AutoSize = true;
            this.adv_radio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adv_radio.Location = new System.Drawing.Point(3, 31);
            this.adv_radio.Name = "adv_radio";
            this.adv_radio.Size = new System.Drawing.Size(120, 22);
            this.adv_radio.TabIndex = 7;
            this.adv_radio.TabStop = true;
            this.adv_radio.Text = "Продвинутый";
            this.adv_radio.UseVisualStyleBackColor = true;
            // 
            // begin_radio
            // 
            this.begin_radio.AutoSize = true;
            this.begin_radio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.begin_radio.Location = new System.Drawing.Point(3, 3);
            this.begin_radio.Name = "begin_radio";
            this.begin_radio.Size = new System.Drawing.Size(115, 22);
            this.begin_radio.TabIndex = 6;
            this.begin_radio.TabStop = true;
            this.begin_radio.Text = "Начинающий";
            this.begin_radio.UseVisualStyleBackColor = true;
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(345, 338);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(75, 23);
            this.search_btn.TabIndex = 9;
            this.search_btn.Text = "Найти";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // refresh_brn
            // 
            this.refresh_brn.Location = new System.Drawing.Point(253, 338);
            this.refresh_brn.Name = "refresh_brn";
            this.refresh_brn.Size = new System.Drawing.Size(75, 23);
            this.refresh_brn.TabIndex = 10;
            this.refresh_brn.Text = "Сбросить";
            this.refresh_brn.UseVisualStyleBackColor = true;
            this.refresh_brn.Click += new System.EventHandler(this.refresh_brn_Click);
            // 
            // skill_panel
            // 
            this.skill_panel.Controls.Add(this.begin_radio);
            this.skill_panel.Controls.Add(this.adv_radio);
            this.skill_panel.Controls.Add(this.prof_radio);
            this.skill_panel.Location = new System.Drawing.Point(253, 144);
            this.skill_panel.Name = "skill_panel";
            this.skill_panel.Size = new System.Drawing.Size(170, 97);
            this.skill_panel.TabIndex = 11;
            // 
            // dif_panel
            // 
            this.dif_panel.Controls.Add(this.easy_radio);
            this.dif_panel.Controls.Add(this.normal_radio);
            this.dif_panel.Controls.Add(this.hard_radio);
            this.dif_panel.Location = new System.Drawing.Point(253, 36);
            this.dif_panel.Name = "dif_panel";
            this.dif_panel.Size = new System.Drawing.Size(170, 85);
            this.dif_panel.TabIndex = 12;
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(345, 297);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(75, 35);
            this.add_btn.TabIndex = 13;
            this.add_btn.Text = "Добавить задание";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 373);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.dif_panel);
            this.Controls.Add(this.skill_panel);
            this.Controls.Add(this.refresh_brn);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tasks_list);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.skill_panel.ResumeLayout(false);
            this.skill_panel.PerformLayout();
            this.dif_panel.ResumeLayout(false);
            this.dif_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox tasks_list;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton easy_radio;
        private System.Windows.Forms.RadioButton normal_radio;
        private System.Windows.Forms.RadioButton hard_radio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton prof_radio;
        private System.Windows.Forms.RadioButton adv_radio;
        private System.Windows.Forms.RadioButton begin_radio;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Button refresh_brn;
        private System.Windows.Forms.Panel skill_panel;
        private System.Windows.Forms.Panel dif_panel;
        private System.Windows.Forms.Button add_btn;
    }
}

