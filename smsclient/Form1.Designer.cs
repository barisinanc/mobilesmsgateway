namespace smsclient
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Yeni Mesaj");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Gelen Mesajlar");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Gönderilmiş Mesajlar");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Giden Mesajlar");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Mesajlar", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Veritabanı Ayarları");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Sunucu Ayarları");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Google Rehber Ayarları");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Ayarlar", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Google Rehber");
            this.textKime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textMesaj = new System.Windows.Forms.TextBox();
            this.buttonSmsGonder = new System.Windows.Forms.Button();
            this.listDurum = new System.Windows.Forms.ListBox();
            this.buttonBaglan = new System.Windows.Forms.Button();
            this.buttonBaglantiKes = new System.Windows.Forms.Button();
            this.textIP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.baglanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textKime
            // 
            this.textKime.Location = new System.Drawing.Point(369, 38);
            this.textKime.Name = "textKime";
            this.textKime.Size = new System.Drawing.Size(133, 20);
            this.textKime.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(315, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kime:";
            // 
            // textMesaj
            // 
            this.textMesaj.Location = new System.Drawing.Point(315, 74);
            this.textMesaj.Multiline = true;
            this.textMesaj.Name = "textMesaj";
            this.textMesaj.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textMesaj.Size = new System.Drawing.Size(260, 166);
            this.textMesaj.TabIndex = 1;
            // 
            // buttonSmsGonder
            // 
            this.buttonSmsGonder.Location = new System.Drawing.Point(500, 246);
            this.buttonSmsGonder.Name = "buttonSmsGonder";
            this.buttonSmsGonder.Size = new System.Drawing.Size(75, 23);
            this.buttonSmsGonder.TabIndex = 2;
            this.buttonSmsGonder.Text = "Gönder";
            this.buttonSmsGonder.UseVisualStyleBackColor = true;
            this.buttonSmsGonder.Click += new System.EventHandler(this.buttonSmsGonder_Click);
            // 
            // listDurum
            // 
            this.listDurum.FormattingEnabled = true;
            this.listDurum.Location = new System.Drawing.Point(61, 382);
            this.listDurum.Name = "listDurum";
            this.listDurum.Size = new System.Drawing.Size(132, 69);
            this.listDurum.TabIndex = 3;
            // 
            // buttonBaglan
            // 
            this.buttonBaglan.Location = new System.Drawing.Point(500, 376);
            this.buttonBaglan.Name = "buttonBaglan";
            this.buttonBaglan.Size = new System.Drawing.Size(100, 30);
            this.buttonBaglan.TabIndex = 4;
            this.buttonBaglan.Text = "Telefona bağlan";
            this.buttonBaglan.UseVisualStyleBackColor = true;
            this.buttonBaglan.Click += new System.EventHandler(this.buttonBaglan_Click);
            // 
            // buttonBaglantiKes
            // 
            this.buttonBaglantiKes.Location = new System.Drawing.Point(500, 419);
            this.buttonBaglantiKes.Name = "buttonBaglantiKes";
            this.buttonBaglantiKes.Size = new System.Drawing.Size(100, 32);
            this.buttonBaglantiKes.TabIndex = 5;
            this.buttonBaglantiKes.Text = "Bağlantıyı kes";
            this.buttonBaglantiKes.UseVisualStyleBackColor = true;
            this.buttonBaglantiKes.Click += new System.EventHandler(this.buttonBaglantiKes_Click);
            // 
            // textIP
            // 
            this.textIP.Location = new System.Drawing.Point(315, 382);
            this.textIP.Name = "textIP";
            this.textIP.Size = new System.Drawing.Size(100, 20);
            this.textIP.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 382);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "IP:";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(0, 27);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "YeniMesaj";
            treeNode1.Text = "Yeni Mesaj";
            treeNode2.Name = "GelenMesajlar";
            treeNode2.Text = "Gelen Mesajlar";
            treeNode3.Name = "GonderilmisMesajlar";
            treeNode3.Text = "Gönderilmiş Mesajlar";
            treeNode4.Name = "GidenMesajlar";
            treeNode4.Text = "Giden Mesajlar";
            treeNode5.Name = "Mesajlar";
            treeNode5.Text = "Mesajlar";
            treeNode6.Name = "VeritabaniAyarlari";
            treeNode6.Text = "Veritabanı Ayarları";
            treeNode7.Name = "SunucuAyarlari";
            treeNode7.Text = "Sunucu Ayarları";
            treeNode8.Name = "GoogleRehberAyarlari";
            treeNode8.Text = "Google Rehber Ayarları";
            treeNode9.Name = "Ayarlar";
            treeNode9.Text = "Ayarlar";
            treeNode10.Name = "GoogleRehber";
            treeNode10.Text = "Google Rehber";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode9,
            treeNode10});
            this.treeView1.Size = new System.Drawing.Size(172, 305);
            this.treeView1.TabIndex = 8;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 467);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(687, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.baglanToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(687, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // baglanToolStripMenuItem
            // 
            this.baglanToolStripMenuItem.Name = "baglanToolStripMenuItem";
            this.baglanToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.baglanToolStripMenuItem.Text = "Bağlan";
            this.baglanToolStripMenuItem.Click += new System.EventHandler(this.baglanToolStripMenuItem_Click);
            // 
            // textPort
            // 
            this.textPort.Location = new System.Drawing.Point(318, 409);
            this.textPort.Name = "textPort";
            this.textPort.Size = new System.Drawing.Size(97, 20);
            this.textPort.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 416);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Port:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 489);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textPort);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textIP);
            this.Controls.Add(this.buttonBaglantiKes);
            this.Controls.Add(this.buttonBaglan);
            this.Controls.Add(this.listDurum);
            this.Controls.Add(this.buttonSmsGonder);
            this.Controls.Add(this.textMesaj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textKime);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Sms Client - Bar&Bar Data";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textKime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textMesaj;
        private System.Windows.Forms.Button buttonSmsGonder;
        private System.Windows.Forms.ListBox listDurum;
        private System.Windows.Forms.Button buttonBaglan;
        private System.Windows.Forms.Button buttonBaglantiKes;
        private System.Windows.Forms.TextBox textIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem baglanToolStripMenuItem;
        private System.Windows.Forms.TextBox textPort;
        private System.Windows.Forms.Label label3;
    }
}

