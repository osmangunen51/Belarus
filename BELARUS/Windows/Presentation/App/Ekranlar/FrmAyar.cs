using BELARUS.Data;
using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace BELARUS.App.Ekranlar
{
    public partial class FrmAyar : BaseForm
    {
        private Service.AyarService AyarService = new Service.AyarService();
        private RegistryKey Regedit = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

        public FrmAyar()
        {
            InitializeComponent();
        }

        public void AyarKaydet(Control Kontrol)
        {
            if (Kontrol.Controls.Count > 0)
            {
                foreach (Control item in Kontrol.Controls)
                {
                    string AyarAd = "";
                    string AyarDeger = "";
                    if ((item.Tag != null) && !string.IsNullOrEmpty(item.Tag.ToString()))
                    {
                        AyarAd = item.Tag.ToString();
                        if (item is TextBox)
                        {
                            TextBox IslemKontrol = (TextBox)item;
                            if (IslemKontrol != null)
                            {
                                AyarDeger = IslemKontrol.Text;
                            }
                        }
                        if (item is CheckBox)
                        {
                            CheckBox IslemKontrol = (CheckBox)item;
                            if (IslemKontrol != null)
                            {
                                AyarDeger = IslemKontrol.Checked.ToString();
                            }
                        }
                        if (item is ComboBox)
                        {
                            ComboBox IslemKontrol = (ComboBox)item;
                            if (IslemKontrol != null)
                            {
                                AyarDeger = IslemKontrol.Text.ToString();
                            }
                        }

                        Data.Ayar Ayar = AyarService.Get(x => x.SystemAd == AyarAd);
                        if (Ayar == null)
                        {
                            Ayar = new Data.Ayar();
                            Ayar.SystemAd = AyarAd;
                            Ayar.Deger = AyarDeger;
                            Ayar.Tarih = DateTime.Now;
                            AyarService.Add(Ayar);
                        }
                        else
                        {
                            Ayar.Deger = AyarDeger;
                        }
                        AyarService.Commit();
                    }
                    AyarKaydet(item);
                }
            }
        }

        public void AyarYukle(Control Kontrol)
        {
            if (Kontrol.Controls.Count > 0)
            {
                foreach (Control item in Kontrol.Controls)
                {
                    string AyarAd = "";
                    string AyarDeger = "";

                    if ((item.Tag != null) && !string.IsNullOrEmpty(item.Tag.ToString()))
                    {
                        AyarAd = item.Tag.ToString();

                        Data.Ayar Ayar = AyarService.Get(x => x.SystemAd == AyarAd);
                        if (Ayar == null)
                        {
                            Ayar = new Data.Ayar();
                            Ayar.SystemAd = AyarAd;
                            Ayar.Deger = AyarDeger;
                            Ayar.Tarih = DateTime.Now;
                            AyarService.Add(Ayar);
                            AyarService.Commit();
                        }
                        else
                        {
                            AyarDeger = Ayar.Deger;
                        }
                        if (item is TextBox)
                        {
                            TextBox IslemKontrol = (TextBox)item;
                            if (IslemKontrol != null)
                            {
                                IslemKontrol.Text = AyarDeger;
                            }
                        }
                        if (item is CheckBox)
                        {
                            CheckBox IslemKontrol = (CheckBox)item;
                            if (IslemKontrol != null)
                            {
                                IslemKontrol.Checked = Convert.ToBoolean(AyarDeger);
                            }
                        }
                        if (item is ComboBox)
                        {
                            ComboBox IslemKontrol = (ComboBox)item;
                            if (IslemKontrol != null)
                            {
                                IslemKontrol.Text = AyarDeger;
                            }
                        }
                        AyarService.Commit();
                    }
                    AyarYukle(item);
                }
            }
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                AyarKaydet(this);
                LblDurum.Text = "Başarıyla Kayıt edildi.";
                Data.Ayar AyarChkWindowsStartup = AyarService.Get(x => x.SystemAd == "ChkWindowsStartup");
                if (AyarChkWindowsStartup != null)
                {
                    if (Convert.ToBoolean(AyarChkWindowsStartup.Deger))
                    {
                        FrmMain.AktifFrmMainForm.AddApplicationToStartup();
                    }
                    else
                    {
                        FrmMain.AktifFrmMainForm.RemoveApplicationFromStartup();
                    }
                }
            }
            catch (Exception)
            {
                LblDurum.Text = "Hata Oluştu.";
            }
        }

        private void FrmGenelAyarlar_Load(object sender, EventArgs e)
        {
            try
            {
                AyarYukle(this);
                LblDurum.Text = "Başarıyla Kayıt edildi.";
            }
            catch (Exception Hata)
            {
                LblDurum.Text = "Hata Oluştu." + Hata.Message;
            }
        }
    }
}