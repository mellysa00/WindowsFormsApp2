using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FrmOyun : Form
    {

        static int toplam = 0;
        static int sure = 30;
        Random rnd = new Random();

        public FrmOyun()
        {
            InitializeComponent();
        }


        private void FrmOyun_Load(object sender, EventArgs e)
        {
            tmrButton.Start();
            tmrSure.Start();

        }
        private void tmrButton_Tick(object sender, EventArgs e)
        {
            Button btn = new Button();
            btn.Size = new Size(60, 50);
            btn.Location = new Point(rnd.Next(this.ClientSize.Width - pnlGosterge.Width - btn.Width), rnd.Next(this.ClientSize.Height - btn.Height));
            btn.Text = rnd.Next(100).ToString();
            //string customPath = (@"D:\snbhr.jpg");
            btn.BackgroundImage = Image.FromFile(@"D:\snbhr.jpg");
            btn.BackgroundImageLayout = ImageLayout.Stretch;
            btn.Click += Btn_Click;
            this.Btn_Click += new System.EventHandler(this.Button_Click);
            this.Controls.Add(btn);
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            toplam += int.Parse(btn.Text);
            lblskor.Text = $"Skor:{toplam}";
            // btn.Visible = false; // burda butonlar bellekten silinnmiyor ekranda gidiyor ama bellekte yer kaplamaya devam ediyor!
            btn.Dispose();//nesnenin heap bölgesinden atılması bellekte hiç yer kaplamıyor bellekten tamamen atılıyor. 
        }

        private void tmrSure_Tick(object sender, EventArgs e)
        {
            sure--;
            lblsure.Text = sure.ToString();
            if (sure == 0)
            {
                tmrSure.Stop();
                tmrButton.Stop();
                FileStream fs = new FileStream(@"D:\SkorKayit.txt", FileMode.Append);
                StreamWriter sw = new StreamWriter(fs);
                sw.Write(DateTime.Now + ($" Skorunuz:{toplam}\n\r"));
                fs.Flush();
                sw.Close();

                DialogResult secenek = MessageBox.Show($"Oyun Bitti.\n Skorunuz:{toplam}\n Yeniden Başlamak İster misiniz?", "Skor Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (secenek == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else
                {
                    this.Close();
                }
            }
        }
    }
}
