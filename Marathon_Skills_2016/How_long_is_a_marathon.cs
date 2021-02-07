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
    public partial class How_long_is_a_marathon : Form
    {
        public How_long_is_a_marathon()
        {
            InitializeComponent();
        }

        private void userControl11_Load(object sender, EventArgs e)
        {
            userControl11.timer1.Start();
        }

        private void How_long_is_a_marathon_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FirstParagraphPictureBox_Click(object sender, EventArgs e)
        {
            SelectedParagraphPhotoPictureBox.Image = (sender as PictureBox).Image;
            InformationLabel.Text = (sender as PictureBox).Tag.ToString();
            label1.Text = (sender as PictureBox).Name;
        }

        private void btn_cansel_Click(object sender, EventArgs e)
        {
            var form = new Find_Out_More_Information();
            Hide();
            form.Show();
        }
    }
}
