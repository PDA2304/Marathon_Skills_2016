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
    public partial class Interactive_Map : Form
    {
        public Interactive_Map()
        {
            InitializeComponent();
        }

        private void FirstStartPictureBox_Click(object sender, EventArgs e)
        {
            var type = ((PictureBox)sender).Tag;

            switch (type)
            {
                case "Туалет":
                    {
                        MessageBox.Show("Туалет");
                        break;
                    }
                case "Хрень":
                    {
                        MessageBox.Show("Стойка с энергетическими батончиками");
                        break;
                    }
                case "Вода":
                    {
                        MessageBox.Show("Стойка с напитками");
                        break;
                    }
                case "Информация":
                    {
                        MessageBox.Show("Стойка организаторов");
                        break;
                    }
                case "Мед_Пункт":
                    {
                        MessageBox.Show("Медицинский пункт");
                        break;
                    }
                case "Старт1":
                    {
                        MessageBox.Show("Бег на 5км");
                        break;
                    }
                case "Старт2":
                    {
                        MessageBox.Show("Бег на 21км");
                        break;
                    }
                case "Старт3":
                    {
                        MessageBox.Show("Бег на 42км");
                        break;
                    }
            }
        }

        private void About_Marathon_Skills_2021_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_cansel_Click(object sender, EventArgs e)
        {
            Hide();
            var form = new About_Marathon_Skills_2021();
            form.Show();
        }
    }
}
