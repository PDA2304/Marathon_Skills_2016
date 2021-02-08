using System;
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
        string email = "";
        public Runner_Menu(string Email)
        {
            InitializeComponent();
            this.email = Email;
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

        private void btn_rigistration_marathon_Click(object sender, EventArgs e)
        {
            var form = new Register_for_an_event(email);
            Hide();
            form.Show();
        }

        private void Runner_Menu_Load(object sender, EventArgs e)
        {

        }

        private void btn_edit_profile_Click(object sender, EventArgs e)
        {
            var form = new Edit_runner_profile(email);
            form.Show();
            Hide();
        }

        private void btn_results_Click(object sender, EventArgs e)
        {
            var form = new My_race_results(email);
            form.Show();
            Hide();
        }

        private void btn_sponsor_Click(object sender, EventArgs e)
        {
            var form = new My_Sponsorship(email);
            form.Show();
            Hide();
        }
    }
}
