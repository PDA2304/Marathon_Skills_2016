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
    public partial class BMICalculator : Form
    {
        public BMICalculator()
        {
            InitializeComponent();
        }
        private void userControl11_Load(object sender, EventArgs e)
        {
            userControl11.timer1.Start();
        }

        private void BMI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }

        int a = 0, c;
        double d, b;

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            var form = new Find_Out_More_Information();
            form.Show();
            Hide();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                double c = Convert.ToInt32(GrowthTextBox.Text);
                double d = Convert.ToInt32(WeightTextBox.Text);
                b = d / ((c / 100) * (c / 100));
                b = Math.Round(b, 1);
                if (b < 18)
                {
                    ResultLabel.Text = "Недостаточный";
                    BMIResultPictureBox.Location = new Point(840, 650);
                    BMIResultsLabel.Location = new Point(840, 650);
                    ResultPictureBox.Image = Properties.Resources.bmi_underweight_icon;
                    BMIResultsLabel.Text = b.ToString();
                }
                else if (18 <= b && b < 25)
                {
                    ResultLabel.Text = "Здоровый";
                    BMIResultPictureBox.Location = new Point(960, 680);
                    BMIResultsLabel.Location = new Point(960, 650);
                    ResultPictureBox.Image = Properties.Resources.bmi_healthy_icon;
                    BMIResultsLabel.Text = b.ToString();
                }
                else if (25 <= b && b < 30)
                {
                    ResultLabel.Text = "Избыточный";
                    BMIResultPictureBox.Location = new Point(1090, 680);
                    BMIResultsLabel.Location = new Point(1090, 650);
                    ResultPictureBox.Image = Properties.Resources.bmi_overweight_icon;
                    BMIResultsLabel.Text = b.ToString();
                }
                else if (b >= 30)
                {
                    ResultLabel.Text = "Ожирение";
                    BMIResultPictureBox.Location = new Point(1200,681);
                    BMIResultsLabel.Location = new Point(1200, 650);
                    ResultPictureBox.Image = Properties.Resources.bmi_obese_icon;
                    BMIResultsLabel.Text = b.ToString();
                }
                else
                {
                    MessageBox.Show("Ошибка в подсчёте");
                }
            }
            catch
            {
                MessageBox.Show("Ошибка в подсчёте");
            }
        }

        private void btn_cansel_Click(object sender, EventArgs e)
        {
            var form = new Find_Out_More_Information();
            form.Show();
            Hide();
        }

        private void MalePictureBox_Click(object sender, EventArgs e)
        {
            FemalePictureBox.BackColor = Color.White;
            MalePictureBox.BackColor = Color.Gray;
        }

        private void FemalePictureBox_Click(object sender, EventArgs e)
        {
            FemalePictureBox.BackColor = Color.Gray;
            MalePictureBox.BackColor = Color.White;
        }
    }
}
