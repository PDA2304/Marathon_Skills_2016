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
    public partial class Find_Out_More_Information : Form
    {
        public Find_Out_More_Information()
        {
            InitializeComponent();
        }

        private void Find_Out_More_Information_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_cansel_Click(object sender, EventArgs e)
        {
            var form = new start_screen();
            form.Show();
            this.Hide();
        }

        private void btn_blag_organization_Click(object sender, EventArgs e)
        {
            var form = new List_Of_Charities();
            form.Show();
            this.Hide();
        }

        private void Find_Out_More_Information_Load(object sender, EventArgs e)
        {
            date_count.Start();
        }

        private void date_count_Tick(object sender, EventArgs e)
        {
            var end_date = DateTime.Parse("21-10-2021");
            count_date.Text = $"{string.Format("{0:dd} дн. {0:hh} ч. {0:mm} м. {0:ss} сек.", end_date - DateTime.Now)} до старта марафона";
        }

        private void btn_maragon_date_Click(object sender, EventArgs e)
        {
            var form = new How_long_is_a_marathon();
            Hide();
            form.Show();
        }

        private void btn_marathon_skills_2021_Click(object sender, EventArgs e)
        {
            Hide();
            var form = new About_Marathon_Skills_2021();
            form.Show();
        }
    }
}
