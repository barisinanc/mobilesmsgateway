namespace sms
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.listResult = new System.Windows.Forms.ListBox();
            this.labelBaglanilan = new System.Windows.Forms.Label();
            this.labelIP = new System.Windows.Forms.Label();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.textIP = new System.Windows.Forms.TextBox();
            this.textPort = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItem1);
            // 
            // menuItem1
            // 
            this.menuItem1.Text = "Çıkış";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // listResult
            // 
            this.listResult.Location = new System.Drawing.Point(3, 83);
            this.listResult.Name = "listResult";
            this.listResult.Size = new System.Drawing.Size(234, 184);
            this.listResult.TabIndex = 4;
            // 
            // labelBaglanilan
            // 
            this.labelBaglanilan.Location = new System.Drawing.Point(3, 37);
            this.labelBaglanilan.Name = "labelBaglanilan";
            this.labelBaglanilan.Size = new System.Drawing.Size(220, 20);
            this.labelBaglanilan.Text = "Bağlanılan:";
            // 
            // labelIP
            // 
            this.labelIP.Location = new System.Drawing.Point(4, 14);
            this.labelIP.Name = "labelIP";
            this.labelIP.Size = new System.Drawing.Size(100, 20);
            this.labelIP.Text = "IP:";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(165, 56);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(72, 20);
            this.buttonConnect.TabIndex = 6;
            this.buttonConnect.Text = "Bağlan";
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // textIP
            // 
            this.textIP.Location = new System.Drawing.Point(4, 56);
            this.textIP.Name = "textIP";
            this.textIP.Size = new System.Drawing.Size(114, 21);
            this.textIP.TabIndex = 7;
            this.textIP.Text = "169.254.2.2";
            // 
            // textPort
            // 
            this.textPort.Location = new System.Drawing.Point(124, 56);
            this.textPort.Name = "textPort";
            this.textPort.Size = new System.Drawing.Size(35, 21);
            this.textPort.TabIndex = 8;
            this.textPort.Text = "900";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.textPort);
            this.Controls.Add(this.textIP);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.labelIP);
            this.Controls.Add(this.listResult);
            this.Controls.Add(this.labelBaglanilan);
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "Sms Geçidi - Bar&Bar Data";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listResult;
        private System.Windows.Forms.Label labelBaglanilan;
        private System.Windows.Forms.Label labelIP;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.TextBox textIP;
        private System.Windows.Forms.TextBox textPort;
    }
}

