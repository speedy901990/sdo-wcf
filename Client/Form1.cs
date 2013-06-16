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
        Service1Client client = new Service1Client("wsHttpEndpoint");

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
            foreach (ListViewItem litem in listView1.Items)
            {
                listView1.Items.Remove(litem);
            }
            result = client.GetData(Int32.Parse(tbID.Text),false);
            if (result.Length == 0)
            {
                MessageBox.Show("Brak wyników", " ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                string[] ciach = System.Text.RegularExpressions.Regex.Split(result, "%%%");
                imageList1.Images.Add(Client.Properties.Resources.chase);
                var item1 = new ListViewItem(new[] { ciach[3], ciach[0], ciach[1], ciach[2], ciach[4] });
                item1.ImageIndex = 0;
                listView1.Items.Add(item1);

            }

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string err = client.AddNewStudentLame(nameTextBox.Text, surnameTextBox.Text, studentCheckBox.Checked, PeseltextBox.Text, emailTextBox.Text); 
            MessageBox.Show(err);
        }

        private void getByEmailButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem litem in listView1.Items)
            {
                listView1.Items.Remove(litem);
            }
            result = client.GetDataByEmail(tbEmail.Text);
            if (result.Length == 0)
            {
                MessageBox.Show("Brak wyników", " ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                string[] ciach = System.Text.RegularExpressions.Regex.Split(result, "%%%");
                imageList1.Images.Add(Client.Properties.Resources.chase);
                var item1 = new ListViewItem(new[] { ciach[3], ciach[0], ciach[1], ciach[2], ciach[4] });
                item1.ImageIndex = 0;
                listView1.Items.Add(item1);

            }
        }

        private void getBySurnameButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem litem in listView1.Items)
            {
                listView1.Items.Remove(litem);
            }
            result = client.GetDataBySurname(tbSurname.Text);
            if (result.Length == 0)
            {
                MessageBox.Show("Brak wyników", " ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                string[] ciach = System.Text.RegularExpressions.Regex.Split(result, "%%%");
                imageList1.Images.Add(Client.Properties.Resources.chase);
                var item1 = new ListViewItem(new[] { ciach[3], ciach[0], ciach[1], ciach[2], ciach[4] });
                item1.ImageIndex = 0;
                listView1.Items.Add(item1);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 0)
            {
                var selpsl = listView1.SelectedItems[0].Text;
                int ipesel = Convert.ToInt32(selpsl);
                string restmp1 = client.GetData(ipesel, true);
                string[] ciach = System.Text.RegularExpressions.Regex.Split(restmp1, "%%%");
                string msgcaption = "Czy na pewno usunąć zioma o PESELU " + ipesel + "?";
                DialogResult dr1 = MessageBox.Show(this, msgcaption, "  ",MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, 0);
                if (dr1 == System.Windows.Forms.DialogResult.Yes)
                {
                    MessageBox.Show(client.NukeStudent(Convert.ToInt32(ciach[5])));
                    foreach (ListViewItem litem in listView1.Items)
                    {
                        listView1.Items.Remove(litem);
                    }
                }
                
            }       
        }

        private void populateSurnamesButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem litem in listView1.Items)
            {
                listView1.Items.Remove(litem);
            }
            string[] rslt = client.GetEntriesByName(tbSurname.Text);
            int leng = rslt.Length;
            if (leng == 0)
                MessageBox.Show("Brak wyników.");
            foreach (string rsurname in rslt)
            {
                //MessageBox.Show(rsurname);
                string[] ciach = System.Text.RegularExpressions.Regex.Split(rsurname, "%%%");
                imageList1.Images.Add(Client.Properties.Resources.chase);
                var item1 = new ListViewItem(new[] { ciach[3], ciach[0], ciach[1], ciach[2], ciach[4] });
                item1.ImageIndex = 0;
                listView1.Items.Add(item1);
                
            }
            //result = client.GetEntriesByName(tbSurname.Text);

        }

        private void PeselButton_Click(object sender, EventArgs e)
        {
            int id;
            foreach (ListViewItem litem in listView1.Items)
            {
                listView1.Items.Remove(litem);
            }
            id = Int32.Parse(tbID.Text);
            result = client.GetData(id, true);
            int leng = result.Length;
            if (leng == 0)
            {
                MessageBox.Show("Brak wyników.");
            }
            else
            {
                {
                    string[] ciach = System.Text.RegularExpressions.Regex.Split(result, "%%%");
                    imageList1.Images.Add(Client.Properties.Resources.chase);
                    var item1 = new ListViewItem(new[] { ciach[3], ciach[0], ciach[1], ciach[2], ciach[4] });
                    item1.ImageIndex = 0;
                    listView1.Items.Add(item1);
                }
            }
            //MessageBox.Show(result);
        }
    }
}
