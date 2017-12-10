using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;

namespace Ayuda_Remota
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IPHostEntry host;
            string localIP = "";
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    localIP = ip.ToString();
                }
            }            
            MessageBox.Show("Tú IP Local Es: " + localIP);
        }

        private void btnBuscarEquipo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1");
            Ayuda_Remota.NetworkBrowser nb = new Ayuda_Remota.NetworkBrowser();
            foreach (string pc in nb.getNetworkComputers())
            {
                MessageBox.Show("3");
                lstbPc.Items.Add(pc);
            }
            MessageBox.Show("2");
        }
    }
}
