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
            this.textKime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textMesaj = new System.Windows.Forms.TextBox();
            this.buttonSmsGonder = new System.Windows.Forms.Button();
            this.listDurum = new System.Windows.Forms.ListBox();
            this.buttonBaglan = new System.Windows.Forms.Button();
            this.buttonBaglantiKes = new System.Windows.Forms.Button();
            this.textIP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textKime
            // 
            this.textKime.Location = new System.Drawing.Point(71, 12);
            this.textKime.Name = "textKime";
            this.textKime.Size = new System.Drawing.Size(133, 20);
            this.textKime.TabIndex = 0;
            this.textKime.Text = "+905556827384";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kime:";
            // 
            // textMesaj
            // 
            this.textMesaj.Location = new System.Drawing.Point(17, 48);
            this.textMesaj.Multiline = true;
            this.textMesaj.Name = "textMesaj";
            this.textMesaj.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textMesaj.Size = new System.Drawing.Size(260, 166);
            this.textMesaj.TabIndex = 1;
            // 
            // buttonSmsGonder
            // 
            this.buttonSmsGonder.Location = new System.Drawing.Point(202, 220);
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
            this.listDurum.Location = new System.Drawing.Point(12, 277);
            this.listDurum.Name = "listDurum";
            this.listDurum.Size = new System.Drawing.Size(132, 69);
            this.listDurum.TabIndex = 3;
            // 
            // buttonBaglan
            // 
            this.buttonBaglan.Location = new System.Drawing.Point(163, 277);
            this.buttonBaglan.Name = "buttonBaglan";
            this.buttonBaglan.Size = new System.Drawing.Size(100, 30);
            this.buttonBaglan.TabIndex = 4;
            this.buttonBaglan.Text = "Telefona bağlan";
            this.buttonBaglan.UseVisualStyleBackColor = true;
            this.buttonBaglan.Click += new System.EventHandler(this.buttonBaglan_Click);
            // 
            // buttonBaglantiKes
            // 
            this.buttonBaglantiKes.Location = new System.Drawing.Point(163, 314);
            this.buttonBaglantiKes.Name = "buttonBaglantiKes";
            this.buttonBaglantiKes.Size = new System.Drawing.Size(100, 32);
            this.buttonBaglantiKes.TabIndex = 5;
            this.buttonBaglantiKes.Text = "Bağlantıyı kes";
            this.buttonBaglantiKes.UseVisualStyleBackColor = true;
            this.buttonBaglantiKes.Click += new System.EventHandler(this.buttonBaglantiKes_Click);
            // 
            // textIP
            // 
            this.textIP.Location = new System.Drawing.Point(44, 251);
            this.textIP.Name = "textIP";
            this.textIP.Size = new System.Drawing.Size(100, 20);
            this.textIP.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "IP:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 347);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textIP);
            this.Controls.Add(this.buttonBaglantiKes);
            this.Controls.Add(this.buttonBaglan);
            this.Controls.Add(this.listDurum);
            this.Controls.Add(this.buttonSmsGonder);
            this.Controls.Add(this.textMesaj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textKime);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

