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
        InternalServiceReference1.InternalServicesClient client = new InternalServiceReference1.InternalServicesClient();

        string result;

        public Form1(){
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = clnt.MakeDatabasesSynced();
            MessageBox.Show(str);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void getByIDButton_Click(object sender, EventArgs e)
        {
            result = client.GetData(Int32.Parse(tbID.Text), false);
            if (result.Length == 0)
                MessageBox.Show("Brak wyników", " ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            else
            {
                string[] ciach = System.Text.RegularExpressions.Regex.Split(result, "%%%");
                //imageList1.Images.Add(Client.Properties.Resources.chase);
               // var item1 = new ListViewItem(new[] { ciach[3], ciach[0], ciach[1], ciach[2], ciach[4] });
                //item1.ImageIndex = 0;
                //listView1.Items.Add(item1);
                tbSurnameSet.Text = ciach[1];
                tbName.Text = ciach[0];
                tbPeselSet.Text = ciach[3];
                tbEmailSet.Text = ciach[2];
                studentCheckBox.Checked = bool.Parse(ciach[4]);
            }
        }

        private void PeselButton_Click(object sender, EventArgs e)
        {

        }

        private void getByEmailButton_Click(object sender, EventArgs e)
        {

        }

        private void getBySurnameButton_Click(object sender, EventArgs e)
        {

        }

        private void populateSurnamesButton_Click(object sender, EventArgs e)
        {

        }
    }
}
