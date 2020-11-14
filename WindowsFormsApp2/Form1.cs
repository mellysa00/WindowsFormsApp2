using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        static int toplam = 0;
        public Form1()
        {
            InitializeComponent();
            
            Random rnd = new Random();

            button1.Text = rnd.Next(100).ToString();
            button2.Text = rnd.Next(100).ToString();
            button3.Text = rnd.Next(100).ToString();
            button2.Click += NumberClick;
            button3.Click += NumberClick;
            //Constructorlar değer atama işlemi için daha uygunudr.
        }
        void  NumberClick(object sender,EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Enabled = false;//buton tıklandıktan sonra pasif oluyor
            toplam += int.Parse(btn.Text);
        }

        private void btnSonuc_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Sayıların toplamı:{toplam}");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //load eventinde iş mantığınızı kurgulayabilirsiniz. Form açılıdğında yapılacak olan işler
            tmrButton.Start();
        }

        private void tmrButton_Tick(object sender, EventArgs e)
        {

            //MessageBox.Show("Test");
        }
    }
}
