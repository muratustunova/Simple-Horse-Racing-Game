using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtYarisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            MessageBox.Show("\t\t      ---AT YARIŞI OYUNU--- \n\n Yapacağınız bahis öncelikle kasanızdan eksiltilecek. " +
                "Eğer yarışı kazanırsanız, daha sonra bahisiniz oynadığınız kat sayı ile çarpılarak kasanıza eklenecektir." +
                "Eğer Yarışı kaybeder veya yarış bitmeden önce reset tuşuna basarsanız, bahisiniz haliyle boşa gidecektir.");
            InitializeComponent();
            textBox2.ReadOnly = true; // textbox readonly özelliği aktifleştirdim.
            numericUpDown1.Value = 2; // numericUpDown başlangıç değeri 2 yapıldı. 
        }
        private void Form1_Load(object sender, EventArgs e)
        {   
            /*Form açılırken comboBox'a atların üzerlerindeki numara göre isimler atadım. 
             kullanıcı için yapılan bir atamadır. */
            comboBox1.Items.Add("1 Numara");
            comboBox1.Items.Add("2 Numara");
            comboBox1.Items.Add("3 Numara");
            comboBox1.Items.Add("4 Numara");
            comboBox1.Items.Add("5 Numara");
            //başlangıçta verilecek olan bakiye miktarını tanımladım.
            textBox2.Text = "1000";
            //Başlat butonuna basıldığında textbox1 boş ise uyarı vermeli.
            textBox1.Text =" ";
            //Benim manuel ayarladığım Form boyutunu kullanıcı değiştiremesin diye getirdiğim kısıtlamalar. 
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            atlarındurumu(false);  // atlar hareket etmeyecek(gif oynamayacak)
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            //Kullanıcı minimum 2 den başlayarak ve maksimum 5 e kadar giren oranları kullanabilecek. Getirilen kısıtlama...
            numericUpDown1.Maximum = 5;
            numericUpDown1.Minimum = 2;
            label4.Text = numericUpDown1.Value.ToString();
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*KeyPress kısmında ise textBox1 isim kutucuğumuza sadece int değer girmesini istiyoruz. 
            Bundan dolayı bu olayı(Event) kullandık.*/
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        /* Bu kısımda atların hareketinin durması, atların konumlarının başlangıç konumuna gelmesi, girilen bahislerin silinmesi,
         timer1 adlı sayacımın ise durdurulması ayarlandı. Sadece bakiyede kalan para değeri silinmemiştir. */
       
        #region Herşeyi resetleme butonu
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            numericUpDown1.Value = 2;
            atlarındurumu(false);
            timer1.Stop();
            
            //atların ilk konumu
            BİR_NUMARA.Left=12 ;
            İKİ_NUMARA.Left=12 ;
            ÜÇ_NUMARA.Left=12;
            DÖRT_NUMARA.Left =12;
            BEŞ_NUMARA.Left =12;
        }
        #endregion

        // burda overload yaptık.
        #region Atların hareket etme durumu
        void atlarındurumu(bool durum, PictureBox at)
        {
            BİR_NUMARA.Enabled = İKİ_NUMARA.Enabled 
            = ÜÇ_NUMARA.Enabled = DÖRT_NUMARA.Enabled
            = BEŞ_NUMARA.Enabled = durum;
            at.Enabled = true;
        }
        void atlarındurumu (bool durum)
        {
            BİR_NUMARA.Enabled = İKİ_NUMARA.Enabled
            = ÜÇ_NUMARA.Enabled = DÖRT_NUMARA.Enabled
            = BEŞ_NUMARA.Enabled = durum;
        }
        #endregion

        int bakiye, bahis; int Myselectİndex; 

        //yarış başaladığı zaman oluşacak işlemler mevcut.
        #region başlat butonu 'Click Event' olayı
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != " ")
            {
                //Bahis işlemleri
                int bahis1, bakiye1;
                bahis1 = Convert.ToInt32(textBox1.Text);
                bakiye1 = Convert.ToInt32(textBox2.Text);

                if (bahis1 < bakiye1 || bahis1 == bakiye1)
                {
                    bakiye1 = bakiye1 - bahis1;
                    textBox2.Text = bakiye1.ToString();
                    //etkinleşecek durumlar
                    bakiye=bakiye1; bahis = bahis1;  
                    atlarındurumu(true);//atlar hareket edecek (gif oynayacak)
                    timer1.Start();
                }
                else if (bahis > bakiye)
                {
                    MessageBox.Show("Bakiyeyi aştınız !!!");
                    textBox1.Text = " ";
                }
            }
                 else if (textBox1.Text == " ")
                {
                    MessageBox.Show("bahis girin !");
                }
        }
        #endregion

        /*Timer ı PictureBox'ları hareket ettirmeki için kullandım. "Interval" özelliği ile kaç saniyede ki tekrar etme hızını
         ayarladım.*/
        #region timer kullanılan kısım
        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            BİR_NUMARA.Left += rand.Next(1, 20);
            İKİ_NUMARA.Left += rand.Next(1, 20);
            ÜÇ_NUMARA.Left += rand.Next(1, 20);
            DÖRT_NUMARA.Left += rand.Next(1, 20);
            BEŞ_NUMARA.Left += rand.Next(1, 20);

            WinnerHorse(BİR_NUMARA);
            WinnerHorse(İKİ_NUMARA);
            WinnerHorse(ÜÇ_NUMARA);
            WinnerHorse(DÖRT_NUMARA);
            WinnerHorse(BEŞ_NUMARA);
        }
        #endregion

        /* Bu kısımda atların kontrolü ile ilgili ufak algoritmalar yer alıyor. Atların kazanma durumuyla ilgili ufak detaylar
        içeriyor*/
        #region Atların kazanmasını kontrol eden void fonksiyonu
        void WinnerHorse (PictureBox kazanan)
        {
            if(kazanan.Right -5 >= label7.Left)
            {
                timer1.Stop();
                atlarındurumu(false);
                MessageBox.Show("Kazanan :" +kazanan.Name);
                
                /*atların eski konumu tekrar manuel girdim. Sebebi ise kazanan at belli olduğunda ve kullanıcı MessageBox'ıı kapattığında
                 atlar eski yerlerine geçmiyor. Bundan kaynaklı oalrak hemen arkasına ikinci kez başlat butonuna basıldığında ise program hata veriyor.
                 hata vermesinin sebibi ise atlar zaten FİNİSH çizgisinde fakat tekrar yarışın başlamasını tetiklenmiş oluyor.
                 Buda aynı atın tekrar kazanmasına ve bakiyeden aynı bahis değerinin düşülmesine sebep oluyor.*/
                BİR_NUMARA.Left = 12;
                İKİ_NUMARA.Left = 12;
                ÜÇ_NUMARA.Left = 12;
                DÖRT_NUMARA.Left = 12;
                BEŞ_NUMARA.Left = 12;

                /*comboBox'ın 'Select Index' özelliği ile numericUpDown'ın sayılarının uyuşması, beraber çalışması için 
                 * bu işlemi yaptım. Çok pratik olmadı farklı bir fonksiyon tanımlayıp çekebilirdim Ancak bir sefer kullandığım için tercih etmedim.*/
                #region numericUpDown index atama
                switch (kazanan.Name)
                {
                    case "BİR_NUMARA": Myselectİndex = 0; break;
                    case "İKİ_NUMARA": Myselectİndex = 1; break;
                    case "ÜÇ_NUMARA": Myselectİndex = 2; break;
                    case "DÖRT_NUMARA": Myselectİndex = 3; break;
                    case "BEŞ_NUMARA": Myselectİndex = 4; break;
                }
                #endregion
                
                /*numericUpDown ile seçilen sayının (1 olsun diyelim) , comboBox'da ki Index değerine ('0' a) eşit olması için bu işlemi yaptım.*/
                #region bahis işlemleri/Kazanan ata göre değerimizi katlama kısmı
                //kazanama gerçekleştikten sonra eğer seçilen at kazandıysa para bakiyeye eklenecektir.
                if (comboBox1.SelectedIndex == Myselectİndex )
                {
                    if (numericUpDown1.Value == 2) { bakiye += bahis * 2; }
                    else if (numericUpDown1.Value == 3) { bakiye += bahis * 3; }
                    else if (numericUpDown1.Value == 4) { bakiye += bahis * 4; }
                    else if (numericUpDown1.Value == 5) { bakiye += bahis * 5; }
                }
                #endregion
                //textbox2'ye bakiyede kalan parayı bastırmam gerekiyor.
                textBox2.Text = bakiye.ToString();
                if (bakiye == 0)
                {
                    MessageBox.Show("Paranız Bitti !!");
                    Environment.Exit(0);
                }
            }
        }
        #endregion
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
        }
    }
}
