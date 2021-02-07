﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marathon_Skills_2016
{
    public partial class Runner_Menu : Form
    {
        public Runner_Menu()
        {
            InitializeComponent();
        }

        private void userControl11_Load(object sender, EventArgs e)
        {
            userControl11.timer1.Start();
        }

        private void btn_contact_Click(object sender, EventArgs e)
        {
            var form = new Runner_menu_kontakt_dialog();
            form.ShowDialog();
        }

        private void Runner_Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_cansel_Click(object sender, EventArgs e)
        {
            var form = new start_screen();
            Hide();
            form.Show();
        }
    }
}
