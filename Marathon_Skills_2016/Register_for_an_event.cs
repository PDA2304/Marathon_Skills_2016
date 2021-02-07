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
    public partial class Register_for_an_event : Form
    {
        public Register_for_an_event()
        {
            InitializeComponent();
        }
        List<ComBox> arraylist = null;

        private void userControl11_Load(object sender, EventArgs e)
        {
            userControl11.timer1.Start();


            var conect = new SqlConnection(Properties.Resources.connection);
            try
            {
                conect.Open();

                string sql = "select * from [Charity]";
                var adapter = new SqlDataAdapter(sql, conect);
                var ds = new DataSet();
                adapter.Fill(ds);

                arraylist = new List<ComBox>();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    var row = ds.Tables[0].Rows[i].ItemArray;
                    arraylist.Add(new ComBox { name = row[1].ToString(), blag = row[0].ToString(), logo = row[3].ToString(), desription = row[2].ToString() });
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

        private void btn_cansel_Click(object sender, EventArgs e)
        {
            Hide();
            var form = new Runner_Menu();
            form.Show();
        }

        private void Register_for_an_event_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Hide();
            var form = new start_screen();
            form.Show();
        }

        int vznos = 0;
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            var test = sender.GetType().Name;
            if (test == "CheckBox")
            {
                if (((CheckBox)sender).Checked == true)
                {
                    vznos += Convert.ToInt32(((CheckBox)sender).Tag);
                    Reg_vznos.Text = $"${vznos}";
                }
                else
                {
                    vznos -= Convert.ToInt32(((CheckBox)sender).Tag);
                    Reg_vznos.Text = $"${vznos}";
                }
            }
            else
            {
                if (((RadioButton)sender).Checked == true)
                {
                    vznos += Convert.ToInt32(((RadioButton)sender).Tag);
                    Reg_vznos.Text = $"${vznos}";
                }
                else
                {
                    vznos -= Convert.ToInt32(((RadioButton)sender).Tag);
                    Reg_vznos.Text = $"${vznos}";
                }
            }
        }

        private void icon_information_Click(object sender, EventArgs e)
        {
            var index = cb_runner.SelectedIndex;

            var form = new Naimenovanie_sponsora(arraylist[index].name, arraylist[index].desription, arraylist[index].logo);
            form.ShowDialog();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
                if ((checkBox1.Checked == true || checkBox2.Checked == true || checkBox3.Checked == true) && Convert.ToInt32(textBox1.Text) >= vznos)
                {
                }
                else
                {
                }
        }
    }
}
