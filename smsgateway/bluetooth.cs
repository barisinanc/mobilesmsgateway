using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using InTheHand.Net;

namespace smsgateway
{
    public partial class bluetooth : Form
    {
        public bluetooth()
        {
            InitializeComponent();
        }

        private void bluetooth_Load(object sender, EventArgs e)
        {
            tara();
        }
        InTheHand.Net.BluetoothAddress[] adres_dizisi = new BluetoothAddress[1000];
        private void tara()
        {
            this.listCihaz.Items.Clear();

            InTheHand.Net.Sockets.BluetoothClient bc = new InTheHand.Net.Sockets.BluetoothClient();

            InTheHand.Net.Sockets.BluetoothDeviceInfo[] dizi = bc.DiscoverDevices();

            for (int i = 0; i < dizi.Length; i++)
            {
                this.adres_dizisi[i] = dizi[i].DeviceAddress;
                this.listCihaz.Items.Add(dizi[i].DeviceName);
            }

        }
        public string secilenEs;
        private void menuItem1_Click(object sender, EventArgs e)
        {

            Degiskenler.bluetoothSecilenMac = adres_dizisi[listCihaz.SelectedIndex];
            Degiskenler.bluetoothSecilen = listCihaz.SelectedItem.ToString();
            this.Close();
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        


    }
}