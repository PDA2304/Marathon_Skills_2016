using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marathon_Skills_2016
{
    public partial class Register_as_a_runner : Form
    {
        public Register_as_a_runner()
        {
            InitializeComponent();
        }

        private void userControl11_Load(object sender, EventArgs e)
        {
            userControl11.timer1.Start();
        }

        private void btn_cansel_Click(object sender, EventArgs e)
        {
            var form = new start_screen();
            form.Show();
            this.Visible = false;
        }

        private void Register_as_a_runner_Load(object sender, EventArgs e)
        {

            cb_sex.SelectedIndex = 1;
            openFileDialog1.Filter = "*.bmp, *.jpg, *.png|*.bmp;*.jpg;*.png";

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

            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
            finally
            {
                conect.Close();
            }


        }

        public Image ByteArrayToImage(byte[] bt)
        {
            using (var ms = new MemoryStream(bt))
            {
                Image image = Image.FromStream(ms);
                return image;

            }

            // -- Добавление картикни в БД и чтение картинки из бд
            //// var data = File.ReadAllBytes(@"C:\Users\isip_\source\repos\Marathon_Skills_2016\Marathon_Skills_2016\Properties\img\charity_data\aves-do-brazil-logo.png");

            // //var FS = new FileStream(@"C:\Users\isip_\source\repos\Marathon_Skills_2016\Marathon_Skills_2016\Properties\img\charity_data\aves-do-brazil-logo.png", FileMode.Open, FileAccess.Read);
            // //var br = new BinaryReader(FS);
            // // var img = br.ReadBytes((int)FS.Length);

            // string sql = "insert INTO test(IMG) values(@img)";
            // var conect = new SqlConnection(connection);
            // try
            // {
            //     conect.Open();
            //     //  var command = new SqlCommand(sql, conect);
            //     var adapter = new SqlDataAdapter("select * from test", conect);
            //     var ds = new DataSet();
            //     adapter.Fill(ds);
            //     var row = ds.Tables[0].Rows[1].ItemArray;
            //     var bt = row[0] as byte[];
            //     //command.Parameters.Add(new SqlParameter("@img", img));
            //     //command.ExecuteNonQuery();
            //     img_runner.Image = ByteArrayToImage(bt);
            // }
            // catch (Exception ee)
            // {
            //     MessageBox.Show(ee.Message);
            // }
            // finally
            // {
            //     conect.Close();
            // }




        }

        private void btn_fail_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) //показываем диалог открытия
                tb_path_img.Text = openFileDialog1.FileName;
        }

        private void tb_name_Leave(object sender, EventArgs e)
        {
            if (((TextBox)sender).TextLength != 0)
                (sender as TextBox).Text = (sender as TextBox).Text[0].ToString().ToUpper() + (sender as TextBox).Text.Substring(1, (sender as TextBox).Text.Length - 1).ToLower();
        }

        private void tb_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_name_KeyPress(object sender, KeyPressEventArgs e)
        {

            string Symbol = e.KeyChar.ToString();

            if (!Regex.Match(Symbol, @"[а-яА-Я]|[a-zA-Z]").Success && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void tb_email_Leave(object sender, EventArgs e)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(tb_email.Text);
            }
            catch
            {
                tb_email.Text = "";
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            img_runner.Image = Image.FromFile(openFileDialog1.FileName);
        }

        Boolean Password()
        {
            Debug.WriteLine(tb_password.Text.Contains("!"));
            Debug.WriteLine(tb_password.Text.Contains("@"));
            Debug.WriteLine(tb_password.Text.Contains("#"));
            Debug.WriteLine(tb_password.Text.Contains("$"));
            Debug.WriteLine(tb_password.Text.Contains("%"));
            Debug.WriteLine(tb_password.Text.Contains("^"));
            Debug.WriteLine(tx_password2 == tb_password);
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

        private void btn_registration_Click(object sender, EventArgs e)
        {
            var path_img = "";
            if (tb_path_img.Text == "")
            {
                path_img = Application.StartupPath.Replace("\\bin\\Debug", "") + "\\Resources\\unnamed.jpg";
            }
            else
            {
                path_img = openFileDialog1.FileName;
            }

            if (tb_name.Text != "" && tb_last.Text != "" && Password() && Date() && tb_email.Text != "")
            {
                string SQL1 = $"set language english insert Runner (Email,Gender,DateOfBirth,CountryCode)  values(N'{tb_email.Text}',N'{cb_sex.SelectedItem}',CAST(N'{tb_date.Value.ToString("yyyy-MM-dd HH:mm:ss") + ".000"}' AS DateTime),N'{tb_country.SelectedValue}')";
                string SQL = $"insert [User] values(N'{tb_email.Text}',N'{tb_password.Text}',N'{tb_name.Text}',N'{tb_last.Text}',N'R',@img)";
                var img_byte = File.ReadAllBytes(path_img);
                var conect = new SqlConnection(Properties.Resources.connection);
                try
                {
                    conect.Open();
                    var command = new SqlCommand(SQL, conect);
                    ////     var adapter = new SqlDataAdapter("select * from test", conect);
                    ////     var ds = new DataSet();
                    ////     adapter.Fill(ds);
                    ////     var row = ds.Tables[0].Rows[1].ItemArray;
                    ////     var bt = row[0] as byte[];
                    command.Parameters.Add(new SqlParameter("@img", img_byte));
                    command.ExecuteNonQuery();
                    //     img_runner.Image = ByteArrayToImage(bt);
                    command = new SqlCommand(SQL1, conect);
                    command.ExecuteNonQuery();
                    Hide();
                    var form = new Register_for_an_event();
                    form.Show();
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }
                finally
                {
                    conect.Close();
                }
                path_img = "";
            }
        }

        private void Register_as_a_runner_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }

    public class Country
    {
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
        public string CountryFlag { get; set; }
    }
}
