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
    public partial class Sponsorship_overview : Form
    {
        public Sponsorship_overview()
        {
            InitializeComponent();
        }

        private void Sponsorship_overview_Load(object sender, EventArgs e)
        {
            var connection = new SqlConnection(Properties.Resources.connection);
            try
            {
                var adapter = new SqlDataAdapter("SELECT TOP (100) PERCENT CharityName, CharityLogo FROM dbo.Charity ORDER BY CharityName DESC", connection);
                var ds = new DataSet();
                adapter.Fill(ds);

                List<UserControl4> test = new List<UserControl4>();
                if (ds.Tables[0].Rows.Count != 0)
                {
                    var path_project = System.IO.Directory.GetParent(@"../").Parent.FullName + @"\Properties\img\charity_data";

                    DirectoryInfo directory = new DirectoryInfo(path_project);

                    var row = ds.Tables[0].Rows[1].ItemArray; ;
                    var file = directory.GetFiles();
                    blag_coun.Text = "Благотворительные организации: " + ds.Tables[0].Rows.Count.ToString();
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        row = ds.Tables[0].Rows[i].ItemArray;
                        var testus = new UserControl4();
                        testus.Dock = System.Windows.Forms.DockStyle.Top;
                        testus.Location = new System.Drawing.Point(0, 0);
                        testus.Name = $"userControl4{i}";
                        testus.Size = new System.Drawing.Size(1000, 150);
                        testus.label1.Text = row[0].ToString();
                        foreach (var item in file)
                        {
                            var img = row[1].ToString();
                            if (item.Name == img)
                            {
                                testus.pictureBox1.Image = Image.FromFile(item.FullName);
                            }
                        }
                        test.Add(testus);
                    }
                    adapter = new SqlDataAdapter(Properties.Resources.sql_amount_summ, connection);
                    ds = new DataSet();
                    adapter.Fill(ds);
                    var summ = 0;
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        var tes = ds.Tables[0].Rows[i].ItemArray;
                        test[i].label2.Text = tes[0].ToString();
                        summ += Convert.ToInt32(tes[0]);
                    }
                    label1.Text = "Всего спонсорских взносов: $" + summ.ToString();
                    foreach (var item in test)
                    {
                        panel2.Controls.Add(item);
                    }
                }




            }
            catch (Exception s)
            {
                MessageBox.Show(s.Message);
            }
            finally
            {
                connection.Open();
            }
        }

        private void Sponsorship_overview_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void userControl11_Load(object sender, EventArgs e)
        {
            userControl11.timer1.Start();
        }

        private void btn_cansel_Click(object sender, EventArgs e)
        {
            var form = new Coordinator_Menu();
            Hide();
            form.Show();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            var form = new start_screen();
            Hide();
            form.Show();
        }
    }

}