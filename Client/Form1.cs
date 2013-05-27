using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.ServiceReference1;

namespace Client
{
    public partial class Form1 : Form
    {
        Service1Client client = new Service1Client();

        String result;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = 4;
            // O, proszę - tu jest bardzo ładne RMI. Prawda? :]
            result = client.GetData(id);
            textBox1.Text = result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str1 = client.TerriblyRetrieveDatabase();
            MessageBox.Show(str1);

        }


    }
}
