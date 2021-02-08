using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marathon_Skills_2016
{
    public partial class My_race_results : Form
    {
        private string email = "";
        public My_race_results(string Email)
        {
            InitializeComponent();
            email = Email;
        }

        private void My_race_results_Load(object sender, EventArgs e)
        {
            var conect = new SqlConnection(Properties.Resources.connection);

            try
            {
                conect.Open();
                var adapter = new SqlDataAdapter(Properties.Resources.sql_my_results + $" WHERE(dbo.[User].Email = N'{email}')", conect);
                var ds = new DataSet();
                adapter.Fill(ds);


                List<UserControl2> test = new List<UserControl2>();
                if (ds.Tables[0].Rows.Count != 0)
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        var row = ds.Tables[0].Rows[i].ItemArray;
                        var testus = new UserControl2();
                        testus.Dock = System.Windows.Forms.DockStyle.Top;
                        testus.Location = new System.Drawing.Point(0, 0);
                        testus.Name = $"userControl2{i}";
                        testus.Size = new System.Drawing.Size(1400, 70);
                        testus.label1.Text = row[0].ToString();
                        testus.label2.Text = row[1].ToString();
                        testus.label4.Text = row[2].ToString();
                        testus.label3.Text = "#123";
                        label2.Text = $"Пол: { row[3]}";
                        test.Add(testus);
                    }

                    foreach (var item in test)
                    {
                        panel2.Controls.Add(item);

                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conect.Close();
            }

            //
        }

        private void userControl11_Load(object sender, EventArgs e)
        {
            userControl11.timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new Previous_race_results();
            form.Show();
            Hide();
        }

        private void btn_cansel_Click(object sender, EventArgs e)
        {
            var form = new Runner_Menu(email);
            form.Show();
            Hide();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            var form = new start_screen();
            form.Show();
            Hide();
        }

        private void My_race_results_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
