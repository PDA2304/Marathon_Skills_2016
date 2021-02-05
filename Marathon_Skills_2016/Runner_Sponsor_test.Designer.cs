namespace Marathon_Skills_2016
{
    partial class Runner_Sponsor_test
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Runner_Sponsor_test));
            this.panel1 = new System.Windows.Forms.Panel();
            this.marathon_skills_2021 = new System.Windows.Forms.Label();
            this.btn_cansel = new System.Windows.Forms.Button();
            this.sponsor_runner = new System.Windows.Forms.Label();
            this.information = new System.Windows.Forms.Label();
            this.information_sponsor = new System.Windows.Forms.Label();
            this.blagotvoritelnost_sponsor = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.runner_name = new System.Windows.Forms.Label();
            this.cart = new System.Windows.Forms.Label();
            this.nomer_cart = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.cb_runner = new System.Windows.Forms.ComboBox();
            this.tx_cart_name = new System.Windows.Forms.TextBox();
            this.mstb_nomer_cart = new System.Windows.Forms.MaskedTextBox();
            this.mstb_month = new System.Windows.Forms.MaskedTextBox();
            this.mstb_year = new System.Windows.Forms.MaskedTextBox();
            this.mstb_cvc = new System.Windows.Forms.MaskedTextBox();
            this.name_fond = new System.Windows.Forms.Label();
            this.icon_information = new System.Windows.Forms.PictureBox();
            this.summa_pogertvovania = new System.Windows.Forms.Label();
            this.summa = new System.Windows.Forms.Label();
            this.btn_cansel_back = new System.Windows.Forms.Button();
            this.btn_pay = new System.Windows.Forms.Button();
            this.btn_plus_summ = new System.Windows.Forms.Button();
            this.btn_minus_summ = new System.Windows.Forms.Button();
            this.tb_summa = new System.Windows.Forms.TextBox();
            this.date_cont = new System.Windows.Forms.Timer(this.components);
            this.userControl11 = new Marathon_Skills_2016.UserControl1();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_information)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.marathon_skills_2021);
            this.panel1.Controls.Add(this.btn_cansel);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1433, 79);
            this.panel1.TabIndex = 0;
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
            this.btn_cansel.Click += new System.EventHandler(this.btn_cansel_Click);
            // 
            // sponsor_runner
            // 
            this.sponsor_runner.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sponsor_runner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.sponsor_runner.Location = new System.Drawing.Point(0, 115);
            this.sponsor_runner.Name = "sponsor_runner";
            this.sponsor_runner.Size = new System.Drawing.Size(1433, 58);
            this.sponsor_runner.TabIndex = 1;
            this.sponsor_runner.Text = "Спонсор бегуна";
            this.sponsor_runner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // information
            // 
            this.information.AllowDrop = true;
            this.information.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.information.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.information.Location = new System.Drawing.Point(251, 184);
            this.information.Name = "information";
            this.information.Size = new System.Drawing.Size(948, 99);
            this.information.TabIndex = 2;
            this.information.Text = "Пожалуйства выберите бегуна, которого вы хотели бы спонсировать и сумму которую в" +
    "ы хотели бы спонсировать. Спасибоза вашу поддержка бегунов и их благотворительны" +
    "х учреждений.";
            this.information.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // information_sponsor
            // 
            this.information_sponsor.AllowDrop = true;
            this.information_sponsor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.information_sponsor.AutoSize = true;
            this.information_sponsor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.information_sponsor.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.information_sponsor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.information_sponsor.Location = new System.Drawing.Point(200, 315);
            this.information_sponsor.Name = "information_sponsor";
            this.information_sponsor.Size = new System.Drawing.Size(508, 46);
            this.information_sponsor.TabIndex = 4;
            this.information_sponsor.Text = "Информация о спонсоре";
            this.information_sponsor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // blagotvoritelnost_sponsor
            // 
            this.blagotvoritelnost_sponsor.AllowDrop = true;
            this.blagotvoritelnost_sponsor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.blagotvoritelnost_sponsor.AutoSize = true;
            this.blagotvoritelnost_sponsor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.blagotvoritelnost_sponsor.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.blagotvoritelnost_sponsor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.blagotvoritelnost_sponsor.Location = new System.Drawing.Point(850, 315);
            this.blagotvoritelnost_sponsor.Name = "blagotvoritelnost_sponsor";
            this.blagotvoritelnost_sponsor.Size = new System.Drawing.Size(458, 46);
            this.blagotvoritelnost_sponsor.TabIndex = 5;
            this.blagotvoritelnost_sponsor.Text = "Благотворительность";
            this.blagotvoritelnost_sponsor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Arial", 14F);
            this.name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.name.Location = new System.Drawing.Point(150, 400);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(130, 27);
            this.name.TabIndex = 6;
            this.name.Text = "Ваше имя:";
            // 
            // runner_name
            // 
            this.runner_name.AutoSize = true;
            this.runner_name.Font = new System.Drawing.Font("Arial", 14F);
            this.runner_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.runner_name.Location = new System.Drawing.Point(197, 452);
            this.runner_name.Name = "runner_name";
            this.runner_name.Size = new System.Drawing.Size(82, 27);
            this.runner_name.TabIndex = 7;
            this.runner_name.Text = "Бегун:";
            // 
            // cart
            // 
            this.cart.AutoSize = true;
            this.cart.Font = new System.Drawing.Font("Arial", 14F);
            this.cart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.cart.Location = new System.Drawing.Point(197, 503);
            this.cart.Name = "cart";
            this.cart.Size = new System.Drawing.Size(83, 27);
            this.cart.TabIndex = 8;
            this.cart.Text = "Карта:";
            // 
            // nomer_cart
            // 
            this.nomer_cart.AutoSize = true;
            this.nomer_cart.Font = new System.Drawing.Font("Arial", 14F);
            this.nomer_cart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.nomer_cart.Location = new System.Drawing.Point(101, 556);
            this.nomer_cart.Name = "nomer_cart";
            this.nomer_cart.Size = new System.Drawing.Size(179, 27);
            this.nomer_cart.TabIndex = 9;
            this.nomer_cart.Text = "Номер карты#:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label5.Location = new System.Drawing.Point(211, 654);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 27);
            this.label5.TabIndex = 10;
            this.label5.Text = "CVC:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label6.Location = new System.Drawing.Point(97, 605);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 27);
            this.label6.TabIndex = 11;
            this.label6.Text = "Срок действия:";
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_name.Location = new System.Drawing.Point(300, 393);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(408, 34);
            this.tb_name.TabIndex = 12;
            // 
            // cb_runner
            // 
            this.cb_runner.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_runner.FormattingEnabled = true;
            this.cb_runner.Location = new System.Drawing.Point(300, 445);
            this.cb_runner.Name = "cb_runner";
            this.cb_runner.Size = new System.Drawing.Size(408, 34);
            this.cb_runner.TabIndex = 13;
            this.cb_runner.SelectedValueChanged += new System.EventHandler(this.cb_runner_SelectedValueChanged);
            // 
            // tx_cart_name
            // 
            this.tx_cart_name.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tx_cart_name.Location = new System.Drawing.Point(300, 496);
            this.tx_cart_name.Name = "tx_cart_name";
            this.tx_cart_name.Size = new System.Drawing.Size(408, 34);
            this.tx_cart_name.TabIndex = 14;
            // 
            // mstb_nomer_cart
            // 
            this.mstb_nomer_cart.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mstb_nomer_cart.Location = new System.Drawing.Point(300, 549);
            this.mstb_nomer_cart.Mask = "0000 0000 0000 0000";
            this.mstb_nomer_cart.Name = "mstb_nomer_cart";
            this.mstb_nomer_cart.Size = new System.Drawing.Size(408, 34);
            this.mstb_nomer_cart.TabIndex = 15;
            // 
            // mstb_month
            // 
            this.mstb_month.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mstb_month.Location = new System.Drawing.Point(300, 598);
            this.mstb_month.Mask = "00";
            this.mstb_month.Name = "mstb_month";
            this.mstb_month.Size = new System.Drawing.Size(42, 34);
            this.mstb_month.TabIndex = 16;
            this.mstb_month.ValidatingType = typeof(System.DateTime);
            // 
            // mstb_year
            // 
            this.mstb_year.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mstb_year.Location = new System.Drawing.Point(348, 598);
            this.mstb_year.Mask = "0000";
            this.mstb_year.Name = "mstb_year";
            this.mstb_year.Size = new System.Drawing.Size(70, 34);
            this.mstb_year.TabIndex = 17;
            // 
            // mstb_cvc
            // 
            this.mstb_cvc.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mstb_cvc.Location = new System.Drawing.Point(300, 647);
            this.mstb_cvc.Mask = "000";
            this.mstb_cvc.Name = "mstb_cvc";
            this.mstb_cvc.Size = new System.Drawing.Size(42, 34);
            this.mstb_cvc.TabIndex = 18;
            // 
            // name_fond
            // 
            this.name_fond.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_fond.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.name_fond.Location = new System.Drawing.Point(868, 393);
            this.name_fond.Name = "name_fond";
            this.name_fond.Size = new System.Drawing.Size(396, 34);
            this.name_fond.TabIndex = 20;
            this.name_fond.Text = "Фонд Кошек";
            this.name_fond.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // icon_information
            // 
            this.icon_information.Image = ((System.Drawing.Image)(resources.GetObject("icon_information.Image")));
            this.icon_information.Location = new System.Drawing.Point(1270, 393);
            this.icon_information.Name = "icon_information";
            this.icon_information.Size = new System.Drawing.Size(38, 34);
            this.icon_information.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon_information.TabIndex = 21;
            this.icon_information.TabStop = false;
            this.icon_information.Click += new System.EventHandler(this.icon_information_Click);
            // 
            // summa_pogertvovania
            // 
            this.summa_pogertvovania.AutoSize = true;
            this.summa_pogertvovania.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.summa_pogertvovania.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.summa_pogertvovania.Location = new System.Drawing.Point(850, 452);
            this.summa_pogertvovania.Name = "summa_pogertvovania";
            this.summa_pogertvovania.Size = new System.Drawing.Size(465, 46);
            this.summa_pogertvovania.TabIndex = 22;
            this.summa_pogertvovania.Text = "Сумма пожертвования";
            // 
            // summa
            // 
            this.summa.AutoSize = true;
            this.summa.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.summa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.summa.Location = new System.Drawing.Point(986, 503);
            this.summa.Name = "summa";
            this.summa.Size = new System.Drawing.Size(172, 93);
            this.summa.TabIndex = 23;
            this.summa.Text = "$50";
            // 
            // btn_cansel_back
            // 
            this.btn_cansel_back.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cansel_back.Font = new System.Drawing.Font("Arial", 14F);
            this.btn_cansel_back.ForeColor = System.Drawing.Color.Black;
            this.btn_cansel_back.Location = new System.Drawing.Point(1108, 665);
            this.btn_cansel_back.Name = "btn_cansel_back";
            this.btn_cansel_back.Size = new System.Drawing.Size(200, 50);
            this.btn_cansel_back.TabIndex = 24;
            this.btn_cansel_back.Text = "Отмена";
            this.btn_cansel_back.UseVisualStyleBackColor = true;
            this.btn_cansel_back.Click += new System.EventHandler(this.btn_cansel_Click);
            // 
            // btn_pay
            // 
            this.btn_pay.Font = new System.Drawing.Font("Arial", 14F);
            this.btn_pay.ForeColor = System.Drawing.Color.Black;
            this.btn_pay.Location = new System.Drawing.Point(858, 665);
            this.btn_pay.Name = "btn_pay";
            this.btn_pay.Size = new System.Drawing.Size(200, 50);
            this.btn_pay.TabIndex = 25;
            this.btn_pay.Text = "Заплатить";
            this.btn_pay.UseVisualStyleBackColor = true;
            this.btn_pay.Click += new System.EventHandler(this.btn_pay_Click);
            // 
            // btn_plus_summ
            // 
            this.btn_plus_summ.Font = new System.Drawing.Font("Arial", 14F);
            this.btn_plus_summ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_plus_summ.Location = new System.Drawing.Point(946, 599);
            this.btn_plus_summ.Name = "btn_plus_summ";
            this.btn_plus_summ.Size = new System.Drawing.Size(50, 34);
            this.btn_plus_summ.TabIndex = 26;
            this.btn_plus_summ.Text = "+";
            this.btn_plus_summ.UseVisualStyleBackColor = true;
            this.btn_plus_summ.Click += new System.EventHandler(this.btn_plus_summ_Click);
            // 
            // btn_minus_summ
            // 
            this.btn_minus_summ.Font = new System.Drawing.Font("Arial", 14F);
            this.btn_minus_summ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_minus_summ.Location = new System.Drawing.Point(1144, 599);
            this.btn_minus_summ.Name = "btn_minus_summ";
            this.btn_minus_summ.Size = new System.Drawing.Size(34, 34);
            this.btn_minus_summ.TabIndex = 27;
            this.btn_minus_summ.Text = "-";
            this.btn_minus_summ.UseVisualStyleBackColor = true;
            this.btn_minus_summ.Click += new System.EventHandler(this.btn_minus_summ_Click);
            // 
            // tb_summa
            // 
            this.tb_summa.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_summa.Location = new System.Drawing.Point(1002, 598);
            this.tb_summa.MaxLength = 6;
            this.tb_summa.Name = "tb_summa";
            this.tb_summa.Size = new System.Drawing.Size(136, 34);
            this.tb_summa.TabIndex = 28;
            this.tb_summa.Text = "50";
            this.tb_summa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_summa.TextChanged += new System.EventHandler(this.tb_summa_TextChanged);
            this.tb_summa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_summa_KeyPress);
            // 
            // date_cont
            // 
            this.date_cont.Interval = 1;
            this.date_cont.Tick += new System.EventHandler(this.date_cont_Tick);
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(0, 742);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(1433, 60);
            this.userControl11.TabIndex = 29;
            this.userControl11.Load += new System.EventHandler(this.userControl11_Load);
            // 
            // Runner_Sponsor_test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.CancelButton = this.btn_cansel_back;
            this.ClientSize = new System.Drawing.Size(1432, 803);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.tb_summa);
            this.Controls.Add(this.btn_minus_summ);
            this.Controls.Add(this.btn_plus_summ);
            this.Controls.Add(this.btn_pay);
            this.Controls.Add(this.btn_cansel_back);
            this.Controls.Add(this.summa);
            this.Controls.Add(this.summa_pogertvovania);
            this.Controls.Add(this.icon_information);
            this.Controls.Add(this.name_fond);
            this.Controls.Add(this.mstb_cvc);
            this.Controls.Add(this.mstb_year);
            this.Controls.Add(this.mstb_month);
            this.Controls.Add(this.mstb_nomer_cart);
            this.Controls.Add(this.tx_cart_name);
            this.Controls.Add(this.cb_runner);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nomer_cart);
            this.Controls.Add(this.cart);
            this.Controls.Add(this.runner_name);
            this.Controls.Add(this.name);
            this.Controls.Add(this.blagotvoritelnost_sponsor);
            this.Controls.Add(this.information_sponsor);
            this.Controls.Add(this.information);
            this.Controls.Add(this.sponsor_runner);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(1450, 850);
            this.MinimumSize = new System.Drawing.Size(1450, 850);
            this.Name = "Runner_Sponsor_test";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marathon Skills 2021 - Sponsor a runner";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Runner_Sponsor_test_FormClosed);
            this.Load += new System.EventHandler(this.Runner_Sponsor_test_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_information)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_cansel;
        private System.Windows.Forms.Label marathon_skills_2021;
        private System.Windows.Forms.Label sponsor_runner;
        private System.Windows.Forms.Label information;
        private System.Windows.Forms.Label blagotvoritelnost_sponsor;
        private System.Windows.Forms.Label information_sponsor;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label runner_name;
        private System.Windows.Forms.Label cart;
        private System.Windows.Forms.Label nomer_cart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.ComboBox cb_runner;
        private System.Windows.Forms.TextBox tx_cart_name;
        private System.Windows.Forms.MaskedTextBox mstb_nomer_cart;
        private System.Windows.Forms.MaskedTextBox mstb_month;
        private System.Windows.Forms.MaskedTextBox mstb_year;
        private System.Windows.Forms.MaskedTextBox mstb_cvc;
        private System.Windows.Forms.Label name_fond;
        private System.Windows.Forms.PictureBox icon_information;
        private System.Windows.Forms.Label summa_pogertvovania;
        private System.Windows.Forms.Label summa;
        private System.Windows.Forms.Button btn_cansel_back;
        private System.Windows.Forms.Button btn_pay;
        private System.Windows.Forms.Button btn_plus_summ;
        private System.Windows.Forms.Button btn_minus_summ;
        public System.Windows.Forms.Timer date_cont;
        public System.Windows.Forms.TextBox tb_summa;
        private UserControl1 userControl11;
    }
}