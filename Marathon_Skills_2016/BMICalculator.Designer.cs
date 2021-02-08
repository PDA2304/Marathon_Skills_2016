namespace Marathon_Skills_2016
{
    partial class BMICalculator
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
            this.ResultLabel = new System.Windows.Forms.Label();
            this.FourthBMIPanel = new System.Windows.Forms.Panel();
            this.SecondBMIPanel = new System.Windows.Forms.Panel();
            this.ThirdBMIPanel = new System.Windows.Forms.Panel();
            this.FirstBMIPanel = new System.Windows.Forms.Panel();
            this.BMIResultPictureBox = new System.Windows.Forms.PictureBox();
            this.BMIResultsLabel = new System.Windows.Forms.Label();
            this.ResultPictureBox = new System.Windows.Forms.PictureBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.KgLabel = new System.Windows.Forms.Label();
            this.CmLabel = new System.Windows.Forms.Label();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.GrowthTextBox = new System.Windows.Forms.TextBox();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.GrowthLabel = new System.Windows.Forms.Label();
            this.FemalePictureBox = new System.Windows.Forms.PictureBox();
            this.DiscriptionLabel = new System.Windows.Forms.Label();
            this.BMICalculatorLabel = new System.Windows.Forms.Label();
            this.MalePictureBox = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.userControl11 = new Marathon_Skills_2016.UserControl1();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BMIResultPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FemalePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MalePictureBox)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.panel1.TabIndex = 81;
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
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Arial", 10F);
            this.ResultLabel.Location = new System.Drawing.Point(995, 505);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(86, 19);
            this.ResultLabel.TabIndex = 116;
            this.ResultLabel.Text = "Здоровый";
            // 
            // FourthBMIPanel
            // 
            this.FourthBMIPanel.BackColor = System.Drawing.Color.Red;
            this.FourthBMIPanel.ForeColor = System.Drawing.Color.Red;
            this.FourthBMIPanel.Location = new System.Drawing.Point(375, 0);
            this.FourthBMIPanel.Name = "FourthBMIPanel";
            this.FourthBMIPanel.Size = new System.Drawing.Size(125, 25);
            this.FourthBMIPanel.TabIndex = 115;
            // 
            // SecondBMIPanel
            // 
            this.SecondBMIPanel.BackColor = System.Drawing.Color.LimeGreen;
            this.SecondBMIPanel.ForeColor = System.Drawing.Color.Lime;
            this.SecondBMIPanel.Location = new System.Drawing.Point(125, 0);
            this.SecondBMIPanel.Name = "SecondBMIPanel";
            this.SecondBMIPanel.Size = new System.Drawing.Size(125, 25);
            this.SecondBMIPanel.TabIndex = 113;
            // 
            // ThirdBMIPanel
            // 
            this.ThirdBMIPanel.BackColor = System.Drawing.Color.Orange;
            this.ThirdBMIPanel.ForeColor = System.Drawing.Color.Orange;
            this.ThirdBMIPanel.Location = new System.Drawing.Point(250, 0);
            this.ThirdBMIPanel.Name = "ThirdBMIPanel";
            this.ThirdBMIPanel.Size = new System.Drawing.Size(125, 25);
            this.ThirdBMIPanel.TabIndex = 114;
            // 
            // FirstBMIPanel
            // 
            this.FirstBMIPanel.BackColor = System.Drawing.Color.Orange;
            this.FirstBMIPanel.ForeColor = System.Drawing.Color.Orange;
            this.FirstBMIPanel.Location = new System.Drawing.Point(0, 0);
            this.FirstBMIPanel.Name = "FirstBMIPanel";
            this.FirstBMIPanel.Size = new System.Drawing.Size(125, 25);
            this.FirstBMIPanel.TabIndex = 112;
            // 
            // BMIResultPictureBox
            // 
            this.BMIResultPictureBox.Image = global::Marathon_Skills_2016.Properties.Resources.Arrow;
            this.BMIResultPictureBox.Location = new System.Drawing.Point(1200, 681);
            this.BMIResultPictureBox.Name = "BMIResultPictureBox";
            this.BMIResultPictureBox.Size = new System.Drawing.Size(29, 28);
            this.BMIResultPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BMIResultPictureBox.TabIndex = 111;
            this.BMIResultPictureBox.TabStop = false;
            // 
            // BMIResultsLabel
            // 
            this.BMIResultsLabel.AutoSize = true;
            this.BMIResultsLabel.Font = new System.Drawing.Font("Arial", 10F);
            this.BMIResultsLabel.Location = new System.Drawing.Point(1200, 659);
            this.BMIResultsLabel.Name = "BMIResultsLabel";
            this.BMIResultsLabel.Size = new System.Drawing.Size(41, 19);
            this.BMIResultsLabel.TabIndex = 110;
            this.BMIResultsLabel.Text = "24.2";
            // 
            // ResultPictureBox
            // 
            this.ResultPictureBox.Location = new System.Drawing.Point(968, 156);
            this.ResultPictureBox.Name = "ResultPictureBox";
            this.ResultPictureBox.Size = new System.Drawing.Size(260, 276);
            this.ResultPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ResultPictureBox.TabIndex = 109;
            this.ResultPictureBox.TabStop = false;
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelButton.Location = new System.Drawing.Point(384, 648);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(200, 30);
            this.CancelButton.TabIndex = 108;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // CalculateButton
            // 
            this.CalculateButton.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CalculateButton.Location = new System.Drawing.Point(141, 648);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(200, 30);
            this.CalculateButton.TabIndex = 97;
            this.CalculateButton.Text = "Рассчитать";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // KgLabel
            // 
            this.KgLabel.AutoSize = true;
            this.KgLabel.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KgLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.KgLabel.Location = new System.Drawing.Point(455, 611);
            this.KgLabel.Name = "KgLabel";
            this.KgLabel.Size = new System.Drawing.Size(32, 27);
            this.KgLabel.TabIndex = 107;
            this.KgLabel.Text = "кг";
            // 
            // CmLabel
            // 
            this.CmLabel.AutoSize = true;
            this.CmLabel.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CmLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.CmLabel.Location = new System.Drawing.Point(446, 568);
            this.CmLabel.Name = "CmLabel";
            this.CmLabel.Size = new System.Drawing.Size(41, 27);
            this.CmLabel.TabIndex = 106;
            this.CmLabel.Text = "см";
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WeightTextBox.Location = new System.Drawing.Point(299, 608);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(141, 34);
            this.WeightTextBox.TabIndex = 105;
            this.WeightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BMI_KeyPress);
            // 
            // GrowthTextBox
            // 
            this.GrowthTextBox.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GrowthTextBox.Location = new System.Drawing.Point(299, 567);
            this.GrowthTextBox.Name = "GrowthTextBox";
            this.GrowthTextBox.Size = new System.Drawing.Size(141, 34);
            this.GrowthTextBox.TabIndex = 104;
            this.GrowthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BMI_KeyPress);
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WeightLabel.Location = new System.Drawing.Point(233, 615);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(60, 27);
            this.WeightLabel.TabIndex = 103;
            this.WeightLabel.Text = "Вес:";
            // 
            // GrowthLabel
            // 
            this.GrowthLabel.AutoSize = true;
            this.GrowthLabel.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GrowthLabel.Location = new System.Drawing.Point(223, 574);
            this.GrowthLabel.Name = "GrowthLabel";
            this.GrowthLabel.Size = new System.Drawing.Size(70, 27);
            this.GrowthLabel.TabIndex = 102;
            this.GrowthLabel.Text = "Рост:";
            // 
            // FemalePictureBox
            // 
            this.FemalePictureBox.Image = global::Marathon_Skills_2016.Properties.Resources.female_icon;
            this.FemalePictureBox.Location = new System.Drawing.Point(403, 345);
            this.FemalePictureBox.Name = "FemalePictureBox";
            this.FemalePictureBox.Size = new System.Drawing.Size(200, 200);
            this.FemalePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FemalePictureBox.TabIndex = 101;
            this.FemalePictureBox.TabStop = false;
            // 
            // DiscriptionLabel
            // 
            this.DiscriptionLabel.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DiscriptionLabel.Location = new System.Drawing.Point(126, 193);
            this.DiscriptionLabel.Name = "DiscriptionLabel";
            this.DiscriptionLabel.Size = new System.Drawing.Size(477, 103);
            this.DiscriptionLabel.TabIndex = 99;
            this.DiscriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BMICalculatorLabel
            // 
            this.BMICalculatorLabel.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BMICalculatorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BMICalculatorLabel.Location = new System.Drawing.Point(0, 82);
            this.BMICalculatorLabel.Name = "BMICalculatorLabel";
            this.BMICalculatorLabel.Size = new System.Drawing.Size(1420, 85);
            this.BMICalculatorLabel.TabIndex = 98;
            this.BMICalculatorLabel.Text = "BMI калькулятор";
            this.BMICalculatorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MalePictureBox
            // 
            this.MalePictureBox.Image = global::Marathon_Skills_2016.Properties.Resources.male_icon;
            this.MalePictureBox.Location = new System.Drawing.Point(116, 345);
            this.MalePictureBox.Name = "MalePictureBox";
            this.MalePictureBox.Size = new System.Drawing.Size(200, 200);
            this.MalePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MalePictureBox.TabIndex = 100;
            this.MalePictureBox.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.FourthBMIPanel);
            this.panel2.Controls.Add(this.FirstBMIPanel);
            this.panel2.Controls.Add(this.ThirdBMIPanel);
            this.panel2.Controls.Add(this.SecondBMIPanel);
            this.panel2.Location = new System.Drawing.Point(790, 617);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 32);
            this.panel2.TabIndex = 118;
            // 
            // userControl11
            // 
            this.userControl11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.userControl11.Location = new System.Drawing.Point(0, 729);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(1432, 74);
            this.userControl11.TabIndex = 117;
            this.userControl11.Load += new System.EventHandler(this.userControl11_Load);
            // 
            // BMICalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1432, 803);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.BMIResultPictureBox);
            this.Controls.Add(this.ResultPictureBox);
            this.Controls.Add(this.BMIResultsLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.KgLabel);
            this.Controls.Add(this.CmLabel);
            this.Controls.Add(this.WeightTextBox);
            this.Controls.Add(this.GrowthTextBox);
            this.Controls.Add(this.WeightLabel);
            this.Controls.Add(this.GrowthLabel);
            this.Controls.Add(this.FemalePictureBox);
            this.Controls.Add(this.DiscriptionLabel);
            this.Controls.Add(this.BMICalculatorLabel);
            this.Controls.Add(this.MalePictureBox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(1450, 850);
            this.MinimumSize = new System.Drawing.Size(1450, 850);
            this.Name = "BMICalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marathon Skills 2021 - BMI";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BMI_KeyPress);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BMIResultPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FemalePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MalePictureBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label marathon_skills_2021;
        private System.Windows.Forms.Button btn_cansel;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Panel FourthBMIPanel;
        private System.Windows.Forms.Panel SecondBMIPanel;
        private System.Windows.Forms.Panel ThirdBMIPanel;
        private System.Windows.Forms.Panel FirstBMIPanel;
        private System.Windows.Forms.PictureBox BMIResultPictureBox;
        private System.Windows.Forms.Label BMIResultsLabel;
        private System.Windows.Forms.PictureBox ResultPictureBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label KgLabel;
        private System.Windows.Forms.Label CmLabel;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.TextBox GrowthTextBox;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.Label GrowthLabel;
        private System.Windows.Forms.PictureBox FemalePictureBox;
        private System.Windows.Forms.Label DiscriptionLabel;
        private System.Windows.Forms.Label BMICalculatorLabel;
        private System.Windows.Forms.PictureBox MalePictureBox;
        private UserControl1 userControl11;
        private System.Windows.Forms.Panel panel2;
    }
}