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
    public partial class Login : Form
    {
        string connection = @"Data Source=DESKTOP-1CRVPTK\ISIP_D_A_PAHOMOV;Initial Catalog=MarathonSkills2016;Integrated Security=True";
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            var conect = new SqlConnection(connection);
            try
            {
                conect.Open();

                string sql = $"select [User].Email,[User].Password,[User].RoleId from [User] where ([User].Email = '{tb_email.Text}' )";
                var adapter = new SqlDataAdapter(sql, conect);
                var ds = new DataSet();
                adapter.Fill(ds);
                var row = ds.Tables[0].Rows[0].ItemArray;

                if (tb_password.Text == row[1].ToString())
                {
                    if (row[2].ToString() == "R")
                    {
                        var form = new Runner_Menu();
                        form.Show();
                        this.Close();
                    }
                    if (row[2].ToString() == "A")
                    {
                        var form = new Coordinator_Menu();
                        form.Show();
                        this.Close();
                    }
                    if (row[2].ToString() == "C")
                    {
                        var form = new Administrator_Menu();
                        form.Show();
                        this.Hide();
                    }
                }

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

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_cansel_Click(object sender, EventArgs e)
        {
            var form = new start_screen();
            form.Show();
            this.Hide();
        }


        private void userControl11_Load(object sender, EventArgs e)
        {
            userControl11.timer1.Start();
        }
    }
}
