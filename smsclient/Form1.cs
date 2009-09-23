using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;
using Microsoft.WindowsMobile.PocketOutlook;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using barbardata;
namespace smsclient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textIP.Text = "169.254.2.1";
            buttonBaglantiKes.Enabled = false;
            this.FormClosed += new FormClosedEventHandler(Form1_FormClosed);
        }

        void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                if (client.Connected)
                { baglantiKes(); }
            }
            catch { }
        }
        //private static TextBox newText;

        public delegate void DoChangeUILabel(string theText);

        public void DoChangeUILabelMethod(string theText)
        {
            if (this.listDurum.InvokeRequired)
            {
                DoChangeUILabel theDelegate = new DoChangeUILabel(DoChangeUILabelMethod);
                this.Invoke(theDelegate, new object[] { theText });
            }
            else
            {
                this.listDurum.Items.Add(theText);
            }
        }

        public delegate void DoChangeUIButton(Button buton, bool durum);

        public void DoChangeUIButtonMethod(Button buton, bool durum)
        {
            if (buton.InvokeRequired)
            {
                DoChangeUIButton theDelegate = new DoChangeUIButton(DoChangeUIButtonMethod);
                this.Invoke(theDelegate, new object[] { buton, durum });
            }
            else
            {
                buton.Enabled = durum;
            }
        }

        private static Socket client;
        private static byte[] data = new byte[1024];

        private void buttonBaglan_Click(object sender, EventArgs e)
        {
            DoChangeUILabelMethod("Bağlanıyor...");
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint iep = new IPEndPoint(IPAddress.Parse(textIP.Text), 900);
            client.BeginConnect(iep, new AsyncCallback(Connected), client);
        }

        private void mesajGonder(string kime, string mesaj)
        {
            SmsSeri yeniSms = new SmsSeri();
            string[] liste = kime.Replace(',', ';').Split(';');
            foreach (string x in liste)
            {
                yeniSms.AddRecipient(x);
            }
            yeniSms.Message = mesaj;
            //string gidecekVeri = "Sms To:" + kime + "|Mesaj:" + mesaj + "";
            byte[] message = Serialize.Object2ByteArray(yeniSms,typeof(SmsSeri));
            client.BeginSend(message, 0, message.Length, 0, new AsyncCallback(SendData), client);
        }

        void Connected(IAsyncResult iar)
        {
            try
            {
                client.EndConnect(iar);
                DoChangeUILabelMethod("Bağlanılan: " + client.RemoteEndPoint.ToString());
                Thread receiver = new Thread(new ThreadStart(ReceiveData));
                receiver.Start();
                DoChangeUIButtonMethod(buttonBaglan, false);
                DoChangeUIButtonMethod(buttonBaglantiKes, true);
            }
            catch (SocketException)
            {
                DoChangeUILabelMethod("Bağlantı hatası!");
            }
        }

        void SendData(IAsyncResult iar)
        {
            Socket remote = (Socket)iar.AsyncState;
            int sent = remote.EndSend(iar);
        }

        void ReceiveData()
        {
            int recv;
            string stringData;
            while (true)
            {
                recv = client.Receive(data);
                stringData = Encoding.UTF8.GetString(data, 0, recv);
                if (stringData == "bye")
                    break;
                DoChangeUILabelMethod(stringData);
            }
            stringData = "bye";
            byte[] message = Encoding.UTF8.GetBytes(stringData);
            client.Send(message);
            client.Close();
            DoChangeUILabelMethod("Bağlantı durduruldu.");
            DoChangeUIButtonMethod(buttonBaglan, true);
            DoChangeUIButtonMethod(buttonBaglantiKes, false);
            
            return;
        }

        private void baglantiKes()
        {
            string stringData = "bye";
            byte[] message = Encoding.UTF8.GetBytes(stringData);
            client.Send(message);
        }

        private void buttonBaglantiKes_Click(object sender, EventArgs e)
        {
            baglantiKes();
        }

        private void buttonSmsGonder_Click(object sender, EventArgs e)
        {
            mesajGonder(textKime.Text, textMesaj.Text);
        }

        private void baglanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoChangeUILabelMethod("Bağlanıyor...");
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint iep = new IPEndPoint(IPAddress.Parse(textIP.Text), 900);
            client.BeginConnect(iep, new AsyncCallback(Connected), client);
        }

    }
}
