using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marathon_Skills_2016
{
    public partial class Previous_race_results : Form
    {
        public Previous_race_results()
        {
            InitializeComponent();
        }

        private void userControl11_Load(object sender, EventArgs e)
        {
            userControl11.timer1.Start();
        }

        private void Previous_race_results_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_cansel_Click(object sender, EventArgs e)
        {
            var form = new Find_Out_More_Information();
            form.Show();
            Hide();
        }

        private void Previous_race_results_Load(object sender, EventArgs e)
        {
            List<ComboBox_sourse> ComboBox_sourses = new List<ComboBox_sourse>()
            {
                new ComboBox_sourse { EventTypeID = "FM", EventTypeName = "Ful Marathon" },
                new ComboBox_sourse { EventTypeID = "FR", EventTypeName = "5km Fun Run" },
                new ComboBox_sourse { EventTypeID = "HM", EventTypeName = "Half Marathon" }
            };

            distantion.DataSource = ComboBox_sourses;
            distantion.DisplayMember = "EventTypeName";
            distantion.ValueMember = "EventTypeID";

            ComboBox_sourses = new List<ComboBox_sourse>()
            {
                 new ComboBox_sourse { EventTypeID = "2011", EventTypeName = "Marathon Skills 2011" },
                 new ComboBox_sourse { EventTypeID = "2012", EventTypeName = "Marathon Skills 2012" },
                 new ComboBox_sourse { EventTypeID = "2013", EventTypeName = "Marathon Skills 2013" },
                 new ComboBox_sourse { EventTypeID = "2014", EventTypeName = "Marathon Skills 2014" },
                 new ComboBox_sourse { EventTypeID = "2015", EventTypeName = "Marathon Skills 2015" }
            };
            marafon.DataSource = ComboBox_sourses;
            marafon.DisplayMember = "EventTypeName";
            marafon.ValueMember = "EventTypeID";


        }

        private void filter_Click(object sender, EventArgs e)
        {
            var conect = new SqlConnection(Properties.Resources.connection);
            try
            {
                conect.Open();
                var adapter = new SqlDataAdapter(Properties.Resources.sql_results + $" WHERE        (Event_1.EventTypeId = N'{distantion.SelectedValue}') AND (Marathon_1.YearHeld = {marafon.SelectedValue})ORDER BY dbo.RegistrationEvent.RaceTime", conect);
                var ds = new DataSet();
                adapter.Fill(ds);

                results.DataSource = ds.Tables[0];
                count_start.Text = $"Всего бегунов:{ds.Tables[0].Rows.Count}";

                var count = 0;
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                { var row = ds.Tables[0].Rows[i].ItemArray;
                    if (row[0].ToString()!="")
                    {
                        count++;
                    }
                }
                count_finish.Text = $"Всего финишировало:{count}";
            }
            catch (Exception mess)
            {
                MessageBox.Show(mess.Message);
            }
            finally
            {
                conect.Close();
            }

        }
    }

    class ComboBox_sourse
    {
        public string EventTypeID { get; set; }
        public string EventTypeName { get; set; }
    }
}
