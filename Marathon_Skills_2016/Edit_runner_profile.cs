using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        byte[] bt = null;
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
                tb_password.Text = row1[1].ToString();
                tx_password2.Text = row1[1].ToString();
                bt = row1[5] as byte[];

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

            if (tb_name.Text != "" && tb_last.Text != "" && Password() && Date())
            {
                byte[] byte_img = null;
                if (tb_path_img.Text == "")
                {
                    byte_img = bt;
                }
                else
                {
                    byte_img = File.ReadAllBytes(tb_path_img.Text);
                }

                var conect = new SqlConnection(Properties.Resources.connection);
                try
                {


                    string SQL = $" update dbo.[User] set Password = N'{tb_password.Text}', FirstName = N'{tb_last.Text}', LastName = N'{tb_name.Text}', IMG = @img where  Email = N'{email}'";
                    string SQL1 = $"set language english update dbo.[Runner] set Gender = N'{cb_sex.SelectedItem}', DateOfBirth = CAST(N'{tb_date.Value.ToString("yyyy-MM-dd HH:mm:ss") + ".000"}' AS DateTime), CountryCode = N'{tb_country.SelectedValue}' where  Email = N'{email}'";

                    conect.Open();

                    var command = new SqlCommand(SQL, conect);
                    command.Parameters.Add(new SqlParameter("@img", byte_img));
                    command.ExecuteNonQuery();

                    command = new SqlCommand(SQL1, conect);
                    command.ExecuteNonQuery();

                    var form = new Runner_Menu(email);
                    Hide();
                    form.Show();
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message);
                }
                finally
                {
                    conect.Close();
                }
            }
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


        private void tb_name_Leave(object sender, EventArgs e)
        {
            if (((TextBox)sender).TextLength != 0)
                (sender as TextBox).Text = (sender as TextBox).Text[0].ToString().ToUpper() + (sender as TextBox).Text.Substring(1, (sender as TextBox).Text.Length - 1).ToLower();
        }


        private void tb_name_KeyPress(object sender, KeyPressEventArgs e)
        {

            string Symbol = e.KeyChar.ToString();

            if (!Regex.Match(Symbol, @"[а-яА-Я]|[a-zA-Z]").Success && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        Boolean Password()
        {
            if ((tb_password.Text.Contains("!") || tb_password.Text.Contains("@") || tb_password.Text.Contains("#") || tb_password.Text.Contains("$") || tb_password.Text.Contains("%") || tb_password.Text.Contains("^")) && tx_password2.Text == tb_password.Text && tb_password.Text.Length >= 6 && Regex.IsMatch(tb_password.Text, @"[0-9]") && Regex.IsMatch(tb_password.Text, @"[А-ЯA-Z]"))
            {
                return true;
            }
            return false;
        }
        Boolean Date()
        {
            var DateOfBirth = tb_date.Value.AddYears(10);
            var datenow = DateTime.Now;

            if (datenow >= DateOfBirth)
            {
                return true;
            }
            return false;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            img_runner.Image = Image.FromFile(openFileDialog1.FileName);
        }
    }
}
