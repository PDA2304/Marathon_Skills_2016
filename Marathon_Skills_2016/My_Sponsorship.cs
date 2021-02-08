using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marathon_Skills_2016
{
    public partial class My_Sponsorship : Form
    {
        private string email = "";
        public My_Sponsorship(string Email)
        {
            InitializeComponent();
            email = Email;
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            var fomr = new start_screen();
            fomr.Show();
            Hide();
        }

        private void btn_cansel_Click(object sender, EventArgs e)
        {
            var fomr = new Runner_Menu(email);
            fomr.Show();
            Hide();
        }

        private void My_Sponsorship_Load(object sender, EventArgs e)
        {
            var connect = new SqlConnection(Properties.Resources.connection);
            try
            {
                connect.Open();
                var adapter = new SqlDataAdapter(Properties.Resources.sql_sponsor_runner + $" WHERE (dbo.Runner.Email = N'{email}')", connect);
                var ds = new DataSet();
                adapter.Fill(ds);

                List<UserControl3> test = new List<UserControl3>();
                if (ds.Tables[0].Rows.Count != 0)
                {
                    var summ = 0;
                    var path_project = System.IO.Directory.GetParent(@"../").Parent.FullName + @"\Properties\img\charity_data";

                    DirectoryInfo directory = new DirectoryInfo(path_project);

                    var row = ds.Tables[0].Rows[1].ItemArray; ;
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        row = ds.Tables[0].Rows[i].ItemArray;
                        var testus = new UserControl3();
                        testus.Dock = System.Windows.Forms.DockStyle.Top;
                        testus.Location = new System.Drawing.Point(0, 0);
                        testus.Name = $"userControl3{i}";
                        testus.Size = new System.Drawing.Size(463, 30);
                        testus.label1.Text = row[3].ToString();
                        testus.label2.Text = row[4].ToString();
                        description.Text = row[1].ToString();
                        blag.Text = row[0].ToString();

                        summ += Convert.ToInt32(row[4]);
                        test.Add(testus);
                    }
                    var file = directory.GetFiles();

                    foreach (var item in file)
                    {
                        var img = ds.Tables[0].Rows[0][2].ToString();
                        if (item.Name == img )
                        {
                            pictureBox1.Image = Image.FromFile(item.FullName);
                        }
                    }
                    summa.Text = $"Всего: $ {summ}";
                    foreach (var item in test)
                    {
                        panel2.Controls.Add(item);
                    }
                }

            }
            catch (Exception)
            {



            }
            finally
            {
                connect.Close();
            }
        }

        private void userControl11_Load(object sender, EventArgs e)
        {
            userControl11.timer1.Start();
        }

        private void My_Sponsorship_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
