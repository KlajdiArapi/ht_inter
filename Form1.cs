using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ht_inter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] WhiteList = new string[] { "%RPAKJD02D15Z100EARAPI  KLAJDI ?; 80380000800336247426 ? " };

        private void btnStart_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = cb_porta.SelectedItem.ToString();
            //serialPort2.PortName = cbPort2.SelectedItem.ToString();
            //cb_porta.Enabled = false;
            //cbPort2.Enabled = false;
            clearDati();
            try
            {
                serialPort1.Open();
                
            }
            catch
            {
                txtTesto.Text = "";
            }
        }
        private void sendGrant(string imp)
        {

            serialPort2.Open();

            if (WhiteList.Contains(imp))
            {
                serialPort2.WriteLine("Access Granted");
            }
            else
            {
                serialPort2.WriteLine("Accesso negato (la r è muta");
            }
            serialPort2.Close();
        }

        private void clearDati()
        {
            codiceFiscale.Text = "";
            cognomeTxt.Text = "";
            nomeTxt.Text = "";
        }
        private void dividiDati(string testo)
        {
            codiceFiscale.Text = testo.Substring(1, 16);

            int i = 17;
            while (testo[i].ToString() != " ")
            {
                cognomeTxt.Text += testo[i];
                i++;
            }
            nomeTxt.Text += testo.Split(' ')[2].Split('?')[0];
        }

        string recivedData="";
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            this.Invoke(new MethodInvoker(delegate ()
            {
                

                recivedData += serialPort1.ReadExisting();
                if (!(recivedData == ""))
                {
                    txtTesto.Text += recivedData;

                    dividiDati(recivedData);
                    sendGrant(recivedData);
                }
            }));
            
        }

        private void cb_porta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
