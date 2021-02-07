namespace Marathon_Skills_2016
{
    partial class Rigister_as_runner
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
            this.marathon_skills_2021 = new System.Windows.Forms.Label();
            this.btn_cansel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_old_runner = new System.Windows.Forms.Button();
            this.table_btn = new System.Windows.Forms.TableLayoutPanel();
            this.btn_new_runner = new System.Windows.Forms.Button();
            this.userControl11 = new Marathon_Skills_2016.UserControl1();
            this.panel1.SuspendLayout();
            this.table_btn.SuspendLayout();
            this.SuspendLayout();
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
            this.btn_cansel.Size = new System.Drawing.Size(103, 40);
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
            this.panel1.TabIndex = 69;
            // 
            // btn_login
            // 
            this.btn_login.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_login.Font = new System.Drawing.Font("Arial", 14F);
            this.btn_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_login.Location = new System.Drawing.Point(1288, 664);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(121, 56);
            this.btn_login.TabIndex = 69;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            // 
            // btn_old_runner
            // 
            this.btn_old_runner.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_old_runner.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_old_runner.ForeColor = System.Drawing.Color.Black;
            this.btn_old_runner.Location = new System.Drawing.Point(3, 3);
            this.btn_old_runner.Name = "btn_old_runner";
            this.btn_old_runner.Size = new System.Drawing.Size(450, 100);
            this.btn_old_runner.TabIndex = 59;
            this.btn_old_runner.Text = "Я участвовал ранее";
            this.btn_old_runner.UseVisualStyleBackColor = true;
            this.btn_old_runner.Click += new System.EventHandler(this.btn_old_runner_Click);
            // 
            // table_btn
            // 
            this.table_btn.ColumnCount = 1;
            this.table_btn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_btn.Controls.Add(this.btn_new_runner, 0, 1);
            this.table_btn.Controls.Add(this.btn_old_runner, 0, 0);
            this.table_btn.Location = new System.Drawing.Point(468, 240);
            this.table_btn.Name = "table_btn";
            this.table_btn.RowCount = 2;
            this.table_btn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.table_btn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.table_btn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table_btn.Size = new System.Drawing.Size(460, 260);
            this.table_btn.TabIndex = 72;
            // 
            // btn_new_runner
            // 
            this.btn_new_runner.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_new_runner.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_new_runner.ForeColor = System.Drawing.Color.Black;
            this.btn_new_runner.Location = new System.Drawing.Point(3, 133);
            this.btn_new_runner.Name = "btn_new_runner";
            this.btn_new_runner.Size = new System.Drawing.Size(450, 100);
            this.btn_new_runner.TabIndex = 69;
            this.btn_new_runner.Text = "Я новый участник";
            this.btn_new_runner.UseVisualStyleBackColor = true;
            this.btn_new_runner.Click += new System.EventHandler(this.btn_new_runner_Click);
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(0, 726);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(1433, 69);
            this.userControl11.TabIndex = 73;
            this.userControl11.Load += new System.EventHandler(this.userControl11_Load);
            // 
            // Rigister_as_runner
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1432, 803);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.table_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(1450, 850);
            this.MinimumSize = new System.Drawing.Size(1450, 850);
            this.Name = "Rigister_as_runner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marathon Skills 2021 - Register as a runner";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Rigister_as_runner_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.table_btn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label marathon_skills_2021;
        private System.Windows.Forms.Button btn_cansel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_old_runner;
        private System.Windows.Forms.TableLayoutPanel table_btn;
        private System.Windows.Forms.Button btn_new_runner;
        private UserControl1 userControl11;
    }
}