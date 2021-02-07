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
    public partial class Edit_runner_profile : Form
    {
        string email = "";
        public Edit_runner_profile(string Email)
        {
            InitializeComponent();
            this.email = Email;
        }

        private void Edit_runner_profile_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Edit_runner_profile_Load(object sender, EventArgs e)
        {
            lb_email.Text = email;

            var conect = new SqlConnection(Properties.Resources.connection);
            try
            {
                conect.Open();

                var adapter = new SqlDataAdapter(Properties.Resources.sql_country, conect);
                var ds = new DataSet();
                adapter.Fill(ds);

                var arraycountry = new List<Country>();

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    var row = ds.Tables[0].Rows[i].ItemArray;
                    arraycountry.Add(new Country { CountryCode = row[0].ToString(), CountryFlag = row[2].ToString(), CountryName = row[1].ToString() });
                }

                tb_country.DataSource = arraycountry;
                tb_country.DisplayMember = "CountryName";
                tb_country.ValueMember = "CountryCode";

                adapter = new SqlDataAdapter($"select * from Runner where Email   = '{email}'", conect);
                ds = new DataSet();
                adapter.Fill(ds);

                var row1 = ds.Tables[0].Rows[0].ItemArray;

                tb_date.Value = DateTime.Parse(row1[3].ToString());
                cb_sex.SelectedItem = row1[2].ToString();
                tb_country.SelectedValue = row1[4].ToString();

                adapter = new SqlDataAdapter($"select * from dbo.[User] where [User].Email = '{email}'", conect);
                ds = new DataSet();
                adapter.Fill(ds);


                row1 = ds.Tables[0].Rows[0].ItemArray;

                var bt = row1[5] as byte[];

                if (bt != null)
                {
                    img_runner.Image = ByteArrayToImage(bt);
                }
                else
                {
                    img_runner.Image = Image.FromFile(Application.StartupPath.Replace("\\bin\\Debug", "") + "\\Resources\\unnamed.jpg");
                }

                tb_last.Text = row1[3].ToString();
                tb_name.Text = row1[2].ToString();


            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
            finally
            {
                conect.Close();
            }
            openFileDialog1.Filter = "*.bmp, *.jpg, *.png|*.bmp;*.jpg;*.png";
        }

        public Image ByteArrayToImage(byte[] bt)
        {
            using (var ms = new MemoryStream(bt))
            {
                Image image = Image.FromStream(ms);
                return image;

            }
        }

        private void btn_fail_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) //показываем диалог открытия
                tb_path_img.Text = openFileDialog1.FileName;
        }

        private void btn_registration_Click(object sender, EventArgs e)
        {
            
        }

        private void calnsel_Click(object sender, EventArgs e)
        {
            var form = new Runner_Menu(email);
            Hide();
            form.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            var form = new start_screen();
            Hide();
            form.Show();
        }
    }
}
