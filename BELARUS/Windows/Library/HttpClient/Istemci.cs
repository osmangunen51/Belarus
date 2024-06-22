﻿using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

namespace HttpClient
{
    public class Istemci : IDisposable
    {
        public CookieWebClient WebClient { get; set; } = new CookieWebClient();

        public Encoding Kodlama { get; set; } = Encoding.Default;

        public Istemci()
        {
        }

        public string HttpPost(string Url, NameValueCollection values)
        {
            var responseString = "";
            try
            {
                var response = WebClient.UploadValues(Url, values);
                responseString = Kodlama.GetString(response);
            }
            catch (Exception Hata)
            {
                responseString = Hata.Message;
            }
            return responseString;
        }

        public string HttpPost(string Url, Dictionary<string, string> Dic)
        {
            NameValueCollection values = new NameValueCollection();
            foreach (var item in Dic)
            {
                values.Add(item.Key, item.Value);
            }
            return HttpPost(Url, values);
        }

        public string HttpPost(string Url, string Data)
        {
            var responseString = "";
            try
            {
                responseString = WebClient.UploadString(Url, Data);
            }
            catch (Exception Hata)
            {
                responseString = Hata.Message;
            }
            return responseString;
        }

        public string HttpGet(string Url)
        {
            WebClient.Encoding = Kodlama;
            var response = WebClient.DownloadString(Url);
            return response;
        }
        public string HttpGet(string Url, Dictionary<string, string> Dic)
        {
            WebClient.Encoding = Kodlama;
            var tmpurl = Url + "?";
            int Bas = 0;
            foreach (var item in Dic)
            {
                if (Bas == 0)
                {
                    tmpurl += $"{item.Key}={item.Value}";
                }
                else
                {
                    tmpurl += $"&{item.Key}={item.Value}";
                }
                Bas++;
            }
            var response = WebClient.DownloadString(tmpurl);
            return response;
        }

        public void DownloadFile(string Url, string FileName)
        {
            WebClient.DownloadFile(Url, FileName);
        }

        public byte[] DownloadFile(string Url, Dictionary<string, string> Dic)
        {
            byte[] Sonuc = null;
            try
            {
                NameValueCollection values = new NameValueCollection();
                foreach (var item in Dic)
                {
                    values.Add(item.Key, item.Value);
                }
                Sonuc = WebClient.UploadValues(Url, values);
            }
            catch (Exception)
            {
                Sonuc = null;
            }

            return Sonuc;
        }

        public void Dispose()
        {
        }
    }
}