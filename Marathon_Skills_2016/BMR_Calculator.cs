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
    public partial class BMR_Calculator : Form
    {
        public BMR_Calculator()
        {
            InitializeComponent();
        }


        int a = 0, c;
        double d, b, s;
        double z, x, h, g, f;

        private void btn_cansel_Click(object sender, EventArgs e)
        {
            var fomr = new Find_Out_More_Information();
            fomr.Show();
            Hide();
        }

        private void userControl11_Load(object sender, EventArgs e)
        {
            userControl11.timer1.Start();
        }

        private void FemalePictureBox_Click(object sender, EventArgs e)
        {
            a = 2;
            FemalePictureBox.BackColor = Color.Gray;
            MalePictureBox.BackColor = Color.White;
        }

        private void MalePictureBox_Click(object sender, EventArgs e)
        {
            a = 1;
            FemalePictureBox.BackColor = Color.White;
            MalePictureBox.BackColor = Color.Gray;
        }

        private void InfoPictureBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("СИДЯЧИЙ ОБРАЗ 	НЕТ РАБОТЫ ИЛИ РАБОТА ЗА СТОЛОМ             Маленькая активность Мало физических работы или занятия спортом 1 - 3 раза в неделю                                     " +
                "                             СРЕДНЯЯ АКТИВНОСТЬ УМЕРЕННАЯ ФИЗИЧЕСКАЯ РАБОТА ИЛИ ЗАНЯТИЯ СПОРТОМ 3 - 5 ДНЕЙ В НЕДЕЛЮ Сильная активность  Сильные физическая нагрузка или занятия спортом 6 - 7 дней в неделю Максимальная активность Сильная ежедневная физическая нагрузка или спорт и физическая работа");
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                double c = Convert.ToInt32(GrowthTextBox.Text);
                double d = Convert.ToInt32(WeightTextBox.Text);
                double s = Convert.ToInt32(AgeTextBox.Text);
                if (a <= 1)
                {
                    b = 66.0 + (13.7 * c) + (5.0 * d) + (6.8 * s);
                    z = b * 1.2;
                    x = b * 1.375;
                    h = b * 1.55;
                    g = b * 1.725;
                    f = b * 1.9;

                    AmountBMRLabel.Text = b.ToString();
                    SedentaryAmountLabel.Text = z.ToString();
                    PetiteAmountLabel.Text = x.ToString();
                    AvarageAmountLabel.Text = h.ToString();
                    StrongAmountLabel.Text = g.ToString();
                    MaximumAmountLabel.Text = f.ToString();

                }
                else if (a >= 2)
                {
                    b = 655 + (9.6 * c) + (1.8 * d) + (4.7 * s);
                    z = b * 1.2;
                    x = b * 1.375;
                    h = b * 1.55;
                    g = b * 1.725;
                    f = b * 1.9;

                    AmountBMRLabel.Text = b.ToString();
                    SedentaryAmountLabel.Text = z.ToString();
                    PetiteAmountLabel.Text = x.ToString();
                    AvarageAmountLabel.Text = h.ToString();
                    StrongAmountLabel.Text = g.ToString();
                    MaximumAmountLabel.Text = f.ToString();
                }
                else
                {
                    MessageBox.Show("Выберете пол");
                }
            }
            catch
            {
                MessageBox.Show("Ошибка в вводе");
            }
        }

    }
}
