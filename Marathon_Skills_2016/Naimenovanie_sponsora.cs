using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marathon_Skills_2016
{
    public partial class Naimenovanie_sponsora : Form
    {
        private string name = "";
        private string descrip = "";
        private string log = "";


        public Naimenovanie_sponsora(string name, string description, string log)
        {
            InitializeComponent();
            this.name = name;
            this.descrip = description;
            this.log = log;
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Naimenovanie_sponsora_Load(object sender, EventArgs e)
        {
            var path_project = System.IO.Directory.GetParent(@"../").Parent.FullName + @"\Properties\img\charity_data";

            DirectoryInfo directory = new DirectoryInfo(path_project);

            var file = directory.GetFiles();

            foreach (var item in file)
            {
                if (item.Name == log)
                {
                    icon_log.Image = Image.FromFile(item.FullName);
                }
            }
            name_sponsor.Text = name;
            description.Text = descrip;
        }
    }
}
