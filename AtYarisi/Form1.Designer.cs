namespace AtYarisi
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BİR_NUMARA = new System.Windows.Forms.PictureBox();
            this.İKİ_NUMARA = new System.Windows.Forms.PictureBox();
            this.ÜÇ_NUMARA = new System.Windows.Forms.PictureBox();
            this.DÖRT_NUMARA = new System.Windows.Forms.PictureBox();
            this.BEŞ_NUMARA = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BİR_NUMARA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.İKİ_NUMARA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ÜÇ_NUMARA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DÖRT_NUMARA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BEŞ_NUMARA)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 19;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.ForestGreen;
            this.button1.Location = new System.Drawing.Point(759, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Başlat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(50, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(154, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Bahis:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Bakiye: ";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(387, 20);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(28, 20);
            this.numericUpDown1.TabIndex = 9;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(252, 19);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(86, 20);
            this.textBox2.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(354, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Oran:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(421, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(431, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "x";
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(683, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(519, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(463, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "At Seçin:";
            // 
            // BİR_NUMARA
            // 
            this.BİR_NUMARA.Image = ((System.Drawing.Image)(resources.GetObject("BİR_NUMARA.Image")));
            this.BİR_NUMARA.Location = new System.Drawing.Point(13, 54);
            this.BİR_NUMARA.Name = "BİR_NUMARA";
            this.BİR_NUMARA.Size = new System.Drawing.Size(139, 91);
            this.BİR_NUMARA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BİR_NUMARA.TabIndex = 17;
            this.BİR_NUMARA.TabStop = false;
            // 
            // İKİ_NUMARA
            // 
            this.İKİ_NUMARA.Image = ((System.Drawing.Image)(resources.GetObject("İKİ_NUMARA.Image")));
            this.İKİ_NUMARA.Location = new System.Drawing.Point(13, 151);
            this.İKİ_NUMARA.Name = "İKİ_NUMARA";
            this.İKİ_NUMARA.Size = new System.Drawing.Size(139, 91);
            this.İKİ_NUMARA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.İKİ_NUMARA.TabIndex = 18;
            this.İKİ_NUMARA.TabStop = false;
            // 
            // ÜÇ_NUMARA
            // 
            this.ÜÇ_NUMARA.Image = ((System.Drawing.Image)(resources.GetObject("ÜÇ_NUMARA.Image")));
            this.ÜÇ_NUMARA.Location = new System.Drawing.Point(13, 248);
            this.ÜÇ_NUMARA.Name = "ÜÇ_NUMARA";
            this.ÜÇ_NUMARA.Size = new System.Drawing.Size(139, 91);
            this.ÜÇ_NUMARA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ÜÇ_NUMARA.TabIndex = 19;
            this.ÜÇ_NUMARA.TabStop = false;
            // 
            // DÖRT_NUMARA
            // 
            this.DÖRT_NUMARA.Image = ((System.Drawing.Image)(resources.GetObject("DÖRT_NUMARA.Image")));
            this.DÖRT_NUMARA.Location = new System.Drawing.Point(13, 345);
            this.DÖRT_NUMARA.Name = "DÖRT_NUMARA";
            this.DÖRT_NUMARA.Size = new System.Drawing.Size(139, 91);
            this.DÖRT_NUMARA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DÖRT_NUMARA.TabIndex = 20;
            this.DÖRT_NUMARA.TabStop = false;
            // 
            // BEŞ_NUMARA
            // 
            this.BEŞ_NUMARA.Image = ((System.Drawing.Image)(resources.GetObject("BEŞ_NUMARA.Image")));
            this.BEŞ_NUMARA.Location = new System.Drawing.Point(12, 442);
            this.BEŞ_NUMARA.Name = "BEŞ_NUMARA";
            this.BEŞ_NUMARA.Size = new System.Drawing.Size(139, 91);
            this.BEŞ_NUMARA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BEŞ_NUMARA.TabIndex = 21;
            this.BEŞ_NUMARA.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.BEŞ_NUMARA);
            this.panel1.Controls.Add(this.DÖRT_NUMARA);
            this.panel1.Controls.Add(this.ÜÇ_NUMARA);
            this.panel1.Controls.Add(this.İKİ_NUMARA);
            this.panel1.Controls.Add(this.BİR_NUMARA);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1296, 551);
            this.panel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Yellow;
            this.label7.Location = new System.Drawing.Point(1264, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 482);
            this.label7.TabIndex = 23;
            this.label7.Text = "F   İ  N  İ  S  H";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.UseCompatibleTextRendering = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 545);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BİR_NUMARA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.İKİ_NUMARA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ÜÇ_NUMARA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DÖRT_NUMARA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BEŞ_NUMARA)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox BİR_NUMARA;
        private System.Windows.Forms.PictureBox İKİ_NUMARA;
        private System.Windows.Forms.PictureBox ÜÇ_NUMARA;
        private System.Windows.Forms.PictureBox DÖRT_NUMARA;
        private System.Windows.Forms.PictureBox BEŞ_NUMARA;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
    }
}

