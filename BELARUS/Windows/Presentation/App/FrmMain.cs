using Microsoft.Win32;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Management;
using System.Threading;
using System.Windows.Forms;

namespace BELARUS.App
{
    public partial class FrmMain : Form
    {

        public string Token { get; set; } = "";
        public HttpClient.Istemci HttpIstemci { get; set; }
        public static FrmMain AktifForm;
        private Service.AyarService AyarService = new Service.AyarService();

        public Bitmap ResizeImage(Image image, int width, int height)
        {

            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        public string UygulamaAd { get; set; } = "BELARUS Sistemi";

        public static FrmMain AktifFrmMainForm = null;

        public string TmpDizin { get; set; } = "";

        public void DurumBilgisiVer(string Mesaj)
        {
            DurumMesajMetinGuncelle(string.Format("{0}:{1}", DateTime.Now.ToString(), Mesaj));
        }

        public FrmMain()
        {
            InitializeComponent();
            HttpIstemci = new HttpClient.Istemci();
            AktifFrmMainForm = this;
            this.SystemTray.Text = FrmMain.AktifFrmMainForm.UygulamaAd;
            this.Text = FrmMain.AktifFrmMainForm.UygulamaAd;
            AktifForm = this;
        }

        public Data.Ayar AyarGetir(string AyarAd)
        {
            Data.Ayar Sonuc = new Data.Ayar();
            AyarService = new Service.AyarService();
            Sonuc = AyarService.Get(x => x.SystemAd == AyarAd);
            return Sonuc;
        }

        public IslemDurum AyarKaydet(Data.Ayar Ayar)
        {
            IslemDurum Sonuc = new IslemDurum();
            try
            {
                Sonuc.Mesaj = "Başarıyla kayıt edildi.";
                if (Ayar.No == 0)
                {
                    AyarService.Add(Ayar);
                    Ayar.Tarih = DateTime.Now;
                    Ayar.Durum = true;
                }
                else
                {
                    AyarService.Update(Ayar);
                }
                AyarService.Commit();
            }
            catch (Exception)
            {
                Sonuc.Durum = false;
                Sonuc.Mesaj = "Kayıt edilemedi.";
            }
            return Sonuc;
        }

        public IslemDurum AyarSil(Data.Ayar Ayar)
        {
            IslemDurum Sonuc = new IslemDurum();
            try
            {
                Sonuc.Mesaj = "Başarıyla kayıt silindi.";
                if (Ayar.No != 0)
                {
                    AyarService.Delete(Ayar);
                }
                AyarService.Commit();
            }
            catch (Exception)
            {
                Sonuc.Durum = false;
                Sonuc.Mesaj = "Kayıt Silinemedi.";
            }
            return Sonuc;
        }

        public void DefaultAyarEkle(string AyarName, string Deger)
        {
            Data.Ayar Ayar = FrmMain.AktifForm.AyarGetir(AyarName);
            if (Ayar == null)
            {
                Ayar = new Data.Ayar();
                Ayar.Deger = Deger;
                Ayar.Durum = true;
                Ayar.Tarih = DateTime.Now;
                Ayar.SystemAd = AyarName;
                FrmMain.AktifForm.AyarKaydet(Ayar);
            }
        }

        public void DefaultAyarSil(string AyarName, string Deger)
        {
            Data.Ayar Ayar = FrmMain.AktifForm.AyarGetir(AyarName);
            if (Ayar != null)
            {
                FrmMain.AktifForm.AyarSil(Ayar);
            }
        }

        public void StandartAyarlariYukle()
        {
            DefaultAyarEkle("AyrSistemCalismaZamanAraligi", "60");
        }

        public string EncodeTr(string Txt)
        {
            return Txt.Replace("&#252;", "ü")
              .Replace("&#246;", "ö")
              .Replace("&#231;", System.Net.WebUtility.HtmlDecode("&#231;"))
              .Replace("&#220;", System.Net.WebUtility.HtmlDecode("&#220;"))
              .Replace("&#199;", System.Net.WebUtility.HtmlDecode("&#199;"))
              .Replace("&#214;", System.Net.WebUtility.HtmlDecode("&#214;"));
        }

        private Thread KanalAnimasyon;
        private Ekranlar.FrmIslemYapiliyor frmIslemYapiliyor = new Ekranlar.FrmIslemYapiliyor() { StartPosition = FormStartPosition.CenterScreen };

        public void AnimasyonGoruntule(bool Durum, string Mesaj = "Bekleyiniz : İşlem Yapılıyor...")
        {
            if (Durum)
            {
                frmIslemYapiliyor.Text = Mesaj;
                frmIslemYapiliyor.Show();
            }
            else
            {
                frmIslemYapiliyor.Hide();
            }
        }

        private void AnimasyonIslemiYap()
        {
            frmIslemYapiliyor.Invoke(new MethodInvoker(() =>
            {
                frmIslemYapiliyor.Show();
            }));
        }

        public void AddApplicationToStartup()
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true))
            {
                key.SetValue(this.Text, "\"" + Application.ExecutablePath + "\"");
            }
        }

        public void RemoveApplicationFromStartup()
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true))
            {
                key.DeleteValue(this.Text, false);
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            StandartAyarlariYukle();
            frmIslemYapiliyor.Show();
            frmIslemYapiliyor.Hide();
            DurumBilgisiVer("Sistem Açıldı.");
            TmpDizin = string.Format(@"{0}\Tmp", Application.StartupPath);
            DirectoryInfo ITmpDizin = new DirectoryInfo(TmpDizin);
            if (!ITmpDizin.Exists)
            {
                ITmpDizin.Create();
            }

            //if (ApplicationDeployment.IsNetworkDeployed)
            //{
            //    TlStrpVersiyon.Text = string.Format("Ver.{0}", ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString(4));
            //}
            //else
            //{
            //    TlStrpVersiyon.Text = string.Format("Ver.{0}", "Developer");
            //}

            foreach (var item in TpPGiris.Controls)
            {
                if (item is Button)
                {
                    ButonTransparentYap((Button)item);
                }
            }

            DirectoryInfo LogDizin = new DirectoryInfo(string.Format(@"{0}\{1}", Application.StartupPath, "Log"));
            if (!LogDizin.Exists)
            {
                LogDizin.Create();
            }
            //SystemTrayaGonder();
            //try
            //{
            //    Data.Ayar AyarChkWindowsStartup = AyarService.Get(x => x.SystemAd == "ChkWindowsStartup");
            //    if (AyarChkWindowsStartup != null)
            //    {
            //        if (Convert.ToBoolean(AyarChkWindowsStartup.Deger))
            //        {
            //            FrmMain.AktifFrmMainForm.AddApplicationToStartup();
            //        }
            //        else
            //        {
            //            FrmMain.AktifFrmMainForm.RemoveApplicationFromStartup();
            //        }
            //    }
            //}
            //catch (Exception Hata)
            //{

            //}
        }

        public void ButonTransparentYap(Button Btn)
        {
            Btn.Font = new Font("Calibri", 10);
            Btn.FlatStyle = FlatStyle.Flat;
            Btn.FlatAppearance.BorderSize = 0;
            Btn.BackColor = Color.Transparent;
            Btn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Btn.FlatAppearance.MouseOverBackColor = Color.Transparent;

            Btn.MouseLeave += Btn_MouseLeave;

            Btn.MouseEnter += Btn_MouseEnter;
        }

        public static Bitmap ChangeOpacity(Image img, float opacityvalue)
        {
            Bitmap bmp = new Bitmap(img.Width, img.Height); // Determining Width and Height of Source Image
            Graphics graphics = Graphics.FromImage(bmp);
            ColorMatrix colormatrix = new ColorMatrix();
            colormatrix.Matrix33 = opacityvalue;
            ImageAttributes imgAttribute = new ImageAttributes();
            imgAttribute.SetColorMatrix(colormatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
            graphics.DrawImage(img, new Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, imgAttribute);
            graphics.Dispose();   // Releasing all resource used by graphics
            return bmp;
        }

        public Bitmap TransParentKaynak = new Bitmap(1, 1);

        private void Btn_MouseEnter(object sender, EventArgs e)
        {
            float opacityvalue = float.Parse("0,7");
            Button Btn = (Button)sender;
            TransParentKaynak = (Bitmap)Btn.Image;
            Btn.Width += (Btn.Width * 1) / 100;
            Btn.Height += (Btn.Height * 1) / 100;
            Btn.Image = ChangeOpacity(Btn.Image, opacityvalue);
        }

        private void Btn_MouseLeave(object sender, EventArgs e)
        {
            float opacityvalue = float.Parse("1,0");
            Button Btn = (Button)sender;
            Btn.Width -= (Btn.Width * 1) / 100;
            Btn.Height -= (Btn.Height * 1) / 100;
            Btn.Image = ChangeOpacity(TransParentKaynak, opacityvalue);
        }

        public void FormEkle(Form Form)
        {
            foreach (BELARUS.Win.FATabStripItem item in TpcIslem.Items)
            {
                if (item.Title == Form.Text)
                {
                    TpcIslem.SelectedItem = item;
                    return;
                }
            }
            BELARUS.Win.FATabStripItem Tp = new BELARUS.Win.FATabStripItem();
            Tp.Title = Form.Text;
            Form.TopLevel = false;
            Form.Visible = true;
            Form.FormBorderStyle = FormBorderStyle.None;
            Form.Dock = DockStyle.Fill;
            Tp.Controls.Add(Form);
            Tp.CanClose = true;
            Tp.Image = Form.Icon.ToBitmap();
            TpcIslem.AddTab(Tp, true);
            DurumBilgisiVer(string.Format("{0} Ekranı Oluşturuldu", Form.Text));
        }

        public string LisansNumarasiniGetir()
        {
            string cpuInfo = string.Empty;
            ManagementClass mc = new ManagementClass("win32_processor");
            ManagementObjectCollection moc = mc.GetInstances();
            foreach (ManagementObject mo in moc)
            {
                if (cpuInfo == "")
                {
                    cpuInfo = mo.Properties["processorID"].Value.ToString();
                    break;
                }
            }
            return string.Format("URN-{0}-LSN", cpuInfo);
        }

        private bool Cikis = false;

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cikis = true;
            this.Close();
            Thread.Sleep(1000);
            Application.ExitThread();
            Application.Exit();
        }

        public void FormOlusturEkle(Form Form)
        {
            FrmMain.AktifFrmMainForm.FormEkle(Form);
        }

        private void SystemTray_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            SystemTrayKaldir();
        }

        private void SystemTrayKaldir()
        {
            this.Show();
            SystemTray.Visible = false;
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            SystemTrayaGonder();
        }

        private void SystemTrayaGonder()
        {
            if (!Cikis)
            {
                this.Hide();
                SystemTray.Visible = true;
                SystemTray.BalloonTipTitle = FrmMain.AktifFrmMainForm.UygulamaAd;
                SystemTray.BalloonTipText = "Simge Durumunda Çalışıyorum...";
                SystemTray.ShowBalloonTip(1000);
                SystemTray.BalloonTipClicked += SystemTray_BalloonTipClicked;
            }
        }

        private void SystemTray_BalloonTipClicked(object sender, EventArgs e)
        {
            SystemTrayKaldir();
        }

        private void SystemTrayMenuAc_Click(object sender, EventArgs e)
        {
            SystemTrayKaldir();
        }

        private void SystemTrayMenuCikis_Click(object sender, EventArgs e)
        {
            CikisYap();
        }

        private void CikisYap()
        {
            DialogResult SncIslem = MessageBox.Show("Programı Kapatmak İstiyormusunuz ? ", "Mars Yönetim İşlemleri", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (SncIslem == DialogResult.Yes)
            {
                Cikis = true;
                this.Close();
                Application.ExitThread();
                Application.Exit();
            }
        }



        private void TpPGiris_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);

            //private Ellipse ellipse1 = new Ellipse() { PenWidth = 15, Color = Color.Red, Rectangle = new Rectangle(50, 30, 200, 200) };
            //private Ellipse ellipse2 = new Ellipse() { PenWidth = 15, Color = Color.Yellow, Rectangle = new Rectangle(300, 30, 200, 200) };
            //private Ellipse ellipse3 = new Ellipse() { PenWidth = 15, Color = Color.Green, Rectangle = new Rectangle(550, 30, 200, 200) };
            //private Ellipse ellipse4 = new Ellipse() { PenWidth = 15, Color = Color.PaleVioletRed, Rectangle = new Rectangle(800, 30, 200, 200) };
            //private Ellipse ellipse5 = new Ellipse() { PenWidth = 15, Color = Color.AntiqueWhite, Rectangle = new Rectangle(1050, 30, 200, 200) };
            //private Ellipse ellipse6 = new Ellipse() { PenWidth = 15, Color = Color.CadetBlue, Rectangle = new Rectangle(1300, 30, 200, 200) };
            //private Ellipse ellipse7 = new Ellipse() { PenWidth = 15, Color = Color.DarkOrange, Rectangle = new Rectangle(50, 300, 200, 200) };



            //ellipse1.Draw(e.Graphics);
            //ellipse2.Draw(e.Graphics);
            //ellipse3.Draw(e.Graphics);
            //ellipse4.Draw(e.Graphics);
            //ellipse5.Draw(e.Graphics);
            //ellipse6.Draw(e.Graphics);
            //ellipse7.Draw(e.Graphics);
        }

        public void SifreAlaniGoruntuleKapat(object sender, MouseEventArgs e)
        {
            int VisibleTime = 1000;  //in milliseconds
            TextBox Txt = (TextBox)(sender);
            ToolTip tt = new ToolTip();
            tt.Show(Txt.Text, Txt, 0, 0, VisibleTime);
        }

        private void btnUygulamaAyarlari_Click(object sender, EventArgs e)
        {
            var Frm = new Ekranlar.FrmAyar() { Text = ((Button)sender).Text };
            FormOlusturEkle(Frm);
        }

        private delegate void DurumMesajDegistirDelegate(string text);

        private void DurumMesajMetinGuncelle(string text)
        {
            if (this.TlStrpDurum.Owner.InvokeRequired)
            {
                DurumMesajDegistirDelegate d = new DurumMesajDegistirDelegate(DurumMesajMetinGuncelle);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.TlStrpDurum.Text = text;
            }
        }


        private void btnZamanlanmisCheckingler_Click(object sender, EventArgs e)
        {

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            CikisYap();
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btnSistemTakipIslemleri_Click(object sender, EventArgs e)
        {
            ManuelEkraniAc();
        }

        public void ManuelEkraniAc()
        {
            //var AyrBttAppUrl = FrmMain.AktifForm.AyarGetir("AyrBttAppUrl");
            //if (AyrBttAppUrl == null)
            //{
            //    MessageBox.Show("Sistem Start Url Eksik! Lütfen ayarlar bölümünde girişini yapınız", "BTT in App Ayarları");
            //    return;
            //}
            //else if (string.IsNullOrEmpty(AyrBttAppUrl.Deger.ToString()))
            //{
            //    MessageBox.Show("Sistem Start Url Eksik! Lütfen ayarlar bölümünde girişini yapınız", "BTT in App Ayarları");
            //    return;
            //}
            var Frm = new Ekranlar.FrmSHManuel() { Text = btnSistemTakipIslemleri.Text };
            FormOlusturEkle(Frm);
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    using (BELARUS.SH.Istemci Istemci = new Bittorent.Istemci())
        //    {
        //        var IstekSonuc = Istemci.TokenGetir();
        //        if (IstekSonuc.Durum)
        //        {
        //            IstekSonuc = Istemci.PrivateKeyGetir();
        //            if (IstekSonuc.Durum)
        //            {
        //                IstekSonuc = Istemci.BttAppGonder(1000);
        //                if (IstekSonuc.Durum)
        //                {
        //                    txtIstekSonuc.Text = Newtonsoft.Json.JsonConvert.SerializeObject(IstekSonuc, Newtonsoft.Json.Formatting.Indented);
        //                }
        //                else
        //                {
        //                    txtIstekSonuc.Text = Newtonsoft.Json.JsonConvert.SerializeObject(IstekSonuc, Newtonsoft.Json.Formatting.Indented);
        //                }
        //            }
        //            else
        //            {
        //                txtIstekSonuc.Text = Newtonsoft.Json.JsonConvert.SerializeObject(IstekSonuc, Newtonsoft.Json.Formatting.Indented);
        //            }
        //        }
        //        else
        //        {

        //            txtIstekSonuc.Text = Newtonsoft.Json.JsonConvert.SerializeObject(IstekSonuc, Newtonsoft.Json.Formatting.Indented);
        //        }
        //    }
        //}
    }
}