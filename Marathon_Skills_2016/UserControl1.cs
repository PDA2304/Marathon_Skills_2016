using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marathon_Skills_2016
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var end_date = DateTime.Parse("08-02-2021 12:00:00");
            count_date.Text = $"{string.Format("{0:dd} дн. {0:hh} ч. {0:mm} м. {0:ss} сек.", end_date - DateTime.Now)} до старта марафона";
        }
    }
}
