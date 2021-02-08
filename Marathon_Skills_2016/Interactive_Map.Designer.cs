namespace Marathon_Skills_2016
{
    partial class Interactive_Map
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Interactive_Map));
            this.panel1 = new System.Windows.Forms.Panel();
            this.marathon_skills_2021 = new System.Windows.Forms.Label();
            this.btn_cansel = new System.Windows.Forms.Button();
            this.MapPictureBox = new System.Windows.Forms.PictureBox();
            this.DrinksPictureBox = new System.Windows.Forms.PictureBox();
            this.InfoPictureBox = new System.Windows.Forms.PictureBox();
            this.EnergyBarsPictureBox = new System.Windows.Forms.PictureBox();
            this.FirstToiletsPictureBox = new System.Windows.Forms.PictureBox();
            this.ThirdStartPictureBox = new System.Windows.Forms.PictureBox();
            this.SecondStartPictureBox = new System.Windows.Forms.PictureBox();
            this.FirstStartPictureBox = new System.Windows.Forms.PictureBox();
            this.SecondToiletsPictureBox = new System.Windows.Forms.PictureBox();
            this.MedicalPictureBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MapPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DrinksPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnergyBarsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstToiletsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThirdStartPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondStartPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstStartPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondToiletsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MedicalPictureBox)).BeginInit();
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
            this.panel1.TabIndex = 66;
            // 
            // marathon_skills_2021
            // 
            this.marathon_skills_2021.AutoSize = true;
            this.marathon_skills_2021.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.marathon_skills_2021.ForeColor = System.Drawing.SystemColors.Control;
            this.marathon_skills_2021.Location = new System.Drawing.Point(200, 10);
            this.marathon_skills_2021.Name = "marathon_skills_2021";
            this.marathon_skills_2021.Size = new System.Drawing.Size(1071, 56);
            this.marathon_skills_2021.TabIndex = 1;
            this.marathon_skills_2021.Text = "Интерактивная карта MARATHON SKILLS 2021";
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
            this.btn_cansel.Click += new System.EventHandler(this.btn_cansel_Click);
            // 
            // MapPictureBox
            // 
            this.MapPictureBox.Image = global::Marathon_Skills_2016.Properties.Resources.marathon_skills_2016_marathon_map;
            this.MapPictureBox.Location = new System.Drawing.Point(20, 86);
            this.MapPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.MapPictureBox.Name = "MapPictureBox";
            this.MapPictureBox.Size = new System.Drawing.Size(800, 600);
            this.MapPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MapPictureBox.TabIndex = 81;
            this.MapPictureBox.TabStop = false;
            // 
            // DrinksPictureBox
            // 
            this.DrinksPictureBox.Image = global::Marathon_Skills_2016.Properties.Resources.map_icon_drinks;
            this.DrinksPictureBox.Location = new System.Drawing.Point(650, 521);
            this.DrinksPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.DrinksPictureBox.Name = "DrinksPictureBox";
            this.DrinksPictureBox.Size = new System.Drawing.Size(60, 60);
            this.DrinksPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DrinksPictureBox.TabIndex = 97;
            this.DrinksPictureBox.TabStop = false;
            this.DrinksPictureBox.Tag = "Вода";
            this.DrinksPictureBox.Click += new System.EventHandler(this.FirstStartPictureBox_Click);
            // 
            // InfoPictureBox
            // 
            this.InfoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("InfoPictureBox.Image")));
            this.InfoPictureBox.Location = new System.Drawing.Point(158, 101);
            this.InfoPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.InfoPictureBox.Name = "InfoPictureBox";
            this.InfoPictureBox.Size = new System.Drawing.Size(60, 60);
            this.InfoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.InfoPictureBox.TabIndex = 96;
            this.InfoPictureBox.TabStop = false;
            this.InfoPictureBox.Tag = "Информация";
            this.InfoPictureBox.Click += new System.EventHandler(this.FirstStartPictureBox_Click);
            // 
            // EnergyBarsPictureBox
            // 
            this.EnergyBarsPictureBox.Image = global::Marathon_Skills_2016.Properties.Resources.map_icon_toilets;
            this.EnergyBarsPictureBox.Location = new System.Drawing.Point(228, 296);
            this.EnergyBarsPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.EnergyBarsPictureBox.Name = "EnergyBarsPictureBox";
            this.EnergyBarsPictureBox.Size = new System.Drawing.Size(60, 60);
            this.EnergyBarsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EnergyBarsPictureBox.TabIndex = 95;
            this.EnergyBarsPictureBox.TabStop = false;
            this.EnergyBarsPictureBox.Tag = "Туалет";
            this.EnergyBarsPictureBox.Click += new System.EventHandler(this.FirstStartPictureBox_Click);
            // 
            // FirstToiletsPictureBox
            // 
            this.FirstToiletsPictureBox.Image = global::Marathon_Skills_2016.Properties.Resources.map_icon_start;
            this.FirstToiletsPictureBox.Location = new System.Drawing.Point(441, 101);
            this.FirstToiletsPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.FirstToiletsPictureBox.Name = "FirstToiletsPictureBox";
            this.FirstToiletsPictureBox.Size = new System.Drawing.Size(60, 60);
            this.FirstToiletsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FirstToiletsPictureBox.TabIndex = 93;
            this.FirstToiletsPictureBox.TabStop = false;
            this.FirstToiletsPictureBox.Tag = "Старт1";
            this.FirstToiletsPictureBox.Click += new System.EventHandler(this.FirstStartPictureBox_Click);
            // 
            // ThirdStartPictureBox
            // 
            this.ThirdStartPictureBox.Image = global::Marathon_Skills_2016.Properties.Resources.map_icon_energy_bars;
            this.ThirdStartPictureBox.Location = new System.Drawing.Point(346, 628);
            this.ThirdStartPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.ThirdStartPictureBox.Name = "ThirdStartPictureBox";
            this.ThirdStartPictureBox.Size = new System.Drawing.Size(60, 60);
            this.ThirdStartPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ThirdStartPictureBox.TabIndex = 92;
            this.ThirdStartPictureBox.TabStop = false;
            this.ThirdStartPictureBox.Tag = "Хрень";
            this.ThirdStartPictureBox.Click += new System.EventHandler(this.FirstStartPictureBox_Click);
            // 
            // SecondStartPictureBox
            // 
            this.SecondStartPictureBox.Image = global::Marathon_Skills_2016.Properties.Resources.map_icon_medical;
            this.SecondStartPictureBox.Location = new System.Drawing.Point(424, 352);
            this.SecondStartPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.SecondStartPictureBox.Name = "SecondStartPictureBox";
            this.SecondStartPictureBox.Size = new System.Drawing.Size(60, 60);
            this.SecondStartPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SecondStartPictureBox.TabIndex = 91;
            this.SecondStartPictureBox.TabStop = false;
            this.SecondStartPictureBox.Tag = "Мед_Пункт";
            this.SecondStartPictureBox.Click += new System.EventHandler(this.FirstStartPictureBox_Click);
            // 
            // FirstStartPictureBox
            // 
            this.FirstStartPictureBox.Image = global::Marathon_Skills_2016.Properties.Resources.map_icon_toilets;
            this.FirstStartPictureBox.Location = new System.Drawing.Point(650, 101);
            this.FirstStartPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.FirstStartPictureBox.Name = "FirstStartPictureBox";
            this.FirstStartPictureBox.Size = new System.Drawing.Size(60, 60);
            this.FirstStartPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FirstStartPictureBox.TabIndex = 90;
            this.FirstStartPictureBox.TabStop = false;
            this.FirstStartPictureBox.Tag = "Туалет";
            this.FirstStartPictureBox.Click += new System.EventHandler(this.FirstStartPictureBox_Click);
            // 
            // SecondToiletsPictureBox
            // 
            this.SecondToiletsPictureBox.Image = global::Marathon_Skills_2016.Properties.Resources.map_icon_start;
            this.SecondToiletsPictureBox.Location = new System.Drawing.Point(228, 364);
            this.SecondToiletsPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.SecondToiletsPictureBox.Name = "SecondToiletsPictureBox";
            this.SecondToiletsPictureBox.Size = new System.Drawing.Size(60, 60);
            this.SecondToiletsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SecondToiletsPictureBox.TabIndex = 98;
            this.SecondToiletsPictureBox.TabStop = false;
            this.SecondToiletsPictureBox.Tag = "Старт3";
            this.SecondToiletsPictureBox.Click += new System.EventHandler(this.FirstStartPictureBox_Click);
            // 
            // MedicalPictureBox
            // 
            this.MedicalPictureBox.Image = global::Marathon_Skills_2016.Properties.Resources.map_icon_start;
            this.MedicalPictureBox.Location = new System.Drawing.Point(414, 628);
            this.MedicalPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.MedicalPictureBox.Name = "MedicalPictureBox";
            this.MedicalPictureBox.Size = new System.Drawing.Size(60, 60);
            this.MedicalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MedicalPictureBox.TabIndex = 94;
            this.MedicalPictureBox.TabStop = false;
            this.MedicalPictureBox.Tag = "Старт2";
            this.MedicalPictureBox.Click += new System.EventHandler(this.FirstStartPictureBox_Click);
            // 
            // Interactive_Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1432, 803);
            this.Controls.Add(this.SecondToiletsPictureBox);
            this.Controls.Add(this.DrinksPictureBox);
            this.Controls.Add(this.InfoPictureBox);
            this.Controls.Add(this.EnergyBarsPictureBox);
            this.Controls.Add(this.MedicalPictureBox);
            this.Controls.Add(this.FirstToiletsPictureBox);
            this.Controls.Add(this.ThirdStartPictureBox);
            this.Controls.Add(this.SecondStartPictureBox);
            this.Controls.Add(this.FirstStartPictureBox);
            this.Controls.Add(this.MapPictureBox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(1450, 850);
            this.MinimumSize = new System.Drawing.Size(1450, 850);
            this.Name = "Interactive_Map";
            this.Text = "Marathon Skills 2021 - Interactive_Map";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.About_Marathon_Skills_2021_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MapPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DrinksPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnergyBarsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstToiletsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThirdStartPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondStartPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstStartPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondToiletsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MedicalPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label marathon_skills_2021;
        private System.Windows.Forms.Button btn_cansel;
        private System.Windows.Forms.PictureBox MapPictureBox;
        private System.Windows.Forms.PictureBox DrinksPictureBox;
        private System.Windows.Forms.PictureBox InfoPictureBox;
        private System.Windows.Forms.PictureBox EnergyBarsPictureBox;
        private System.Windows.Forms.PictureBox FirstToiletsPictureBox;
        private System.Windows.Forms.PictureBox ThirdStartPictureBox;
        private System.Windows.Forms.PictureBox SecondStartPictureBox;
        private System.Windows.Forms.PictureBox FirstStartPictureBox;
        private System.Windows.Forms.PictureBox SecondToiletsPictureBox;
        private System.Windows.Forms.PictureBox MedicalPictureBox;
    }
}