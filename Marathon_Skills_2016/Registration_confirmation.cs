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
    public partial class Registration_confirmation : Form
    {
        string email = "";
        public Registration_confirmation(string Email)
        {
            InitializeComponent();
            this.email = Email;
        }

        private void btn_cansel_Click(object sender, EventArgs e)
        {
            var form = new Runner_Menu(email);
            Hide();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new start_screen();
            Hide();
            form.Show();
        }

        private void Registration_confirmation_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
