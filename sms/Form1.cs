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
using System.IO;
using System.Xml.Serialization;
using barbardataMobile;

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

        private void Form1_Load(object sender, EventArgs e)
        {
            labelIP.Text += sunucuIP();
            dinle();
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
        #region UI Değişiklikleri
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
        #endregion UI Değişiklikleri

        #region IP adresini bul
        private string sunucuIP()
        {
            string strHostName = "";
            strHostName = System.Net.Dns.GetHostName();

            IPHostEntry ipEntry = System.Net.Dns.GetHostEntry(strHostName);

            IPAddress[] addr = ipEntry.AddressList;

            return addr[addr.Length - 1].ToString();
        }
        #endregion IP adresini bul

        #region TCP Sunucu
        private static Socket client;
        private void dinle()
        {
            Socket newsock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint iep = new IPEndPoint(IPAddress.Any, 900);
            newsock.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            newsock.Bind(iep);
            newsock.Listen(10);
            
            newsock.BeginAccept(new AsyncCallback(AcceptConn), newsock);
        }
        
        void AcceptConn(IAsyncResult iar)
        {
            
            Socket oldserver = (Socket)iar.AsyncState;
            client = oldserver.EndAccept(iar);
            oldserver.Close();
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
            dinle();
        }

        private void ReceiveData()
        {
            byte[] data = new byte[1024];
            int recv;
            string stringData;
            bool error=false;            
            while (true)
            {
                try
                {
                    recv = client.Receive(data);
                }
                catch (Exception e)
                {
                    DoChangeUILabelMethod("Bağlantı hatası. " + e);
                    error = true;
                    break;
                }
                if (Serialize.ByteArray2Object(data, typeof(SmsSeri)) == null)
                {
                    stringData = Encoding.UTF8.GetString(data, 0, recv);
                    if (stringData == "bye")
                        break;
                    DoChangeUILabelMethod(stringData);
                }
                else
                {

                    SmsSeri yeniSms = (SmsSeri)Serialize.ByteArray2Object(data,typeof(SmsSeri));
                    Thread gonderici = new Thread(delegate { mesajGonder(yeniSms); });
                    gonderici.Start();
                }
            }
            if (error == false)
            {
                stringData = "bye";
                byte[] message = Encoding.UTF8.GetBytes(stringData);
                client.Send(message);
                client.Close();
                dinle();
                DoChangeUILabelMethod("Bağlantı durduruldu.");
            }
            return;
        }
        #endregion TCP Sunucu

        #region Sms Geldi
        void mesaj_MessageReceived(object sender, MessageInterceptorEventArgs e)
        {
            SmsMessage gelenSms = e.Message as SmsMessage;
        }
        #endregion Sms Geldi
        private void mesajGonder(SmsSeri Sms)
        {
            SmsMessage yeniSms = new SmsMessage(Sms.To, Sms.Message);
            yeniSms.Send();
            DoChangeUILabelMethod("1 Sms gönderildi.");
        }


        private void menuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}