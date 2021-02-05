namespace Marathon_Skills_2016
{
    partial class List_Of_Charities
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(List_Of_Charities));
            this.panel_back_gorund_down = new System.Windows.Forms.Panel();
            this.count_date = new System.Windows.Forms.Label();
            this.information = new System.Windows.Forms.Label();
            this.sponsor_runner = new System.Windows.Forms.Label();
            this.marathon_skills_2021 = new System.Windows.Forms.Label();
            this.bt_cansel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_list_blag_organozation = new System.Windows.Forms.Panel();
            this.date_count = new System.Windows.Forms.Timer(this.components);
            this.panel_back_gorund_down.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_back_gorund_down
            // 
            this.panel_back_gorund_down.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_back_gorund_down.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.panel_back_gorund_down.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel_back_gorund_down.Controls.Add(this.count_date);
            this.panel_back_gorund_down.Location = new System.Drawing.Point(0, 744);
            this.panel_back_gorund_down.Name = "panel_back_gorund_down";
            this.panel_back_gorund_down.Size = new System.Drawing.Size(1433, 60);
            this.panel_back_gorund_down.TabIndex = 48;
            // 
            // count_date
            // 
            this.count_date.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.count_date.ForeColor = System.Drawing.SystemColors.Control;
            this.count_date.Location = new System.Drawing.Point(0, 18);
            this.count_date.Name = "count_date";
            this.count_date.Size = new System.Drawing.Size(1433, 27);
            this.count_date.TabIndex = 14;
            this.count_date.Text = "18 дней 8 часов и 17 минут до старта марафона!";
            this.count_date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // information
            // 
            this.information.AllowDrop = true;
            this.information.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.information.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.information.Location = new System.Drawing.Point(251, 182);
            this.information.Name = "information";
            this.information.Size = new System.Drawing.Size(948, 99);
            this.information.TabIndex = 32;
            this.information.Text = "Это - список всех благотворительных учреждений которые поддерживаются в \r\nMaratho" +
    "n Skills 2016. Спасибо за помощь вы поддерживаете их, спонсируя \r\nбегунов!";
            this.information.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sponsor_runner
            // 
            this.sponsor_runner.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sponsor_runner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.sponsor_runner.Location = new System.Drawing.Point(0, 113);
            this.sponsor_runner.Name = "sponsor_runner";
            this.sponsor_runner.Size = new System.Drawing.Size(1433, 58);
            this.sponsor_runner.TabIndex = 31;
            this.sponsor_runner.Text = "Список благовторительных организаций";
            this.sponsor_runner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // bt_cansel
            // 
            this.bt_cansel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_cansel.Font = new System.Drawing.Font("Arial", 14F);
            this.bt_cansel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bt_cansel.Location = new System.Drawing.Point(20, 20);
            this.bt_cansel.Name = "bt_cansel";
            this.bt_cansel.Size = new System.Drawing.Size(90, 40);
            this.bt_cansel.TabIndex = 1;
            this.bt_cansel.Text = "Назад";
            this.bt_cansel.UseVisualStyleBackColor = true;
            this.bt_cansel.Click += new System.EventHandler(this.bt_cansel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.marathon_skills_2021);
            this.panel1.Controls.Add(this.bt_cansel);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1433, 79);
            this.panel1.TabIndex = 30;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(160, 160);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // textBox2
            // 
            this.textBox2.AllowDrop = true;
            this.textBox2.BackColor = System.Drawing.SystemColors.Window;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.textBox2.Location = new System.Drawing.Point(311, 104);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(1119, 97);
            this.textBox2.TabIndex = 53;
            this.textBox2.Text = resources.GetString("textBox2.Text");
            this.textBox2.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(100, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 200);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 49;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label2.Location = new System.Drawing.Point(306, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(700, 100);
            this.label2.TabIndex = 50;
            this.label2.Text = "Наименование благотворительной организаци";
            // 
            // panel_list_blag_organozation
            // 
            this.panel_list_blag_organozation.AutoScroll = true;
            this.panel_list_blag_organozation.Location = new System.Drawing.Point(0, 300);
            this.panel_list_blag_organozation.Name = "panel_list_blag_organozation";
            this.panel_list_blag_organozation.Size = new System.Drawing.Size(1433, 438);
            this.panel_list_blag_organozation.TabIndex = 53;
            // 
            // date_count
            // 
            this.date_count.Interval = 1;
            this.date_count.Tick += new System.EventHandler(this.date_count_Tick);
            // 
            // List_Of_Charities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1432, 803);
            this.Controls.Add(this.panel_list_blag_organozation);
            this.Controls.Add(this.panel_back_gorund_down);
            this.Controls.Add(this.information);
            this.Controls.Add(this.sponsor_runner);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1450, 850);
            this.MinimumSize = new System.Drawing.Size(1450, 850);
            this.Name = "List_Of_Charities";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marathon Skills 2021 - List of charities";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.List_Of_Charities_FormClosed);
            this.Load += new System.EventHandler(this.List_Of_Charities_Load);
            this.panel_back_gorund_down.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_back_gorund_down;
        private System.Windows.Forms.Label count_date;
        private System.Windows.Forms.Label information;
        private System.Windows.Forms.Label sponsor_runner;
        private System.Windows.Forms.Label marathon_skills_2021;
        private System.Windows.Forms.Button bt_cansel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel_list_blag_organozation;
        private System.Windows.Forms.Timer date_count;
    }
}