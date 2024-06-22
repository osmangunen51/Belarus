using BELARUS.SH.Extentions;
using BELARUS.SH.Model.Response;
using BELARUS.SH.View;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;

namespace BELARUS.SH.Egniner
{
    public class Istemci : IDisposable
    {
        private const string BaseUrl = "";
        public Istemci()
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        }

        public void Dispose()
        {

        }

        public ProcessResult<object> SorguGetir(string Url = "", NameValueCollection Input = null, string Path = "", Encoding Kodlama = null)
        {
            ProcessResult<object> Sonuc = new ProcessResult<object>();
            try
            {
                if (Input == null)
                {
                    Input = new NameValueCollection();
                }
                string PageUrl = $"{BaseUrl}{Url}";
                string SayfaKontrolIfadesi = "";
                using (HttpIstemci HttpIstemci = new HttpIstemci())
                {
                    string IstekTxt = Newtonsoft.Json.JsonConvert.SerializeObject(Input);
                    string abc = string.Join(", ", Input.AllKeys.Select(key => key + ": " + Input[key]).ToArray());
                    if (Kodlama != null)
                    {
                        HttpIstemci.Kodlama = Kodlama;
                    }
                    HtmlAgilityPack.HtmlDocument DokumanSayfa = new HtmlAgilityPack.HtmlDocument();
                    string HttpSonuc = HttpIstemci.HttpPost($"{PageUrl}", Input);
                    if (HttpSonuc.Contains(SayfaKontrolIfadesi) || SayfaKontrolIfadesi == string.Empty)
                    {
                        DokumanSayfa.LoadHtml(HttpSonuc);
                        var Blok = DokumanSayfa.DocumentNode.SelectSingleNode($"{Path}");
                        if (Blok != null)
                        {
                            Sonuc.Result = Blok.OuterHtml;
                        }
                    }
                }
                Sonuc.Mesaj = "Başarılı";
                Sonuc.Hata = null;
                Sonuc.Durum = true;
            }
            catch (Exception Hata)
            {
                Sonuc.Result = "";
                Sonuc.Mesaj = "Hata Oluştu.";
                Sonuc.Hata = Hata;
                Sonuc.Durum = false;
            }
            return Sonuc;
        }

        public ProcessResult<object> SorguGetirWithGet(string Url = "", NameValueCollection Input = null, string Path = "", Encoding Kodlama = null)
        {
            ProcessResult<object> Sonuc = new ProcessResult<object>() { };
            try
            {
                if (Input == null)
                {
                    Input = new NameValueCollection();
                }
                string PageUrl = $"{BaseUrl}{Url}";
                string SayfaKontrolIfadesi = "";
                using (HttpIstemci HttpIstemci = new HttpIstemci())
                {
                    string IstekTxt = Newtonsoft.Json.JsonConvert.SerializeObject(Input);
                    string abc = string.Join(", ", Input.AllKeys.Select(key => key + ": " + Input[key]).ToArray());
                    if (Kodlama != null)
                    {
                        HttpIstemci.Kodlama = Kodlama;
                    }
                    HtmlAgilityPack.HtmlDocument DokumanSayfa = new HtmlDocument();
                    string InputTxt = Input.ToQueryString();
                    InputTxt = InputTxt.Replace("%25", "%");
                    string HttpSonuc = HttpIstemci.HttpGet($"{PageUrl}?{InputTxt}");
                    if (HttpSonuc.Contains(SayfaKontrolIfadesi) | SayfaKontrolIfadesi == string.Empty)
                    {
                        DokumanSayfa.LoadHtml(HttpSonuc);
                        var Blok = DokumanSayfa.DocumentNode.SelectSingleNode($"{Path}");
                        if (Blok != null)
                        {
                            Sonuc.Result = Blok.OuterHtml;
                        }
                    }
                }
                Sonuc.Mesaj = "Başarılı";
                Sonuc.Hata = null;
                Sonuc.Durum = true;
            }
            catch (Exception Hata)
            {
                Sonuc.Result = "";
                Sonuc.Mesaj = "Hata Oluştu.";
                Sonuc.Hata = Hata;
                Sonuc.Durum = false;
            }
            return Sonuc;
        }

        public ProcessResult<List<Universite>> UniversiteListesiGetir()
        {
            ProcessResult<List<Universite>> Sonuc = new ProcessResult<List<Universite>>() { };
            try
            {
                string PageUrl = "universite.php";
                string SayfaKontrolIfadesi = "";
                string PageSorguUrl = $"";
                using (HttpIstemci HttpIstemci = new HttpIstemci())
                {
                    List<Universite> UniversiteListesi = new List<Universite>();
                    PageUrl = $"{BaseUrl}{PageUrl}";
                    string HttpSonuc = HttpIstemci.HttpGet(PageUrl);
                    if (!HttpSonuc.Contains(SayfaKontrolIfadesi) | SayfaKontrolIfadesi == "")
                    {
                        HtmlAgilityPack.HtmlDocument Dokuman = new HtmlDocument();
                        Dokuman.LoadHtml(HttpSonuc);
                        var universityNodes = Dokuman.DocumentNode.SelectNodes("//li[@class='unilist']//div[@class='row uniListItem']");
                        foreach (var node in universityNodes)
                        {
                            var nameNode = node.SelectSingleNode(".//h3[@class='baslik']");
                            var websiteNode = node.SelectSingleNode(".//a[contains(@href, 'http')]");
                            if (nameNode != null && websiteNode != null)
                            {
                                var Universite = new Universite
                                {
                                    Ad = nameNode.InnerText.Trim(),
                                    Web = websiteNode.GetAttributeValue("href", string.Empty).Trim()
                                };

                                UniversiteListesi.Add(Universite);
                            }
                        }
                        Sonuc.Result = UniversiteListesi;
                        Sonuc.Mesaj = "Başarılı";
                        Sonuc.Hata = null;
                        Sonuc.Durum = true;
                    }
                    else
                    {
                        Sonuc.Mesaj = "Kaynak Bulunamadı";
                        Sonuc.Durum = false;
                    }
                }
            }
            catch (Exception Hata)
            {
                Sonuc.Result = new List<Universite>();
                Sonuc.Mesaj = "Hata Oluştu.";
                Sonuc.Hata = Hata;
                Sonuc.Durum = false;
            }
            return Sonuc;
        }
    }
}
