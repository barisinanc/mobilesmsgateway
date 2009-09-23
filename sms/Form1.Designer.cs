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
            this.listResult = new System.Windows.Forms.ListBox();
            this.labelBaglanilan = new System.Windows.Forms.Label();
            this.labelIP = new System.Windows.Forms.Label();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItem1);
            // 
            // listResult
            // 
            this.listResult.Location = new System.Drawing.Point(3, 69);
            this.listResult.Name = "listResult";
            this.listResult.Size = new System.Drawing.Size(234, 198);
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
            // menuItem1
            // 
            this.menuItem1.Text = "Çıkış";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
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
    }
}

