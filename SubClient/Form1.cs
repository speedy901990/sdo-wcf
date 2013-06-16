using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubClient
{
    public partial class Form1 : Form
    {
        RemotingServiceReference1.RemotingDBClient clnt = new RemotingServiceReference1.RemotingDBClient();
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = clnt.MakeDatabasesSynced();
            MessageBox.Show(str);
        }
    }
}
