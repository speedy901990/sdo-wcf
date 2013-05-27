using sdo_wcf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serwer
{
    public partial class Form1 : Form
    {
        static Uri baseAddress = new Uri("http://localhost:8000/sdo-wcf/");

        ServiceHost selfHost = new ServiceHost(typeof(Service1), baseAddress);

        public Form1()
        {
            InitializeComponent();
            
            try
            {
                // Step 3 Add a service endpoint.
                selfHost.AddServiceEndpoint(typeof(IService1), new WSHttpBinding(), "CalculatorService");

                // Step 4 Enable metadata exchange.
                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                selfHost.Description.Behaviors.Add(smb);

                // Step 5 Start the service.
                selfHost.Open();    

            }
            catch (CommunicationException ce)
            {
                Console.WriteLine("An exception occurred: {0}", ce.Message);
                selfHost.Abort();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selfHost.Close();

            this.Close();
        }

        
    }
}
