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
    public partial class About_Marathon_Skills_2021 : Form
    {
        public About_Marathon_Skills_2021()
        {
            InitializeComponent();
        }

        private void About_Marathon_Skills_2021_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
