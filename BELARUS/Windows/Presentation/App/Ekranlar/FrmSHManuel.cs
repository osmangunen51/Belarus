using BELARUS.Service;
using BELARUS.SH.Egniner;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Threading;
using System.Windows.Forms;

namespace BELARUS.App.Ekranlar
{


    public partial class FrmSHManuel : BaseForm
    {
        public string Url { get; set; } = "";
        public BELARUS.Service.KaynakService KaynakService = new KaynakService();

        public List<Data.Kaynak> KaynakListesi { get; set; } = new List<Data.Kaynak>();
        public static FrmSHManuel AktifFrmMainForm = null;
        public Thread IslemKanal { get; set; } = null;

        public BELARUS.SH.Egniner.Istemci Istemci { get; set; } = new Istemci();

        public FrmSHManuel()
        {
            InitializeComponent();
            AktifFrmMainForm = this;
            tlStrUstMenu.ImageScalingSize = new Size(36, 36);
            stAltBar.ImageScalingSize = new Size(36, 36);
        }




        private void FrmEslestirme_Load(object sender, EventArgs e)
        {
            FormuBaslat();
        }

        private void FormuBaslat()
        {
            FaIslemler.SelectedItem = PnlGecmis;
            TlStrpBtnDurdur.Enabled = false;
        }

        private void TlStrpBtnBaslat_Click(object sender, EventArgs e)
        {
            if (TlStrpBtnBaslat.Text == "Başlat")
            {
                IslemYapilmaDurumu = true;
                KaynakListesi = KaynakService.GetAll().ToList();
                IslemKanal = new Thread(new ThreadStart(IslemYap));
                IslemKanal.Start();
                TlStrpBtnBaslat.GetCurrentParent().Invoke(new MethodInvoker(delegate
                {
                    TlStrpBtnBaslat.Text = "Duraklat";
                    TlStrpBtnBaslat.Image = BELARUS.App.Icons.Duraklat;
                }));
                TlStrpBtnDurdur.GetCurrentParent().Invoke(new MethodInvoker(delegate
                {
                    TlStrpBtnDurdur.Enabled = true;
                }));
            }
            else if (TlStrpBtnBaslat.Text == "Duraklat")
            {
                if (IslemKanal.IsAlive)
                {
                    IslemKanal.Suspend();
                }
                TlStrpBtnBaslat.GetCurrentParent().Invoke(new MethodInvoker(delegate
                {
                    TlStrpBtnBaslat.Text = "Devam Ettir";
                    TlStrpBtnBaslat.Image = BELARUS.App.Icons.Baslat;
                }));
            }
            else if (TlStrpBtnBaslat.Text == "Devam Ettir")
            {
                if (IslemKanal.IsAlive)
                {
                    IslemKanal.Resume();
                }
                TlStrpBtnBaslat.GetCurrentParent().Invoke(new MethodInvoker(delegate
                {
                    TlStrpBtnBaslat.Text = "Duraklat";
                    TlStrpBtnBaslat.Image = BELARUS.App.Icons.Duraklat;
                }));
            }
            else
            {

            }
        }
        private void UyariCal()
        {
            SoundPlayer snd = new SoundPlayer(Properties.Resources.Uyari);
            snd.Play();
        }
        private void LogEkle(string Mesaj, Color Renk = default, float FontSize = 8)
        {
            if (Renk == default)
            {
                Renk = Color.YellowGreen;
            }
            txtLog.Invoke((MethodInvoker)delegate
            {
                if (txtLog.Lines.Length > 5000)
                {
                    string FilePath = Path.Combine(Application.StartupPath, $"{Guid.NewGuid()}.txt");
                    File.WriteAllText(FilePath, txtLog.Text);
                    txtLog.Text = string.Empty;
                }
                string MesajMetin = $"{DateTime.Now} == > {Mesaj}{Environment.NewLine}";
                int StartIndex = txtLog.Text.Length;
                txtLog.AppendText(MesajMetin);
                txtLog.Select(StartIndex, MesajMetin.Length);
                txtLog.SelectionColor = Renk;
                txtLog.SelectionFont = new Font(txtLog.Font.FontFamily, FontSize);
                StartIndex = txtLog.Text.Length;
                txtLog.Select(StartIndex, 0);
                txtLog.ScrollToCaret();
            });
        }

        bool IslemYapilmaDurumu = false;
        int Deger = 0;
        public void IslemYap()
        {
            Deger = 0;
            int IslemYapilmaZamanAraligi = 60;
            var Ayar = FrmMain.AktifForm.AyarGetir("AyrSistemCalismaZamanAraligi");
            if (Ayar != null)
            {
                IslemYapilmaZamanAraligi = Convert.ToInt32(Ayar.Deger.ToString());
            }

            TlStrpBarIslem.GetCurrentParent().Invoke(new MethodInvoker(delegate
            {
                TlStrpBarIslem.Maximum = this.KaynakListesi.Count();
                TlStrpBarIslem.Value = 0;

            }));
            LblDurum.GetCurrentParent().Invoke(new MethodInvoker(delegate
            {
                LblDurum.Text = "Başlandı";

            }));

            txtLog.Invoke((MethodInvoker)delegate
            {
                txtLog.Text = string.Empty;
            });

            LogEkle("Sistem Çalışmaya Başladı");


            //string BaseUrl = "";
            //var AyrBttAppUrl = FrmMain.AktifForm.AyarGetir("AyrBttAppUrl");
            //if (AyrBttAppUrl == null)
            //{
            //    MessageBox.Show("Sistem Start Url Eksik! Lütfen ayarlar bölümünde girişini yapınız", "BTT in App Ayarları");
            //    IslemYapilmaDurumu = false;
            //    return;
            //}
            //else
            //{
            //    BaseUrl = AyrBttAppUrl.Deger.ToString();
            //}



            if (IslemYapilmaDurumu)
            {

                Thread.Sleep(IslemYapilmaZamanAraligi);
                LogEkle($"Genel Takip ({IslemYapilmaZamanAraligi} ms) Bekleme Yapıldı");
                Application.DoEvents();
                //if (BttBakiye < 1000)
                //{
                //    break;
                //}
            }

            LblDurum.GetCurrentParent().Invoke(new MethodInvoker(delegate
            {
                LblDurum.Text = "Bitti.";
            }));
            TlStrpBtnBaslat.GetCurrentParent().Invoke(new MethodInvoker(delegate
            {
                TlStrpBtnBaslat.Text = "Başlat";
                TlStrpBtnBaslat.Image = BELARUS.App.Icons.Baslat;
            }));

            TlStrpBtnDurdur.GetCurrentParent().Invoke(new MethodInvoker(delegate
            {
                TlStrpBtnDurdur.Enabled = false;
            }));

            if (IslemKanal != null)
            {
                IslemKanal.Abort(1000);
            }
        }



        private void TlStrpBtnDurdur_Click(object sender, EventArgs e)
        {
            IslemYapilmaDurumu = false;
            Thread.Sleep(250);
            if (IslemKanal != null)
            {
                if (IslemKanal.IsAlive)
                {
                    IslemKanal.Abort(500);
                }
            }
            TlStrpBtnBaslat.GetCurrentParent().Invoke(new MethodInvoker(delegate
            {
                TlStrpBtnBaslat.Text = "Başlat";
                TlStrpBtnBaslat.Image = BELARUS.App.Icons.Baslat;
            }));
            TlStrpBtnDurdur.GetCurrentParent().Invoke(new MethodInvoker(delegate
            {
                //TlStrpBtnDurdur.Text = "Durdur";
                //TlStrpBtnDurdur.Image = BELARUS.App.Icons.Duraklat;
                TlStrpBtnDurdur.Enabled = false;
            }));
        }
    }
}