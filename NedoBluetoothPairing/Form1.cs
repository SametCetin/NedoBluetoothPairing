using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
namespace NedoBluetoothPairing
{
    public partial class Form1 : Form
    {

        SerialPort serialPort;
        bool connOk = false;
        bool Exit = false;
        int DelayTime = 400;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Exit = true;
            if (serialPort != null && serialPort.IsOpen)
                serialPort.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Height = 260;
            this.Text = Application.ProductName + " | " + Application.ProductVersion;
            
            SearchPorts();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            SearchPorts();
        }

        private void SearchPorts()
        {
            cbxSerialPorts.Items.Clear();

            string[] ports = SerialPort.GetPortNames();
            var portName = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                cbxSerialPorts.Items.Add(port);
            }
            cbxSerialPorts.SelectedIndex = cbxSerialPorts.Items.Count - 1;
        }

        private void btnSearchDevice_Click(object sender, EventArgs e)
        {
            pnlPairing.Enabled = false;
            btnInitValues.Enabled = false;
            btnSearchDevice.Enabled = false;

            lbxFoundedItems.Items.Clear();

            serialPort = new SerialPort();
            if (string.IsNullOrEmpty(cbxSerialPorts.Text))
            {
                MessageBox.Show("Select port");
                return;
            }

            if (!serialPort.IsOpen)
                connOk = ConnectToPort();

            if (connOk)
            {
                SearchDevices();
                serialPort.Close();
            }
            pnlPairing.Enabled = true;
            btnInitValues.Enabled = true;
            btnSearchDevice.Enabled = true;
        }

        private bool ConnectToPort()
        {
            try
            {
                serialPort.PortName = cbxSerialPorts.Text;
                serialPort.BaudRate = 9600;
                serialPort.Parity = Parity.None;
                serialPort.DataBits = 8;
                serialPort.StopBits = StopBits.One;
                serialPort.Handshake = Handshake.None;
                serialPort.ReadTimeout = 80;
                serialPort.WriteTimeout = 80;

                serialPort.Open();

                return true;
            }
            catch
            {
                return false;
            }
        }

        private void SearchDevices()
        {
            string readVal = "1";
            bool cr = false;
            bool lf = false;
            char byteData;
            string strData = "";

            lblSearchStatus.Text = "Searching...";

            serialPort.WriteLine("AT");
            System.Threading.Thread.Sleep(DelayTime);
            serialPort.WriteLine("AT");
            System.Threading.Thread.Sleep(DelayTime);
            serialPort.WriteLine("AT");
            System.Threading.Thread.Sleep(DelayTime);

            serialPort.WriteLine("ROLE=M");
            System.Threading.Thread.Sleep(DelayTime);
            serialPort.WriteLine("SEARCH=?");

            while (!readVal.Contains("Device(s) Found") && !Exit)
            {
                while (!(cr || lf) & !Exit)
                {
                    try
                    {
                        byteData = (char)serialPort.ReadChar();
                    }
                    catch
                    {
                        byteData = '-';
                    }

                    if (byteData == '\r')
                        cr = true;
                    else if (byteData == '\n')
                        lf = true;
                    else
                        if (byteData != '-')
                            strData = strData + byteData.ToString();

                    Application.DoEvents();
                }

                readVal = strData;
                if (!string.IsNullOrEmpty(readVal))
                    lbxFoundedItems.Items.Add(readVal);
                Application.DoEvents();
                strData = "";
                cr = false; lf = false;

                Application.DoEvents();
            }
            lblSearchStatus.Text = "Search finished.";
        }

        private void WaitMs(int ms)
        {
            for (int i =0;i<ms/10; i++)
            {
                System.Threading.Thread.Sleep(10);
                Application.DoEvents();
            }
        }

        private void lbxFoundedItems_Click(object sender, EventArgs e)
        {
            string MaccAddr = "";

            if (lbxFoundedItems.SelectedIndex > -1)
                MaccAddr = lbxFoundedItems.SelectedItem.ToString();
            txtPairingMacAddr.Text = MaccAddr;
        }

        private void lbxFoundedItems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPair_Click(object sender, EventArgs e)
        {
            pnlSearch.Enabled = false;
            btnInitValues.Enabled = false;

            string maccAddr = txtPairingMacAddr.Text;
            maccAddr = maccAddr.Replace(" ", "");
            if (maccAddr.Length != 12)
            {
                MessageBox.Show("Unknown address selected !");
                return;
            }              

            serialPort = new SerialPort();
            if (string.IsNullOrEmpty(cbxSerialPorts.Text))
            {
                MessageBox.Show("Select port");
                return;
            }

            if (!serialPort.IsOpen)
                connOk = ConnectToPort();

            if (connOk)
            {
                PairDevices(maccAddr);
                serialPort.Close();
            }

            pnlSearch.Enabled = true;
            btnInitValues.Enabled = true;

        }

        private void PairDevices(string maccAddr)
        {
            lblPairingStatus.Text = "Pairing...";

            serialPort.WriteLine("AT");
            System.Threading.Thread.Sleep(DelayTime);
            serialPort.WriteLine("AT");
            System.Threading.Thread.Sleep(DelayTime);
            serialPort.WriteLine("AT");
            System.Threading.Thread.Sleep(DelayTime);

            serialPort.WriteLine("ROLE=M");
            System.Threading.Thread.Sleep(DelayTime);
            serialPort.WriteLine("PIN=0000");
            System.Threading.Thread.Sleep(DelayTime);
            serialPort.WriteLine("ECHO=N");
            System.Threading.Thread.Sleep(DelayTime);
            serialPort.WriteLine("PROMPT=N");
            System.Threading.Thread.Sleep(DelayTime);
            serialPort.WriteLine("DISCOVER=N");
            System.Threading.Thread.Sleep(DelayTime);
            serialPort.WriteLine("DEVICE=" + maccAddr);
            System.Threading.Thread.Sleep(DelayTime);
            serialPort.WriteLine("RECONNECT=Y");
            System.Threading.Thread.Sleep(DelayTime);
            serialPort.WriteLine("CONNECT=DEVICE");
            System.Threading.Thread.Sleep(DelayTime);

            lblPairingStatus.Text = "Pairing finished";

        }

        private void btnInitValues_Click(object sender, EventArgs e)
        {
            pnlSearch.Enabled = false;
            pnlPairing.Enabled = false;

            serialPort = new SerialPort();
            if (string.IsNullOrEmpty(cbxSerialPorts.Text))
            {
                MessageBox.Show("Select port");
                return;
            }

            if (!serialPort.IsOpen)
                connOk = ConnectToPort();

            if (connOk)
            {
                LoadInitValues();
                serialPort.Close();
            }

            pnlSearch.Enabled = true;
            pnlPairing.Enabled = true;

        }

        private void LoadInitValues()
        {
            serialPort.WriteLine("AT");
            System.Threading.Thread.Sleep(DelayTime);
            serialPort.WriteLine("AT");
            System.Threading.Thread.Sleep(DelayTime);
            serialPort.WriteLine("AT");
            System.Threading.Thread.Sleep(DelayTime);

            serialPort.WriteLine("ROLE=M");
            System.Threading.Thread.Sleep(DelayTime);
            serialPort.WriteLine("PIN=0000");
            System.Threading.Thread.Sleep(DelayTime);
            serialPort.WriteLine("ECHO=Y");
            System.Threading.Thread.Sleep(DelayTime);
            serialPort.WriteLine("PROMPT=Y");
            System.Threading.Thread.Sleep(DelayTime);
            serialPort.WriteLine("DEVICE=xxxxxxxxxxxx");    //12 adet 0
            System.Threading.Thread.Sleep(DelayTime);
            serialPort.WriteLine("RECONNECT=N");
            System.Threading.Thread.Sleep(DelayTime);
            serialPort.WriteLine("DISCOVER=N");
            System.Threading.Thread.Sleep(DelayTime);
            serialPort.WriteLine("PROMPT=Y");
            System.Threading.Thread.Sleep(DelayTime);
            MessageBox.Show("Init values loaded.");
        }

        private void btnTerminal_Click(object sender, EventArgs e)
        {
            //if (btnTerminal.Text == ">>>")
            //{
            //    this.Height = 450;
            //    btnTerminal.Text = "<<<";
            //}
            //else
            //{
            //    this.Height = 260;
            //    btnTerminal.Text = ">>>";
            //}
        }

    }
}
