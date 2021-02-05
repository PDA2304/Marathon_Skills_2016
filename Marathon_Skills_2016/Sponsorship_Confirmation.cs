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
    public partial class Sponsorship_Confirmation : Form
    {
        public Sponsorship_Confirmation()
        {
            InitializeComponent();
        }

        private void Sponsorship_Confirmation_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            
        }

        private void Sponsorship_Confirmation_Load(object sender, EventArgs e)
        {
            summa.Text = $"${SaveDate_Sponsor_Runner.cost.ToString()}";
            name_organization.Text = SaveDate_Sponsor_Runner.name_blag_organization.ToString();
            name_sponsora.Text = SaveDate_Sponsor_Runner.name_runner.ToString();
        }

        private void btn_cansel_Click(object sender, EventArgs e)
        {
            var form = new start_screen();
            form.Show();
            this.Hide();
        }

      
    }
}
