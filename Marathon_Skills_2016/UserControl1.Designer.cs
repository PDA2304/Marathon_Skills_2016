namespace Marathon_Skills_2016
{
    partial class UserControl1
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.count_date = new System.Windows.Forms.Label();
            this.panel_back_gorund_down = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel_back_gorund_down.SuspendLayout();
            this.SuspendLayout();
            // 
            // count_date
            // 
            this.count_date.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.count_date.ForeColor = System.Drawing.SystemColors.Control;
            this.count_date.Location = new System.Drawing.Point(0, 0);
            this.count_date.Name = "count_date";
            this.count_date.Size = new System.Drawing.Size(1433, 60);
            this.count_date.TabIndex = 14;
            this.count_date.Text = "18 дней 8 часов и 17 минут до старта марафона!";
            this.count_date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_back_gorund_down
            // 
            this.panel_back_gorund_down.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_back_gorund_down.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.panel_back_gorund_down.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel_back_gorund_down.Controls.Add(this.count_date);
            this.panel_back_gorund_down.Location = new System.Drawing.Point(0, 0);
            this.panel_back_gorund_down.Name = "panel_back_gorund_down";
            this.panel_back_gorund_down.Size = new System.Drawing.Size(1769, 60);
            this.panel_back_gorund_down.TabIndex = 76;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_back_gorund_down);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1433, 60);
            this.panel_back_gorund_down.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label count_date;
        private System.Windows.Forms.Panel panel_back_gorund_down;
        public System.Windows.Forms.Timer timer1;
    }
}
