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
    public partial class Manager_a_runner : Form
    {
        string Email = "";

        public Manager_a_runner(string Email)
        {
            InitializeComponent();
            this.Email = Email;
        }

        private void userControl11_Load(object sender, EventArgs e)
        {
            userControl11.timer1.Start();
        }

        private void Manager_a_runner_Load(object sender, EventArgs e)
        {
            var connect = new SqlConnection(Properties.Resources.connection);
            try
            {
                var addapter = new SqlDataAdapter(Properties.Resources.sql_manager_a_runner + $" WHERE (dbo.Runner.Email = N'{this.Email}')", connect);
                var ds = new DataSet();
                addapter.Fill(ds);

                email.Text = Email;

                name.Text = ds.Tables[0].Rows[0][1].ToString();
                familia.Text = ds.Tables[0].Rows[0][2].ToString();
                sex.Text = ds.Tables[0].Rows[0][3].ToString();
                data.Text = ds.Tables[0].Rows[0][4].ToString();
                strana.Text = ds.Tables[0].Rows[0][5].ToString();
                blag.Text = ds.Tables[0].Rows[0][6].ToString();
                pogert.Text = ds.Tables[0].Rows[0][7].ToString();
                paket.Text = ds.Tables[0].Rows[0][8].ToString();
                //  ds.Tables[0].Rows[0][9]
                //ds.Tables[0].Rows[0][10];
                if (ds.Tables[0].Rows[0][10].ToString() == "1")
                {
                    status1.Image = Properties.Resources.tick_icon;
                }
                if (ds.Tables[0].Rows[0][10].ToString() == "2")
                {
                    status1.Image = Properties.Resources.tick_icon;
                    status2.Image = Properties.Resources.tick_icon;
                }
                if (ds.Tables[0].Rows[0][10].ToString() == "3")
                {
                }
                if (ds.Tables[0].Rows[0][10].ToString() == "4")
                {
                    status1.Image = Properties.Resources.tick_icon;
                    status2.Image = Properties.Resources.tick_icon;
                    status3.Image = Properties.Resources.tick_icon;
                    status4.Image = Properties.Resources.tick_icon;
                }

                if (ds.Tables[0].Rows[0][9].ToString() != "")
                    pictureBox1.Image = ByteArrayToImage(ds.Tables[0].Rows[0][9] as byte[]);
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
            finally
            {

            }
        }

        public Image ByteArrayToImage(byte[] bt)
        {
            using (var ms = new MemoryStream(bt))
            {
                Image image = Image.FromStream(ms);
                return image;
            }
        }

        private void btn_cansel_Click(object sender, EventArgs e)
        {
            var form = new Runner_Menu(Email);
            form.Show();
            Hide();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            var form = new start_screen();
            form.Show();
            Hide();
        }
    }
}
