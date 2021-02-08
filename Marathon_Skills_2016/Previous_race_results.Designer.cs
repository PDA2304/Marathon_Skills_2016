namespace Marathon_Skills_2016
{
    partial class Previous_race_results
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.marathon_skills_2021 = new System.Windows.Forms.Label();
            this.btn_cansel = new System.Windows.Forms.Button();
            this.marafon = new System.Windows.Forms.ComboBox();
            this.distantion = new System.Windows.Forms.ComboBox();
            this.sponsor_runner = new System.Windows.Forms.Label();
            this.results = new System.Windows.Forms.DataGridView();
            this.information = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.filter = new System.Windows.Forms.Button();
            this.count_start = new System.Windows.Forms.Label();
            this.count_finish = new System.Windows.Forms.Label();
            this.userControl11 = new Marathon_Skills_2016.UserControl1();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.results)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.marathon_skills_2021);
            this.panel1.Controls.Add(this.btn_cansel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1432, 79);
            this.panel1.TabIndex = 65;
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
            this.btn_cansel.Size = new System.Drawing.Size(100, 40);
            this.btn_cansel.TabIndex = 1;
            this.btn_cansel.Text = "Назад";
            this.btn_cansel.UseVisualStyleBackColor = true;
            this.btn_cansel.Click += new System.EventHandler(this.btn_cansel_Click);
            // 
            // marafon
            // 
            this.marafon.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.marafon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.marafon.FormattingEnabled = true;
            this.marafon.Location = new System.Drawing.Point(381, 183);
            this.marafon.Name = "marafon";
            this.marafon.Size = new System.Drawing.Size(300, 34);
            this.marafon.TabIndex = 66;
            // 
            // distantion
            // 
            this.distantion.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.distantion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.distantion.FormattingEnabled = true;
            this.distantion.Location = new System.Drawing.Point(908, 179);
            this.distantion.Name = "distantion";
            this.distantion.Size = new System.Drawing.Size(300, 34);
            this.distantion.TabIndex = 68;
            // 
            // sponsor_runner
            // 
            this.sponsor_runner.Dock = System.Windows.Forms.DockStyle.Top;
            this.sponsor_runner.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sponsor_runner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.sponsor_runner.Location = new System.Drawing.Point(0, 79);
            this.sponsor_runner.Name = "sponsor_runner";
            this.sponsor_runner.Size = new System.Drawing.Size(1432, 88);
            this.sponsor_runner.TabIndex = 70;
            this.sponsor_runner.Text = "Результат предыдущих гонок";
            this.sponsor_runner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // results
            // 
            this.results.AllowUserToAddRows = false;
            this.results.AllowUserToDeleteRows = false;
            this.results.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.results.Location = new System.Drawing.Point(210, 326);
            this.results.Name = "results";
            this.results.ReadOnly = true;
            this.results.RowHeadersWidth = 51;
            this.results.RowTemplate.Height = 24;
            this.results.Size = new System.Drawing.Size(1000, 400);
            this.results.TabIndex = 71;
            // 
            // information
            // 
            this.information.AllowDrop = true;
            this.information.AutoSize = true;
            this.information.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.information.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.information.Location = new System.Drawing.Point(264, 186);
            this.information.Name = "information";
            this.information.Size = new System.Drawing.Size(111, 27);
            this.information.TabIndex = 72;
            this.information.Text = "Марфон:";
            this.information.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(765, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 27);
            this.label1.TabIndex = 73;
            this.label1.Text = "Дистанция:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // filter
            // 
            this.filter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.filter.Font = new System.Drawing.Font("Arial", 14F);
            this.filter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.filter.Location = new System.Drawing.Point(836, 230);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(372, 40);
            this.filter.TabIndex = 2;
            this.filter.Text = "Поиск";
            this.filter.UseVisualStyleBackColor = true;
            this.filter.Click += new System.EventHandler(this.filter_Click);
            // 
            // count_start
            // 
            this.count_start.AllowDrop = true;
            this.count_start.AutoSize = true;
            this.count_start.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.count_start.ForeColor = System.Drawing.Color.Black;
            this.count_start.Location = new System.Drawing.Point(237, 290);
            this.count_start.Name = "count_start";
            this.count_start.Size = new System.Drawing.Size(217, 33);
            this.count_start.TabIndex = 76;
            this.count_start.Text = "Всего бегунов:";
            this.count_start.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // count_finish
            // 
            this.count_finish.AllowDrop = true;
            this.count_finish.AutoSize = true;
            this.count_finish.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.count_finish.ForeColor = System.Drawing.Color.Black;
            this.count_finish.Location = new System.Drawing.Point(798, 290);
            this.count_finish.Name = "count_finish";
            this.count_finish.Size = new System.Drawing.Size(432, 33);
            this.count_finish.TabIndex = 77;
            this.count_finish.Text = "всего бегунов финишировало:";
            this.count_finish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userControl11
            // 
            this.userControl11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.userControl11.Location = new System.Drawing.Point(0, 729);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(1432, 74);
            this.userControl11.TabIndex = 0;
            this.userControl11.Load += new System.EventHandler(this.userControl11_Load);
            // 
            // Previous_race_results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1432, 803);
            this.Controls.Add(this.count_finish);
            this.Controls.Add(this.count_start);
            this.Controls.Add(this.filter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.information);
            this.Controls.Add(this.results);
            this.Controls.Add(this.sponsor_runner);
            this.Controls.Add(this.distantion);
            this.Controls.Add(this.marafon);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.userControl11);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(1450, 850);
            this.MinimumSize = new System.Drawing.Size(1450, 850);
            this.Name = "Previous_race_results";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marathon Skills 2021 - Previous_race_results";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Previous_race_results_FormClosed);
            this.Load += new System.EventHandler(this.Previous_race_results_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.results)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControl1 userControl11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label marathon_skills_2021;
        private System.Windows.Forms.Button btn_cansel;
        private System.Windows.Forms.ComboBox marafon;
        private System.Windows.Forms.ComboBox distantion;
        private System.Windows.Forms.Label sponsor_runner;
        private System.Windows.Forms.DataGridView results;
        private System.Windows.Forms.Label information;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button filter;
        private System.Windows.Forms.Label count_start;
        private System.Windows.Forms.Label count_finish;
    }
}