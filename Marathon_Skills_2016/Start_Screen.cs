using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marathon_Skills_2016
{
    public partial class start_screen : Form
    {
        public start_screen()
        {
            InitializeComponent();
        }

        private void to_runner_sponsor_Click(object sender, EventArgs e)
        {
            this.Hide();
            Runner_Sponsor_test runner_Sponsor = new Runner_Sponsor_test();
            runner_Sponsor.Show();
        }

        private void start_screen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void btn_more_information_Click(object sender, EventArgs e)
        {
            var form = new Find_Out_More_Information();
            form.Show();
            this.Hide();
        }

        private void btn_rigister_runner_Click(object sender, EventArgs e)
        {
            var form = new Rigister_as_runner();
            form.Show();
            this.Hide();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            var form = new Login();
            form.Show();
            this.Hide();
        }

        private void userControl11_Load(object sender, EventArgs e)
        {
            userControl11.timer1.Start();
        }
    }
}
