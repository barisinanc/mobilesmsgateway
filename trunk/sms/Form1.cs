using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.WindowsMobile.PocketOutlook;
using Microsoft.WindowsMobile.PocketOutlook.MessageInterception;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO.Ports;

namespace sms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MessageInterceptor gelenSms = new MessageInterceptor(InterceptionAction.Notify, true);
            gelenSms.MessageReceived += new MessageInterceptorEventHandler(gelenSms_MessageReceived);
        }

        void gelenSms_MessageReceived(object sender, MessageInterceptorEventArgs e)
        {
            if (client.Connected)
            {
                listResult.Items.Add("1 yeni mesaj istemciye aktarıldı." + e.Message.From);
                string stringData = "Sms T:"+e.Message.Received.ToString()+"|N:"+e.Message.From+"|M:"+e.Message.ToString();
                byte[] message = Encoding.UTF8.GetBytes(stringData);
                client.Send(message);
            }
        }

        public delegate void DoChangeUILabel(string theText);

        public void DoChangeUILabelMethod(string theText)
        {
            if (this.listResult.InvokeRequired)
            {
                DoChangeUILabel theDelegate = new DoChangeUILabel(DoChangeUILabelMethod);
                this.Invoke(theDelegate, new object[] { theText });
            }
            else
            {
                this.listResult.Items.Add(theText);
            }
        }

        public delegate void DoChangeUIBaglanilan(string theText);

        public void DoChangeUIBaglanilanMethod(string theText)
        {
            if (this.labelBaglanilan.InvokeRequired)
            {
                DoChangeUIBaglanilan theDelegate = new DoChangeUIBaglanilan(DoChangeUIBaglanilanMethod);
                this.Invoke(theDelegate, new object[] { theText });
            }
            else
            {
                this.labelBaglanilan.Text = "Bağlanılan:" + theText;
            }
        }

        SerialPort Port = new SerialPort();
        private void Form1_Load(object sender, EventArgs e)
        {
            labelIP.Text += sunucuIP();
            dinle();
        }

        private string sunucuIP()
        {
            string strHostName = "";
            strHostName = System.Net.Dns.GetHostName();

            IPHostEntry ipEntry = System.Net.Dns.GetHostEntry(strHostName);

            IPAddress[] addr = ipEntry.AddressList;

            return addr[addr.Length - 1].ToString();
        }


        private void dinle()
        {
            Socket newsock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint iep = new IPEndPoint(IPAddress.Any, 900);
            newsock.Bind(iep);
            newsock.Listen(5);
            newsock.BeginAccept(new AsyncCallback(AcceptConn), newsock);
        }

        private static Socket client;
        private static byte[] data = new byte[1024];
        void AcceptConn(IAsyncResult iar)
        {
            Socket oldserver = (Socket)iar.AsyncState;
            client = oldserver.EndAccept(iar);
            try
            {
                DoChangeUIBaglanilanMethod(client.RemoteEndPoint.ToString());
                DoChangeUILabelMethod("Gelen bağlantı: " + client.RemoteEndPoint.ToString());
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            Thread receiver = new Thread(new ThreadStart(ReceiveData));
            receiver.Start();
        }

        private void ReceiveData()
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
                if (stringData.StartsWith("Sms To:"))
                {

                    string veri = stringData.Replace("Sms ", "");
                    string kime = veri.Split('|')[0].Replace("To:", "");
                    string mesaj = veri.Split('|')[1].Replace("Mesaj:", "");

                    Thread gonderici = new Thread(delegate { mesajGonder(mesaj, kime); });
                    gonderici.Start();
                }
            }
            stringData = "bye";
            byte[] message = Encoding.UTF8.GetBytes(stringData);
            client.Send(message);
            client.Close();
            DoChangeUILabelMethod("Bağlantı durduruldu.");
            return;
        }


        void mesaj_MessageReceived(object sender, MessageInterceptorEventArgs e)
        {
            SmsMessage gelenSms = e.Message as SmsMessage;
        }

        private void mesajGonder(string mesaj, string numara)
        {
            SmsMessage Sms = new SmsMessage();
            Sms.Body = mesaj;
            numara.Replace(",", ";");
            numara.Replace(" ", "");

            string[] numaralar;
            numaralar = numara.Split(';');
            foreach (string x in numaralar)
            {
                if (x.Length > 10)
                { Sms.To.Add(new Recipient(x)); }
            }
            Sms.Send();
        }


        private void menuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}