using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marathon_Skills_2016
{
    public partial class Runner_Sponsor_test : Form
    {
        string connection = @"Data Source=DESKTOP-1CRVPTK\ISIP_D_A_PAHOMOV;Initial Catalog=MarathonSkills2016;Integrated Security=True";
        public Runner_Sponsor_test()
        {
            InitializeComponent();
        }

        List<ComBox> arraylist = null;
        private void Runner_Sponsor_test_Load(object sender, EventArgs e)
        {


            tb_summa.Text = "0";
            summa.Text = $"${ tb_summa.Text}";

            date_cont.Start();

            var conect = new SqlConnection(connection);
            try
            {
                conect.Open();

                string sql = Properties.Resources.sql_select_Runner_Sponsor;
                var adapter = new SqlDataAdapter(sql, conect);
                var ds = new DataSet();
                adapter.Fill(ds);

                arraylist = new List<ComBox>();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    var row = ds.Tables[0].Rows[i].ItemArray;
                    arraylist.Add(new ComBox { name = row[1].ToString(), blag = row[2].ToString(), logo = row[3].ToString(), desription = row[4].ToString() , email = row[5].ToString() });
                }

                cb_runner.DataSource = arraylist;
                cb_runner.DisplayMember = "name";
                cb_runner.ValueMember = "blag";
              
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

        private void date_cont_Tick(object sender, EventArgs e)
        {
            var end_date = DateTime.Parse("21-10-2021");
            // count_date.Text = $"{string.Format("{0:dd} дн. {0:hh} ч. {0:mm} м. {0:ss} сек.", end_date - DateTime.Now)} до старта марафона";
        }

        private void Runner_Sponsor_test_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_cansel_Click(object sender, EventArgs e)
        {
            var form = new start_screen();
            form.Show();
            this.Hide();
        }

        private void btn_plus_summ_Click(object sender, EventArgs e)
        {
            summa_count = summa_count + 10;
            tb_summa.Text = summa_count.ToString();
            summa.Text = $"${  summa_count}";
        }
        public static int summa_count = 0;
        private void btn_minus_summ_Click(object sender, EventArgs e)
        {
            summa_count = summa_count - 10;
            if (summa_count >= 0)
            {
                tb_summa.Text = summa_count.ToString();
                summa.Text = $"${ summa_count }";
            }
            else
            {
                summa_count = summa_count + 10;
            }

        }

        private void tb_summa_TextChanged(object sender, EventArgs e)
        {

            if (tb_summa.Text.Length != 0)
            {
                if (!Regex.IsMatch(tb_summa.Text, @"[A-я]"))
                {
                    if (tb_summa.Text != "")
                    {
                        summa.Text = $"${tb_summa.Text}";
                        summa_count = Convert.ToInt32(summa.Text.Replace("$", ""));
                    }
                    else
                    {
                        summa.Text = $"${tb_summa.Text}";
                        summa_count = Convert.ToInt32("");
                    }
                }
                else
                {
                    tb_summa.Text = "0";
                }
            }
            else
            {
                tb_summa.Text = "0";
            }

        }

        private void btn_pay_Click(object sender, EventArgs e)
        {
            int year = 0;
            int month = 0;
            if (mstb_month.Text != "" && mstb_year.Text != "")
            {
                month = Convert.ToInt32(mstb_month.Text);
                year = Convert.ToInt32(mstb_year.Text);
            }

            bool month_prov = (month > 0 && month < 13);
            bool year_prov = (year >= DateTime.Now.Year);

            if (tb_name.Text != "" && tx_cart_name.Text != "" && mstb_nomer_cart.Text.Replace(" ", "").Length == 16 && month_prov && year_prov && mstb_cvc.Text != "" && summa_count != 0)
            {
                SaveDate_Sponsor_Runner.name_runner = cb_runner.SelectedItem.ToString();
                SaveDate_Sponsor_Runner.name_blag_organization = name_fond.Text;
                SaveDate_Sponsor_Runner.cost = Convert.ToInt32(tb_summa.Text);

                var conect = new SqlConnection(connection);
                try
                {
                    conect.Open();

                    string sql = Properties.Resources.sql_select_Runner_Sponsor;
                    var adapter = new SqlDataAdapter($"update Registration set  dbo.Registration.Cost = dbo.Registration.Cost + {tb_summa.Text} FROM dbo.Runner INNER JOIN dbo.Registration ON dbo.Runner.RunnerId = dbo.Registration.RunnerId WHERE(dbo.Runner.Email = N'{arraylist[cb_runner.SelectedIndex].email}')", conect);
                    var ds = new DataSet();
                    adapter.Fill(ds);

                }
                catch (Exception Error)
                {
                    MessageBox.Show(Error.Message);
                }
                finally
                {
                    conect.Close();
                }

                var form = new Sponsorship_Confirmation();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Не корректный данные");
            }

        }
        private void cb_runner_SelectedValueChanged(object sender, EventArgs e)
        {
            name_fond.Text = cb_runner.SelectedValue.ToString();
        }

        private void icon_information_Click(object sender, EventArgs e)
        {
            var index = cb_runner.SelectedIndex;

            var form = new Naimenovanie_sponsora(arraylist[index].blag, arraylist[index].desription, arraylist[index].logo);
            form.ShowDialog();


        }

        private void tb_summa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void userControl11_Load(object sender, EventArgs e)
        {
            userControl11.timer1.Start();
        }
    }

    public class ComBox
    {
        public string name { get; set; }
        public string blag { get; set; }
        public string logo { get; set; }
        public string desription { get; set; }
        public string email { get; set; }
    }
    public class SaveDate_Sponsor_Runner
    {
        public static string name_runner { get; set; }
        public static string name_blag_organization { get; set; }
        public static int cost { get; set; }
    }
}
