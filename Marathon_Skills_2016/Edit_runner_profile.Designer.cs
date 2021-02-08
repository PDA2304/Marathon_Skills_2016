namespace Marathon_Skills_2016
{
    partial class Edit_runner_profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit_runner_profile));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tb_date = new System.Windows.Forms.DateTimePicker();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_registration = new System.Windows.Forms.Button();
            this.icon = new System.Windows.Forms.PictureBox();
            this.tb_country = new System.Windows.Forms.ComboBox();
            this.country = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.btn_fail = new System.Windows.Forms.Button();
            this.tb_path_img = new System.Windows.Forms.TextBox();
            this.img_text = new System.Windows.Forms.Label();
            this.img_runner = new System.Windows.Forms.PictureBox();
            this.cb_sex = new System.Windows.Forms.ComboBox();
            this.tb_last = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.marathon_skills_2021 = new System.Windows.Forms.Label();
            this.btn_cansel = new System.Windows.Forms.Button();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tx_password2 = new System.Windows.Forms.TextBox();
            this.last = new System.Windows.Forms.Label();
            this.sex = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.password2 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.sponsor_runner = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_email = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.userControl11 = new Marathon_Skills_2016.UserControl1();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_runner)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // tb_date
            // 
            this.tb_date.Font = new System.Drawing.Font("Arial", 13.8F);
            this.tb_date.Location = new System.Drawing.Point(306, 380);
            this.tb_date.Name = "tb_date";
            this.tb_date.Size = new System.Drawing.Size(250, 34);
            this.tb_date.TabIndex = 92;
            // 
            // btn_back
            // 
            this.btn_back.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_back.Font = new System.Drawing.Font("Arial", 14F);
            this.btn_back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_back.Location = new System.Drawing.Point(769, 649);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(138, 40);
            this.btn_back.TabIndex = 90;
            this.btn_back.Text = "Отмена";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.calnsel_Click);
            // 
            // btn_registration
            // 
            this.btn_registration.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_registration.Font = new System.Drawing.Font("Arial", 14F);
            this.btn_registration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_registration.Location = new System.Drawing.Point(544, 649);
            this.btn_registration.Name = "btn_registration";
            this.btn_registration.Size = new System.Drawing.Size(205, 40);
            this.btn_registration.TabIndex = 89;
            this.btn_registration.Text = "Сохранить";
            this.btn_registration.UseVisualStyleBackColor = true;
            this.btn_registration.Click += new System.EventHandler(this.btn_registration_Click);
            // 
            // icon
            // 
            this.icon.Image = ((System.Drawing.Image)(resources.GetObject("icon.Image")));
            this.icon.Location = new System.Drawing.Point(562, 373);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(37, 41);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon.TabIndex = 88;
            this.icon.TabStop = false;
            // 
            // tb_country
            // 
            this.tb_country.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_country.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.tb_country.Location = new System.Drawing.Point(306, 426);
            this.tb_country.Name = "tb_country";
            this.tb_country.Size = new System.Drawing.Size(293, 34);
            this.tb_country.TabIndex = 87;
            // 
            // country
            // 
            this.country.AutoSize = true;
            this.country.Font = new System.Drawing.Font("Arial", 14F);
            this.country.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.country.Location = new System.Drawing.Point(200, 433);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(100, 27);
            this.country.TabIndex = 86;
            this.country.Text = "Страна:";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Arial", 14F);
            this.date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.date.Location = new System.Drawing.Point(113, 380);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(187, 27);
            this.date.TabIndex = 85;
            this.date.Text = "Дата рождения:";
            // 
            // btn_fail
            // 
            this.btn_fail.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_fail.Font = new System.Drawing.Font("Arial", 14F);
            this.btn_fail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_fail.Location = new System.Drawing.Point(1172, 351);
            this.btn_fail.Name = "btn_fail";
            this.btn_fail.Size = new System.Drawing.Size(201, 40);
            this.btn_fail.TabIndex = 84;
            this.btn_fail.Text = "Просмотр...";
            this.btn_fail.UseVisualStyleBackColor = true;
            this.btn_fail.Click += new System.EventHandler(this.btn_fail_Click);
            // 
            // tb_path_img
            // 
            this.tb_path_img.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_path_img.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.tb_path_img.Location = new System.Drawing.Point(848, 355);
            this.tb_path_img.Name = "tb_path_img";
            this.tb_path_img.ReadOnly = true;
            this.tb_path_img.Size = new System.Drawing.Size(318, 34);
            this.tb_path_img.TabIndex = 83;
            // 
            // img_text
            // 
            this.img_text.AutoSize = true;
            this.img_text.Font = new System.Drawing.Font("Arial", 14F);
            this.img_text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.img_text.Location = new System.Drawing.Point(876, 325);
            this.img_text.Name = "img_text";
            this.img_text.Size = new System.Drawing.Size(140, 27);
            this.img_text.TabIndex = 82;
            this.img_text.Text = "Фото файл:";
            // 
            // img_runner
            // 
            this.img_runner.Image = global::Marathon_Skills_2016.Properties.Resources.unnamed;
            this.img_runner.Location = new System.Drawing.Point(1172, 130);
            this.img_runner.Name = "img_runner";
            this.img_runner.Size = new System.Drawing.Size(201, 209);
            this.img_runner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_runner.TabIndex = 81;
            this.img_runner.TabStop = false;
            // 
            // cb_sex
            // 
            this.cb_sex.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_sex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.cb_sex.FormattingEnabled = true;
            this.cb_sex.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.cb_sex.Location = new System.Drawing.Point(306, 334);
            this.cb_sex.Name = "cb_sex";
            this.cb_sex.Size = new System.Drawing.Size(250, 34);
            this.cb_sex.TabIndex = 80;
            // 
            // tb_last
            // 
            this.tb_last.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_last.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.tb_last.Location = new System.Drawing.Point(306, 240);
            this.tb_last.Name = "tb_last";
            this.tb_last.Size = new System.Drawing.Size(334, 34);
            this.tb_last.TabIndex = 79;
            this.tb_last.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_name_KeyPress);
            this.tb_last.Leave += new System.EventHandler(this.tb_name_Leave);
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.tb_name.Location = new System.Drawing.Point(306, 289);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(334, 34);
            this.tb_name.TabIndex = 78;
            this.tb_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_name_KeyPress);
            this.tb_name.Leave += new System.EventHandler(this.tb_name_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.marathon_skills_2021);
            this.panel1.Controls.Add(this.btn_cansel);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1433, 79);
            this.panel1.TabIndex = 67;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Font = new System.Drawing.Font("Arial", 14F);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.button1.Location = new System.Drawing.Point(1311, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // marathon_skills_2021
            // 
            this.marathon_skills_2021.AutoSize = true;
            this.marathon_skills_2021.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.marathon_skills_2021.ForeColor = System.Drawing.SystemColors.Control;
            this.marathon_skills_2021.Location = new System.Drawing.Point(200, 10);
            this.marathon_skills_2021.Name = "marathon_skills_2021";
            this.marathon_skills_2021.Size = new System.Drawing.Size(575, 56);
            this.marathon_skills_2021.TabIndex = 1;
            this.marathon_skills_2021.Text = "MARATHON SKILLS 2021";
            // 
            // btn_cansel
            // 
            this.btn_cansel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cansel.Font = new System.Drawing.Font("Arial", 14F);
            this.btn_cansel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_cansel.Location = new System.Drawing.Point(20, 20);
            this.btn_cansel.Name = "btn_cansel";
            this.btn_cansel.Size = new System.Drawing.Size(107, 40);
            this.btn_cansel.TabIndex = 1;
            this.btn_cansel.Text = "Назад";
            this.btn_cansel.UseVisualStyleBackColor = true;
            this.btn_cansel.Click += new System.EventHandler(this.calnsel_Click);
            // 
            // tb_password
            // 
            this.tb_password.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.tb_password.Location = new System.Drawing.Point(1039, 521);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(334, 34);
            this.tb_password.TabIndex = 77;
            // 
            // tx_password2
            // 
            this.tx_password2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tx_password2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.tx_password2.Location = new System.Drawing.Point(1039, 572);
            this.tx_password2.Name = "tx_password2";
            this.tx_password2.Size = new System.Drawing.Size(334, 34);
            this.tx_password2.TabIndex = 76;
            // 
            // last
            // 
            this.last.AutoSize = true;
            this.last.Font = new System.Drawing.Font("Arial", 14F);
            this.last.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.last.Location = new System.Drawing.Point(176, 243);
            this.last.Name = "last";
            this.last.Size = new System.Drawing.Size(120, 27);
            this.last.TabIndex = 74;
            this.last.Text = "Фамилия:";
            // 
            // sex
            // 
            this.sex.AutoSize = true;
            this.sex.Font = new System.Drawing.Font("Arial", 14F);
            this.sex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.sex.Location = new System.Drawing.Point(234, 341);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(62, 27);
            this.sex.TabIndex = 73;
            this.sex.Text = "Пол:";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Arial", 14F);
            this.name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.name.Location = new System.Drawing.Point(230, 289);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(66, 27);
            this.name.TabIndex = 72;
            this.name.Text = "Имя:";
            // 
            // password2
            // 
            this.password2.AutoSize = true;
            this.password2.Font = new System.Drawing.Font("Arial", 14F);
            this.password2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.password2.Location = new System.Drawing.Point(807, 579);
            this.password2.Name = "password2";
            this.password2.Size = new System.Drawing.Size(185, 27);
            this.password2.TabIndex = 71;
            this.password2.Text = "Повтор пароль:";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Arial", 14F);
            this.password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.password.Location = new System.Drawing.Point(927, 528);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(102, 27);
            this.password.TabIndex = 70;
            this.password.Text = "Пароль:";
            // 
            // sponsor_runner
            // 
            this.sponsor_runner.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sponsor_runner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.sponsor_runner.Location = new System.Drawing.Point(0, 114);
            this.sponsor_runner.Name = "sponsor_runner";
            this.sponsor_runner.Size = new System.Drawing.Size(1156, 58);
            this.sponsor_runner.TabIndex = 68;
            this.sponsor_runner.Text = "Редактирование профиля";
            this.sponsor_runner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(217, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 27);
            this.label1.TabIndex = 93;
            this.label1.Text = "Email:";
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Font = new System.Drawing.Font("Arial", 14F);
            this.lb_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lb_email.Location = new System.Drawing.Point(302, 201);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(81, 27);
            this.lb_email.TabIndex = 94;
            this.lb_email.Text = "что-то";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label3.Location = new System.Drawing.Point(848, 407);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(525, 58);
            this.label3.TabIndex = 95;
            this.label3.Text = "Смена пароля";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userControl11
            // 
            this.userControl11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.userControl11.Location = new System.Drawing.Point(0, 729);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(1432, 74);
            this.userControl11.TabIndex = 91;
            // 
            // Edit_runner_profile
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1432, 803);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_email);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.tb_date);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_registration);
            this.Controls.Add(this.icon);
            this.Controls.Add(this.tb_country);
            this.Controls.Add(this.country);
            this.Controls.Add(this.date);
            this.Controls.Add(this.btn_fail);
            this.Controls.Add(this.tb_path_img);
            this.Controls.Add(this.img_text);
            this.Controls.Add(this.img_runner);
            this.Controls.Add(this.cb_sex);
            this.Controls.Add(this.tb_last);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tx_password2);
            this.Controls.Add(this.last);
            this.Controls.Add(this.sex);
            this.Controls.Add(this.name);
            this.Controls.Add(this.password2);
            this.Controls.Add(this.password);
            this.Controls.Add(this.sponsor_runner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(1450, 850);
            this.MinimumSize = new System.Drawing.Size(1450, 850);
            this.Name = "Edit_runner_profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marathin Skills 2016 - Edit_runner_profile";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Edit_runner_profile_FormClosed);
            this.Load += new System.EventHandler(this.Edit_runner_profile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_runner)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControl1 userControl11;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DateTimePicker tb_date;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_registration;
        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.ComboBox tb_country;
        private System.Windows.Forms.Label country;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Button btn_fail;
        private System.Windows.Forms.TextBox tb_path_img;
        private System.Windows.Forms.Label img_text;
        private System.Windows.Forms.PictureBox img_runner;
        private System.Windows.Forms.ComboBox cb_sex;
        private System.Windows.Forms.TextBox tb_last;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label marathon_skills_2021;
        private System.Windows.Forms.Button btn_cansel;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tx_password2;
        private System.Windows.Forms.Label last;
        private System.Windows.Forms.Label sex;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label password2;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label sponsor_runner;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.Label label3;
    }
}