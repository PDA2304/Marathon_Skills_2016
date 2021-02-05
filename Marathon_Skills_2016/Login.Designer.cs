namespace Marathon_Skills_2016
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.marathon_skills_2021 = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.information = new System.Windows.Forms.Label();
            this.screen_avtorization = new System.Windows.Forms.Label();
            this.btn_cansel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.date_count = new System.Windows.Forms.Timer(this.components);
            this.userControl11 = new Marathon_Skills_2016.UserControl1();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_back.Font = new System.Drawing.Font("Arial", 14F);
            this.btn_back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_back.Location = new System.Drawing.Point(716, 409);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(138, 40);
            this.btn_back.TabIndex = 90;
            this.btn_back.Text = "Cancel";
            this.btn_back.UseVisualStyleBackColor = true;
            // 
            // btn_login
            // 
            this.btn_login.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_login.Font = new System.Drawing.Font("Arial", 14F);
            this.btn_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_login.Location = new System.Drawing.Point(556, 409);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(138, 40);
            this.btn_login.TabIndex = 89;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // tb_password
            // 
            this.tb_password.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.tb_password.Location = new System.Drawing.Point(604, 338);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(307, 34);
            this.tb_password.TabIndex = 76;
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
            // tb_email
            // 
            this.tb_email.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.tb_email.Location = new System.Drawing.Point(604, 298);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(307, 34);
            this.tb_email.TabIndex = 73;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Arial", 14F);
            this.password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.password.Location = new System.Drawing.Point(437, 345);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(124, 27);
            this.password.TabIndex = 68;
            this.password.Text = "Password:";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Arial", 14F);
            this.email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.email.Location = new System.Drawing.Point(482, 305);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(79, 27);
            this.email.TabIndex = 67;
            this.email.Text = "Email:";
            // 
            // information
            // 
            this.information.AllowDrop = true;
            this.information.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.information.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.information.Location = new System.Drawing.Point(238, 182);
            this.information.Name = "information";
            this.information.Size = new System.Drawing.Size(923, 99);
            this.information.TabIndex = 66;
            this.information.Text = "Пожалуйста, авторизуйтесь в системе, используя ваш адрес электронной почты и паро" +
    "ль.\r\n";
            this.information.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // screen_avtorization
            // 
            this.screen_avtorization.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.screen_avtorization.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.screen_avtorization.Location = new System.Drawing.Point(0, 110);
            this.screen_avtorization.Name = "screen_avtorization";
            this.screen_avtorization.Size = new System.Drawing.Size(1433, 58);
            this.screen_avtorization.TabIndex = 65;
            this.screen_avtorization.Text = "Форма авторизации";
            this.screen_avtorization.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_cansel
            // 
            this.btn_cansel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cansel.Font = new System.Drawing.Font("Arial", 14F);
            this.btn_cansel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_cansel.Location = new System.Drawing.Point(20, 20);
            this.btn_cansel.Name = "btn_cansel";
            this.btn_cansel.Size = new System.Drawing.Size(100, 40);
            this.btn_cansel.TabIndex = 1;
            this.btn_cansel.Text = "Назад";
            this.btn_cansel.UseVisualStyleBackColor = true;
            this.btn_cansel.Click += new System.EventHandler(this.btn_cansel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.marathon_skills_2021);
            this.panel1.Controls.Add(this.btn_cansel);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1433, 79);
            this.panel1.TabIndex = 64;
            // 
            // date_count
            // 
            this.date_count.Interval = 1;
            // 
            // userControl11
            // 
            this.userControl11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userControl11.Location = new System.Drawing.Point(0, 726);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(1433, 74);
            this.userControl11.TabIndex = 91;
            this.userControl11.Load += new System.EventHandler(this.userControl11_Load);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1432, 803);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.password);
            this.Controls.Add(this.email);
            this.Controls.Add(this.information);
            this.Controls.Add(this.screen_avtorization);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(1450, 850);
            this.MinimumSize = new System.Drawing.Size(1450, 850);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marathon Skills 2021 - Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label marathon_skills_2021;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label information;
        private System.Windows.Forms.Label screen_avtorization;
        private System.Windows.Forms.Button btn_cansel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer date_count;
        private UserControl1 userControl11;
    }
}