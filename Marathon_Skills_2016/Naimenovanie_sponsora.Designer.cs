namespace Marathon_Skills_2016
{
    partial class Naimenovanie_sponsora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Naimenovanie_sponsora));
            this.name_sponsor = new System.Windows.Forms.Label();
            this.icon_log = new System.Windows.Forms.PictureBox();
            this.description = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.icon_log)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.SuspendLayout();
            // 
            // name_sponsor
            // 
            this.name_sponsor.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_sponsor.Location = new System.Drawing.Point(1, 22);
            this.name_sponsor.Name = "name_sponsor";
            this.name_sponsor.Size = new System.Drawing.Size(798, 69);
            this.name_sponsor.TabIndex = 0;
            this.name_sponsor.Text = "Наименование спонсора";
            this.name_sponsor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // icon_log
            // 
            this.icon_log.Location = new System.Drawing.Point(301, 94);
            this.icon_log.Name = "icon_log";
            this.icon_log.Size = new System.Drawing.Size(200, 200);
            this.icon_log.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon_log.TabIndex = 2;
            this.icon_log.TabStop = false;
            // 
            // description
            // 
            this.description.AllowDrop = true;
            this.description.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.description.Location = new System.Drawing.Point(9, 354);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(779, 237);
            this.description.TabIndex = 3;
            this.description.Text = "label2";
            this.description.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // close
            // 
            this.close.ErrorImage = ((System.Drawing.Image)(resources.GetObject("close.ErrorImage")));
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.InitialImage = ((System.Drawing.Image)(resources.GetObject("close.InitialImage")));
            this.close.Location = new System.Drawing.Point(750, 12);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(38, 44);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close.TabIndex = 4;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // Naimenovanie_sponsora
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.close);
            this.Controls.Add(this.description);
            this.Controls.Add(this.icon_log);
            this.Controls.Add(this.name_sponsor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Naimenovanie_sponsora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Naimenovanie_sponsora";
            this.Load += new System.EventHandler(this.Naimenovanie_sponsora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.icon_log)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label name_sponsor;
        private System.Windows.Forms.PictureBox icon_log;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.PictureBox close;
    }
}