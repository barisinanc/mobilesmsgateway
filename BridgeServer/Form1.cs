using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net.Sockets;
using System.Net;

namespace BridgeServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public delegate void DoChange(string theText);

        public void DoChangeMethod(string theText)
        {
            if (this.listDurum.InvokeRequired)
            {
                DoChange theDelegate = new DoChange(DoChangeMethod);
                this.Invoke(theDelegate, new object[] { theText });
            }
            else
            {
                this.listDurum.Items.Add(theText);
            }
        }

        #region TCP Sunucu
        private static Socket client;
        private static Socket pocketPc;
        private void dinleClient()
        {
            Socket newsock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint iep = new IPEndPoint(IPAddress.Any, Convert.ToInt32(textBox2.Text));
            newsock.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            newsock.Bind(iep);
            newsock.Listen(10);

            newsock.BeginAccept(new AsyncCallback(AcceptConnClient), newsock);
        }

        void AcceptConnClient(IAsyncResult iar)
        {
            Socket oldserver = (Socket)iar.AsyncState;
            client = oldserver.EndAccept(iar);
            oldserver.Close();
            try
            {
                //DoChangeUIBaglanilanMethod(client.RemoteEndPoint.ToString());
                DoChangeMethod("Gelen bağlantı: " + client.RemoteEndPoint.ToString());
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            Thread receiver = new Thread(new ThreadStart(ReceiveDataClient));
            receiver.Start();
            dinleClient();
        }

        private void ReceiveDataClient()
        {
            byte[] data = new byte[1024];
            int recv;
            string stringData;
            bool error = false;
            while (true)
            {
                try
                {
                    recv = client.Receive(data);
                    pocketPc.Send(data);
                }
                catch (Exception e)
                {
                    //DoChangeUILabelMethod("Bağlantı hatası. " + e);
                    error = true;
                    break;
                }
            }
            if (error == false)
            {

                stringData = "bye";
                byte[] message = Encoding.UTF8.GetBytes(stringData);
                try
                {
                    client.Send(message);
                }
                catch { }
                client.Close();
                dinleClient();
                //DoChangeUILabelMethod("Bağlantı durduruldu.");
            }
            return;
        }

        private void dinlePocket()
        {
            Socket newsock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint iep = new IPEndPoint(IPAddress.Any, Convert.ToInt32(textBox1.Text));
            newsock.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            newsock.Bind(iep);
            newsock.Listen(10);

            newsock.BeginAccept(new AsyncCallback(AcceptConnPocket), newsock);
        }

        void AcceptConnPocket(IAsyncResult iar)
        {
            Socket oldserver = (Socket)iar.AsyncState;
            pocketPc = oldserver.EndAccept(iar);
            oldserver.Close();
            try
            {
                //DoChangeUIBaglanilanMethod(client.RemoteEndPoint.ToString());
                DoChangeMethod("Gelen bağlantı: " + pocketPc.RemoteEndPoint.ToString());
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            Thread receiver = new Thread(new ThreadStart(ReceiveDataPocket));
            receiver.Start();
            dinlePocket();
        }

        private void ReceiveDataPocket()
        {
            byte[] data = new byte[1024];
            int recv;
            string stringData;
            bool error = false;
            while (true)
            {
                try
                {
                    recv = pocketPc.Receive(data);
                    client.Send(data);
                }
                catch (Exception e)
                {
                    DoChangeMethod("Bağlantı hatası. " + e);
                    error = true;
                    break;
                }
            }
            if (error == false)
            {

                stringData = "bye";
                byte[] message = Encoding.UTF8.GetBytes(stringData);
                try
                {
                    pocketPc.Send(message);
                }
                catch { }
                pocketPc.Close();
                dinlePocket();
                //DoChangeUILabelMethod("Bağlantı durduruldu.");
            }
            return;
        }
        #endregion TCP Sunucu

        private void buttonListen_Click(object sender, EventArgs e)
        {
            dinleClient();
            dinlePocket();
        }
    }
}
