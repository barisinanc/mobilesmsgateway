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
using System.IO.Ports;
using System.IO;
using InTheHand.Net;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace smsgateway
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SerialPort Port = new SerialPort();

        //bluetooth bluetoothSec = new bluetooth();
        private void Form1_Load(object sender, EventArgs e)
        {
            dinle();
            //bluetoothSec.Closed += new EventHandler(bluetoothSec_Closed);
            //bluetoothSec.ShowDialog();
            SmsMessage yeniSms = new SmsMessage("234232342", "werwrr");
            //yeniSms.From = "baran";
            //dosyaKaydet(yeniSms);
            //dosyaGonder();
            MessageInterceptor mesaj = new MessageInterceptor(InterceptionAction.NotifyAndDelete, true);
            //mesaj.MessageCondition=new MessageCondition(
            
            mesaj.MessageReceived += new MessageInterceptorEventHandler(mesaj_MessageReceived);
        }



        private void dinle()
        {
            Socket newsock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint iep = new IPEndPoint(IPAddress.Any, 9050);
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
                listResult.Items.Add((string)("Connection from: " + client.RemoteEndPoint.ToString()));
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            Thread receiver = new Thread(new ThreadStart(ReceiveData));
            receiver.Start();
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
                listResult.Items.Add((string)stringData);
            }
            stringData = "bye";
            byte[] message = Encoding.UTF8.GetBytes(stringData);
            client.Send(message);
            client.Close();
            listResult.Items.Add("Connection stopped");
            return;
        }

        void bluetoothSec_Closed(object sender, EventArgs e)
        {
            labelBaglanilan.Text += Degiskenler.bluetoothSecilen;

            //dosyaKaydet();
            dosyaGonder();
        }

        private void dosyaGonder()
        {
            InTheHand.Net.BluetoothAddress adres = Degiskenler.bluetoothSecilenMac;
            System.Uri uri = new Uri("obex://" + adres.ToString() + "/" + "sms.txt");
            ObexWebRequest request = new ObexWebRequest(uri);
            
            request.ReadFile("sms.txt");
            
            ObexWebResponse response = (ObexWebResponse)request.GetResponse();
            response.Close();

        }

        private void dosyaKaydet(SmsMessage sms)
        {
            if (File.Exists("sms.txt"))
            { File.Delete("sms.txt"); }
            StreamWriter yaz = File.AppendText("sms.txt");
            yaz.WriteLine(sms.Received.ToString());
            //yaz.WriteLine(sms.From.ToString());
            yaz.WriteLine(sms.Body);
            yaz.Close();
        }

        void mesaj_MessageReceived(object sender, MessageInterceptorEventArgs e)
        {
            SmsMessage gelenSms = e.Message as SmsMessage;
        }

        private void mesajGonder(string mesaj, string numara)
        {
            SmsMessage Sms = new SmsMessage();
            Sms.Body = mesaj;
            Sms.To.Add(new Recipient(numara));
            Sms.Send();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mesajGonder("deneme", "+46767965723");
        }
    }
}