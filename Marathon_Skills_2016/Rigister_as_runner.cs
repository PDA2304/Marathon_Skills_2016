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
    public partial class Rigister_as_runner : Form
    {
        public Rigister_as_runner()
        {
            InitializeComponent();
        }

        private void btn_old_runner_Click(object sender, EventArgs e)
        {
            var form = new Login();
            form.Show();
            this.Hide();
        }

        private void userControl11_Load(object sender, EventArgs e)
        {
            userControl11.timer1.Start();
        }

        private void btn_cansel_Click(object sender, EventArgs e)
        {
            var form = new start_screen();
            form.Show();
            this.Hide();
        }
    }
}
