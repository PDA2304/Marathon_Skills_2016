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
    public partial class Runner_management : Form
    {
        public Runner_management()
        {
            InitializeComponent();
        }

        private void userControl11_Load(object sender, EventArgs e)
        {
            userControl11.timer1.Start();
        }

        SqlConnection connect = new SqlConnection(Properties.Resources.connection);
        private void Runner_management_Load(object sender, EventArgs e)
        {
            marafon.SelectedIndex = 0;

            try
            {
                connect.Open();
                var adapter = new SqlDataAdapter(Properties.Resources.sql_edit_runn, connect);
                var ds = new DataSet();
                adapter.Fill(ds);

                results.DataSource = ds.Tables[0];

            }
            catch (Exception)
            {
            }
            finally
            {
                connect.Close();
            }
        }

        private void filter_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
            var adapter = new SqlDataAdapter(Properties.Resources.sql_edit_runn + $" WHERE        (dbo.RegistrationStatus.RegistrationStatus = N'{marafon.SelectedItem}')", connect);
            var ds = new DataSet();
            adapter.Fill(ds);
                results.AutoGenerateColumns = true;
            results.DataSource =  ds.Tables[0];
            }
            catch (Exception)
            {
            }
            finally
            {
                connect.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void results_SelectionChanged(object sender, EventArgs e)
        {
        
        }

        private void results_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                MessageBox.Show(e.RowIndex.ToString() + results.Rows[e.RowIndex].Cells[3].Value.ToString());
                var form = new Manager_a_runner(results.Rows[e.RowIndex].Cells[3].Value.ToString());
                Hide();
                form.Show();
            }
            
        }

        private void btn_cansel_Click(object sender, EventArgs e)
        {
            Hide();
            var form = new Coordinator_Menu();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            var form = new start_screen();
            form.Show();
        }
    }
}
