namespace Marathon_Skills_2016
{
    partial class Runner_Menu
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
            this.menu_runner = new System.Windows.Forms.Label();
            this.marathon_skills_2021 = new System.Windows.Forms.Label();
            this.btn_cansel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_rigistration_marathon = new System.Windows.Forms.Button();
            this.btn_results = new System.Windows.Forms.Button();
            this.table_btn = new System.Windows.Forms.TableLayoutPanel();
            this.btn_sponsor = new System.Windows.Forms.Button();
            this.btn_edit_profile = new System.Windows.Forms.Button();
            this.btn_contact = new System.Windows.Forms.Button();
            this.userControl11 = new Marathon_Skills_2016.UserControl1();
            this.panel1.SuspendLayout();
            this.table_btn.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu_runner
            // 
            this.menu_runner.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menu_runner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.menu_runner.Location = new System.Drawing.Point(0, 113);
            this.menu_runner.Name = "menu_runner";
            this.menu_runner.Size = new System.Drawing.Size(1433, 58);
            this.menu_runner.TabIndex = 66;
            this.menu_runner.Text = "Меню бегуна";
            this.menu_runner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btn_cansel.Size = new System.Drawing.Size(90, 40);
            this.btn_cansel.TabIndex = 1;
            this.btn_cansel.Text = "Назад";
            this.btn_cansel.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.btn_logout);
            this.panel1.Controls.Add(this.marathon_skills_2021);
            this.panel1.Controls.Add(this.btn_cansel);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1433, 79);
            this.panel1.TabIndex = 65;
            // 
            // btn_logout
            // 
            this.btn_logout.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_logout.Font = new System.Drawing.Font("Arial", 14F);
            this.btn_logout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_logout.Location = new System.Drawing.Point(1330, 20);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(90, 40);
            this.btn_logout.TabIndex = 69;
            this.btn_logout.Text = "logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            // 
            // btn_rigistration_marathon
            // 
            this.btn_rigistration_marathon.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_rigistration_marathon.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_rigistration_marathon.ForeColor = System.Drawing.Color.Black;
            this.btn_rigistration_marathon.Location = new System.Drawing.Point(3, 3);
            this.btn_rigistration_marathon.Name = "btn_rigistration_marathon";
            this.btn_rigistration_marathon.Size = new System.Drawing.Size(330, 100);
            this.btn_rigistration_marathon.TabIndex = 59;
            this.btn_rigistration_marathon.Text = "Регистрация на марафон";
            this.btn_rigistration_marathon.UseVisualStyleBackColor = true;
            // 
            // btn_results
            // 
            this.btn_results.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_results.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_results.ForeColor = System.Drawing.Color.Black;
            this.btn_results.Location = new System.Drawing.Point(354, 3);
            this.btn_results.Name = "btn_results";
            this.btn_results.Size = new System.Drawing.Size(330, 100);
            this.btn_results.TabIndex = 58;
            this.btn_results.Text = "Мои результаты";
            this.btn_results.UseVisualStyleBackColor = true;
            // 
            // table_btn
            // 
            this.table_btn.ColumnCount = 2;
            this.table_btn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_btn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_btn.Controls.Add(this.btn_sponsor, 1, 1);
            this.table_btn.Controls.Add(this.btn_edit_profile, 0, 1);
            this.table_btn.Controls.Add(this.btn_contact, 0, 2);
            this.table_btn.Controls.Add(this.btn_rigistration_marathon, 0, 0);
            this.table_btn.Controls.Add(this.btn_results, 1, 0);
            this.table_btn.Location = new System.Drawing.Point(359, 227);
            this.table_btn.Name = "table_btn";
            this.table_btn.RowCount = 3;
            this.table_btn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.table_btn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.table_btn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.table_btn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table_btn.Size = new System.Drawing.Size(702, 357);
            this.table_btn.TabIndex = 68;
            // 
            // btn_sponsor
            // 
            this.btn_sponsor.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_sponsor.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_sponsor.ForeColor = System.Drawing.Color.Black;
            this.btn_sponsor.Location = new System.Drawing.Point(354, 122);
            this.btn_sponsor.Name = "btn_sponsor";
            this.btn_sponsor.Size = new System.Drawing.Size(330, 100);
            this.btn_sponsor.TabIndex = 69;
            this.btn_sponsor.Text = "Мой спонсор";
            this.btn_sponsor.UseVisualStyleBackColor = true;
            // 
            // btn_edit_profile
            // 
            this.btn_edit_profile.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_edit_profile.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_edit_profile.ForeColor = System.Drawing.Color.Black;
            this.btn_edit_profile.Location = new System.Drawing.Point(3, 122);
            this.btn_edit_profile.Name = "btn_edit_profile";
            this.btn_edit_profile.Size = new System.Drawing.Size(330, 100);
            this.btn_edit_profile.TabIndex = 69;
            this.btn_edit_profile.Text = "Редактирование профиля";
            this.btn_edit_profile.UseVisualStyleBackColor = true;
            // 
            // btn_contact
            // 
            this.btn_contact.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_contact.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_contact.ForeColor = System.Drawing.Color.Black;
            this.btn_contact.Location = new System.Drawing.Point(3, 241);
            this.btn_contact.Name = "btn_contact";
            this.btn_contact.Size = new System.Drawing.Size(330, 100);
            this.btn_contact.TabIndex = 61;
            this.btn_contact.Text = "Контакты";
            this.btn_contact.UseVisualStyleBackColor = true;
            this.btn_contact.Click += new System.EventHandler(this.btn_contact_Click);
            // 
            // userControl11
            // 
            this.userControl11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.userControl11.Location = new System.Drawing.Point(0, 729);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(1432, 74);
            this.userControl11.TabIndex = 69;
            this.userControl11.Load += new System.EventHandler(this.userControl11_Load);
            // 
            // Runner_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1432, 803);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.menu_runner);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.table_btn);
            this.MaximumSize = new System.Drawing.Size(1450, 850);
            this.MinimumSize = new System.Drawing.Size(1450, 850);
            this.Name = "Runner_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marathon Skills 2021 - Runner menu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.table_btn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label menu_runner;
        private System.Windows.Forms.Label marathon_skills_2021;
        private System.Windows.Forms.Button btn_cansel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_rigistration_marathon;
        private System.Windows.Forms.Button btn_results;
        private System.Windows.Forms.TableLayoutPanel table_btn;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_sponsor;
        private System.Windows.Forms.Button btn_edit_profile;
        private System.Windows.Forms.Button btn_contact;
        private UserControl1 userControl11;
    }
}