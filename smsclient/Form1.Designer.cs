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
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Yeni Mesaj");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Gelen Mesajlar");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Gönderilmiş Mesajlar");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Giden Mesajlar");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Mesajlar", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Veritabanı Ayarları");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Sunucu Ayarları");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Google Rehber Ayarları");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Ayarlar", new System.Windows.Forms.TreeNode[] {
            treeNode16,
            treeNode17,
            treeNode18});
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Google Rehber");
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
            this.textIP.Location = new System.Drawing.Point(338, 382);
            this.textIP.Name = "textIP";
            this.textIP.Size = new System.Drawing.Size(100, 20);
            this.textIP.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 382);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "IP:";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(0, 27);
            this.treeView1.Name = "treeView1";
            treeNode11.Name = "YeniMesaj";
            treeNode11.Text = "Yeni Mesaj";
            treeNode12.Name = "GelenMesajlar";
            treeNode12.Text = "Gelen Mesajlar";
            treeNode13.Name = "GonderilmisMesajlar";
            treeNode13.Text = "Gönderilmiş Mesajlar";
            treeNode14.Name = "GidenMesajlar";
            treeNode14.Text = "Giden Mesajlar";
            treeNode15.Name = "Mesajlar";
            treeNode15.Text = "Mesajlar";
            treeNode16.Name = "VeritabaniAyarlari";
            treeNode16.Text = "Veritabanı Ayarları";
            treeNode17.Name = "SunucuAyarlari";
            treeNode17.Text = "Sunucu Ayarları";
            treeNode18.Name = "GoogleRehberAyarlari";
            treeNode18.Text = "Google Rehber Ayarları";
            treeNode19.Name = "Ayarlar";
            treeNode19.Text = "Ayarlar";
            treeNode20.Name = "GoogleRehber";
            treeNode20.Text = "Google Rehber";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode15,
            treeNode19,
            treeNode20});
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 489);
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
    }
}

