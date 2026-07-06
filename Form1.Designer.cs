namespace Proje
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.resimSecBtn = new System.Windows.Forms.Button();
            this.resimBoyutuLbl = new System.Windows.Forms.Label();
            this.resimTarihiLbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.resimEkleBtn = new System.Windows.Forms.Button();
            this.tabloBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.resimIdLbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.resimYoluLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(15, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Resim Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(19, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Resim Boyutu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(17, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "Resim Sahibi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(19, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 36);
            this.label5.TabIndex = 4;
            this.label5.Text = "Resim Tarihi:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(455, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1001, 705);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // resimSecBtn
            // 
            this.resimSecBtn.BackColor = System.Drawing.Color.PaleGreen;
            this.resimSecBtn.Location = new System.Drawing.Point(36, 451);
            this.resimSecBtn.Name = "resimSecBtn";
            this.resimSecBtn.Size = new System.Drawing.Size(313, 68);
            this.resimSecBtn.TabIndex = 6;
            this.resimSecBtn.Text = "Resim Seç";
            this.resimSecBtn.UseVisualStyleBackColor = false;
            this.resimSecBtn.Click += new System.EventHandler(this.resimSecBtn_Click_1);
            // 
            // resimBoyutuLbl
            // 
            this.resimBoyutuLbl.AutoSize = true;
            this.resimBoyutuLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.resimBoyutuLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.resimBoyutuLbl.Location = new System.Drawing.Point(244, 300);
            this.resimBoyutuLbl.Name = "resimBoyutuLbl";
            this.resimBoyutuLbl.Size = new System.Drawing.Size(0, 31);
            this.resimBoyutuLbl.TabIndex = 8;
            // 
            // resimTarihiLbl
            // 
            this.resimTarihiLbl.AutoSize = true;
            this.resimTarihiLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.resimTarihiLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.resimTarihiLbl.Location = new System.Drawing.Point(228, 340);
            this.resimTarihiLbl.Name = "resimTarihiLbl";
            this.resimTarihiLbl.Size = new System.Drawing.Size(0, 31);
            this.resimTarihiLbl.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(21, 235);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(312, 35);
            this.textBox1.TabIndex = 10;
            this.textBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseClick);
            // 
            // resimEkleBtn
            // 
            this.resimEkleBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.resimEkleBtn.Location = new System.Drawing.Point(36, 539);
            this.resimEkleBtn.Name = "resimEkleBtn";
            this.resimEkleBtn.Size = new System.Drawing.Size(313, 67);
            this.resimEkleBtn.TabIndex = 11;
            this.resimEkleBtn.Text = "Resim Ekle";
            this.resimEkleBtn.UseVisualStyleBackColor = false;
            this.resimEkleBtn.Click += new System.EventHandler(this.resimEkleBtn_Click_1);
            // 
            // tabloBtn
            // 
            this.tabloBtn.BackColor = System.Drawing.Color.Crimson;
            this.tabloBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabloBtn.Location = new System.Drawing.Point(36, 643);
            this.tabloBtn.Name = "tabloBtn";
            this.tabloBtn.Size = new System.Drawing.Size(312, 107);
            this.tabloBtn.TabIndex = 12;
            this.tabloBtn.Text = "Resimler Tablosu";
            this.tabloBtn.UseVisualStyleBackColor = false;
            this.tabloBtn.Click += new System.EventHandler(this.tabloBtn_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Controls.Add(this.resimIdLbl);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.tabloBtn);
            this.groupBox1.Controls.Add(this.resimEkleBtn);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.resimTarihiLbl);
            this.groupBox1.Controls.Add(this.resimBoyutuLbl);
            this.groupBox1.Controls.Add(this.resimSecBtn);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(28, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 875);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // resimIdLbl
            // 
            this.resimIdLbl.AutoSize = true;
            this.resimIdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.resimIdLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.resimIdLbl.Location = new System.Drawing.Point(174, 45);
            this.resimIdLbl.Name = "resimIdLbl";
            this.resimIdLbl.Size = new System.Drawing.Size(0, 38);
            this.resimIdLbl.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(13, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 36);
            this.label6.TabIndex = 14;
            this.label6.Text = "Resim ID:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(19, 139);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(313, 35);
            this.textBox2.TabIndex = 13;
            this.textBox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox2_MouseClick);
            // 
            // resimYoluLbl
            // 
            this.resimYoluLbl.AutoSize = true;
            this.resimYoluLbl.Location = new System.Drawing.Point(450, 53);
            this.resimYoluLbl.Name = "resimYoluLbl";
            this.resimYoluLbl.Size = new System.Drawing.Size(0, 29);
            this.resimYoluLbl.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1603, 910);
            this.Controls.Add(this.resimYoluLbl);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resim Ekle";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button resimSecBtn;
        private System.Windows.Forms.Label resimBoyutuLbl;
        private System.Windows.Forms.Label resimTarihiLbl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button resimEkleBtn;
        private System.Windows.Forms.Button tabloBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label resimYoluLbl;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label resimIdLbl;
    }
}

