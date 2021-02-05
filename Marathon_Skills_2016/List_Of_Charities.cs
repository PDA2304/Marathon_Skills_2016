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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marathon_Skills_2016
{
    public partial class List_Of_Charities : Form
    {
        string connection = @"Data Source=DESKTOP-1CRVPTK\ISIP_D_A_PAHOMOV;Initial Catalog=MarathonSkills2016;Integrated Security=True";
        public List_Of_Charities()
        {
            InitializeComponent();
        }

        private void List_Of_Charities_Load(object sender, EventArgs e)
        {
            date_count.Start();
            var path_project = System.IO.Directory.GetParent(@"../").Parent.FullName + @"\Properties\img\charity_data";

            DirectoryInfo directory = new DirectoryInfo(path_project);

            var file = directory.GetFiles();

            foreach (var item in file)
            {
                imageList1.Images.Add(Image.FromFile(item.FullName));
            }

            var conect = new SqlConnection(connection);
            List<Charity> charity = new List<Charity>();
            try
            {
                conect.Open();

                string sql = "select * from Charity";
                var adapter = new SqlDataAdapter(sql, conect);
                var ds = new DataSet();
                adapter.Fill(ds);

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    var row = ds.Tables[0].Rows[i].ItemArray;
                    charity.Add(new Charity { name = row[1].ToString(), description = row[2].ToString(), logo = row[3].ToString() });
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

            List<Panel> list_panel = new List<Panel>();

            for (int i = 0; i < charity.Count; i++)
            {
                Panel panel = new Panel();
                panel.Size = new System.Drawing.Size(900, 205);
                panel.Location = new System.Drawing.Point(100, 0 + (i * 200));

                PictureBox picture = new PictureBox();
                picture.Size = new System.Drawing.Size(100, 100);
                picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                var it = imageList1.Images.IndexOfKey(charity[i].logo);
               // var it = imageList1.Images.IndexOfKey(charity[i].logo);
               picture.Image = imageList1.Images[i];
                //  Debug.WriteLine();

                Label label = new Label();
                label.Location = new System.Drawing.Point(120, 0);
                label.Text = charity[i].name;
                label.Size = new System.Drawing.Size(700, 35);
                label.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));


                TextBox label1 = new TextBox();
                label1.AllowDrop = true;
                label1.BackColor = System.Drawing.SystemColors.Window;
                label1.BorderStyle = System.Windows.Forms.BorderStyle.None;
                label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
                label1.Location = new System.Drawing.Point(120, 40);
                label1.Multiline = true;
                label1.ReadOnly = true;
                label1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
                label1.Size = new System.Drawing.Size(800, 150);
                label1.TabIndex = 53;
                label1.Text = charity[i].description;
                label1.Visible = true;

                panel.Controls.Add(label);
                panel.Controls.Add(label1);
                panel.Controls.Add(picture);
                list_panel.Add(panel);
            }
            foreach (var item in list_panel)
            {
                panel_list_blag_organozation.Controls.Add(item);
            }
        }


        private void date_count_Tick(object sender, EventArgs e)
        {
            var end_date = DateTime.Parse("21-10-2021");
            count_date.Text = $"{string.Format("{0:dd} дн. {0:hh} ч. {0:mm} м. {0:ss} сек.", end_date - DateTime.Now)} до старта марафона";
        }

        private void bt_cansel_Click(object sender, EventArgs e)
        {
            var form = new Find_Out_More_Information();
            form.Show();
            this.Hide();
        }

        private void List_Of_Charities_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }

    public class Charity
    {
        public string name { get; set; }
        public string description { get; set; }
        public string logo { get; set; }
    }
}
