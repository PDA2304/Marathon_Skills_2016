namespace Marathon_Skills_2016
{
    partial class Coordinator_Menu
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
            this.podrobnaja_information = new System.Windows.Forms.Label();
            this.marathon_skills_2021 = new System.Windows.Forms.Label();
            this.btn_cansel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_runners = new System.Windows.Forms.Button();
            this.btn_sponsor = new System.Windows.Forms.Button();
            this.table_btn = new System.Windows.Forms.TableLayoutPanel();
            this.userControl11 = new Marathon_Skills_2016.UserControl1();
            this.panel1.SuspendLayout();
            this.table_btn.SuspendLayout();
            this.SuspendLayout();
            // 
            // podrobnaja_information
            // 
            this.podrobnaja_information.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.podrobnaja_information.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.podrobnaja_information.Location = new System.Drawing.Point(0, 113);
            this.podrobnaja_information.Name = "podrobnaja_information";
            this.podrobnaja_information.Size = new System.Drawing.Size(1433, 58);
            this.podrobnaja_information.TabIndex = 62;
            this.podrobnaja_information.Text = "Подробная информация";
            this.podrobnaja_information.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.panel1.Controls.Add(this.marathon_skills_2021);
            this.panel1.Controls.Add(this.btn_cansel);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1433, 79);
            this.panel1.TabIndex = 61;
            // 
            // btn_runners
            // 
            this.btn_runners.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_runners.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_runners.ForeColor = System.Drawing.Color.Black;
            this.btn_runners.Location = new System.Drawing.Point(3, 3);
            this.btn_runners.Name = "btn_runners";
            this.btn_runners.Size = new System.Drawing.Size(330, 100);
            this.btn_runners.TabIndex = 59;
            this.btn_runners.Text = "Бегуны";
            this.btn_runners.UseVisualStyleBackColor = true;
            // 
            // btn_sponsor
            // 
            this.btn_sponsor.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_sponsor.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_sponsor.ForeColor = System.Drawing.Color.Black;
            this.btn_sponsor.Location = new System.Drawing.Point(354, 3);
            this.btn_sponsor.Name = "btn_sponsor";
            this.btn_sponsor.Size = new System.Drawing.Size(330, 100);
            this.btn_sponsor.TabIndex = 58;
            this.btn_sponsor.Text = "Спонсоры";
            this.btn_sponsor.UseVisualStyleBackColor = true;
            // 
            // table_btn
            // 
            this.table_btn.ColumnCount = 2;
            this.table_btn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_btn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_btn.Controls.Add(this.btn_runners, 0, 0);
            this.table_btn.Controls.Add(this.btn_sponsor, 1, 0);
            this.table_btn.Location = new System.Drawing.Point(359, 227);
            this.table_btn.Name = "table_btn";
            this.table_btn.RowCount = 1;
            this.table_btn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.table_btn.Size = new System.Drawing.Size(702, 107);
            this.table_btn.TabIndex = 64;
            // 
            // userControl11
            // 
            this.userControl11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.userControl11.Location = new System.Drawing.Point(0, 729);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(1432, 74);
            this.userControl11.TabIndex = 65;
            this.userControl11.Load += new System.EventHandler(this.userControl11_Load);
            // 
            // Coordinator_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1432, 803);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.podrobnaja_information);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.table_btn);
            this.MaximumSize = new System.Drawing.Size(1450, 850);
            this.MinimumSize = new System.Drawing.Size(1450, 850);
            this.Name = "Coordinator_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marathon Skills 2021 - Coordinator menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Coordinator_Menu_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.table_btn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label podrobnaja_information;
        private System.Windows.Forms.Label marathon_skills_2021;
        private System.Windows.Forms.Button btn_cansel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_runners;
        private System.Windows.Forms.Button btn_sponsor;
        private System.Windows.Forms.TableLayoutPanel table_btn;
        private UserControl1 userControl11;
    }
}