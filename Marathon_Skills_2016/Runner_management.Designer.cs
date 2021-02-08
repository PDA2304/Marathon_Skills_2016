namespace Marathon_Skills_2016
{
    partial class Runner_management
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
            this.button3 = new System.Windows.Forms.Button();
            this.marathon_skills_2021 = new System.Windows.Forms.Label();
            this.btn_cansel = new System.Windows.Forms.Button();
            this.count_start = new System.Windows.Forms.Label();
            this.filter = new System.Windows.Forms.Button();
            this.information = new System.Windows.Forms.Label();
            this.results = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.sponsor_runner = new System.Windows.Forms.Label();
            this.marafon = new System.Windows.Forms.ComboBox();
            this.userControl11 = new Marathon_Skills_2016.UserControl1();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.results)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.marathon_skills_2021);
            this.panel1.Controls.Add(this.btn_cansel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1432, 79);
            this.panel1.TabIndex = 80;
            // 
            // button3
            // 
            this.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button3.Font = new System.Drawing.Font("Arial", 14F);
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.button3.Location = new System.Drawing.Point(1324, 20);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 40);
            this.button3.TabIndex = 90;
            this.button3.Text = "Logout";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
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
            // count_start
            // 
            this.count_start.AllowDrop = true;
            this.count_start.AutoSize = true;
            this.count_start.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.count_start.ForeColor = System.Drawing.Color.Black;
            this.count_start.Location = new System.Drawing.Point(616, 290);
            this.count_start.Name = "count_start";
            this.count_start.Size = new System.Drawing.Size(217, 33);
            this.count_start.TabIndex = 87;
            this.count_start.Text = "Всего бегунов:";
            this.count_start.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // filter
            // 
            this.filter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.filter.Font = new System.Drawing.Font("Arial", 14F);
            this.filter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.filter.Location = new System.Drawing.Point(735, 226);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(372, 40);
            this.filter.TabIndex = 79;
            this.filter.Text = "Поиск";
            this.filter.UseVisualStyleBackColor = true;
            this.filter.Click += new System.EventHandler(this.filter_Click);
            // 
            // information
            // 
            this.information.AllowDrop = true;
            this.information.AutoSize = true;
            this.information.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.information.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.information.Location = new System.Drawing.Point(268, 233);
            this.information.Name = "information";
            this.information.Size = new System.Drawing.Size(105, 27);
            this.information.TabIndex = 85;
            this.information.Text = "Статуст:";
            this.information.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // results
            // 
            this.results.AllowUserToAddRows = false;
            this.results.AllowUserToDeleteRows = false;
            this.results.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.results.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.edit});
            this.results.Location = new System.Drawing.Point(210, 326);
            this.results.Name = "results";
            this.results.ReadOnly = true;
            this.results.RowHeadersWidth = 51;
            this.results.RowTemplate.Height = 24;
            this.results.Size = new System.Drawing.Size(1000, 400);
            this.results.TabIndex = 84;
            this.results.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.results_CellContentClick);
            this.results.SelectionChanged += new System.EventHandler(this.results_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "LastName";
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "LastName";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 101;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "FirstName";
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "FirstName";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 101;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Email";
            this.Column3.Frozen = true;
            this.Column3.HeaderText = "Email";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 71;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "RegistrationStatus";
            this.Column4.Frozen = true;
            this.Column4.HeaderText = "RegistrationStatus";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 153;
            // 
            // edit
            // 
            this.edit.Frozen = true;
            this.edit.HeaderText = "";
            this.edit.MinimumWidth = 6;
            this.edit.Name = "edit";
            this.edit.ReadOnly = true;
            this.edit.Text = "Редактирование";
            this.edit.Width = 6;
            // 
            // sponsor_runner
            // 
            this.sponsor_runner.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sponsor_runner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.sponsor_runner.Location = new System.Drawing.Point(0, 79);
            this.sponsor_runner.Name = "sponsor_runner";
            this.sponsor_runner.Size = new System.Drawing.Size(1432, 88);
            this.sponsor_runner.TabIndex = 83;
            this.sponsor_runner.Text = "Результат предыдущих гонок";
            this.sponsor_runner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // marafon
            // 
            this.marafon.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.marafon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.marafon.FormattingEnabled = true;
            this.marafon.Items.AddRange(new object[] {
            "Registered",
            "Payment Confirmed",
            "Race Kit Sent",
            "Race Attended"});
            this.marafon.Location = new System.Drawing.Point(385, 230);
            this.marafon.Name = "marafon";
            this.marafon.Size = new System.Drawing.Size(300, 34);
            this.marafon.TabIndex = 81;
            // 
            // userControl11
            // 
            this.userControl11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.userControl11.Location = new System.Drawing.Point(0, 729);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(1432, 74);
            this.userControl11.TabIndex = 78;
            this.userControl11.Load += new System.EventHandler(this.userControl11_Load);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Font = new System.Drawing.Font("Arial", 14F);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.button2.Location = new System.Drawing.Point(1123, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 40);
            this.button2.TabIndex = 89;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Runner_management_Load);
            // 
            // Runner_management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1432, 803);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.count_start);
            this.Controls.Add(this.filter);
            this.Controls.Add(this.information);
            this.Controls.Add(this.results);
            this.Controls.Add(this.sponsor_runner);
            this.Controls.Add(this.marafon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(1450, 850);
            this.MinimumSize = new System.Drawing.Size(1450, 850);
            this.Name = "Runner_management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Marathon Skills 2021 - Runner_management";
            this.Load += new System.EventHandler(this.Runner_management_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.results)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label marathon_skills_2021;
        private System.Windows.Forms.Button btn_cansel;
        private UserControl1 userControl11;
        private System.Windows.Forms.Label count_start;
        private System.Windows.Forms.Button filter;
        private System.Windows.Forms.Label information;
        private System.Windows.Forms.DataGridView results;
        private System.Windows.Forms.Label sponsor_runner;
        private System.Windows.Forms.ComboBox marafon;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn edit;
    }
}