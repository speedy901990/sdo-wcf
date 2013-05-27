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

        string result;

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str1 = client.TerriblyRetrieveDatabase();
            MessageBox.Show(str1);

        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            int id = 3;
            // O, proszę - tu jest bardzo ładne RMI. Prawda? :]
            result = client.GetData(id);

            textBox1.Text = result;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string a = client.AddNewStudentLame("Adam", "kkkkkk", true, "aaa@bbb.com");

            MessageBox.Show(a);
        }


    }
}
