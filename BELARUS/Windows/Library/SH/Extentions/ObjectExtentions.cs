using System.Collections.Specialized;
using System.Web;


namespace BELARUS.SH.Extentions
{
    public static class ObjectExtentions
    {
        public static NameValueCollection ToQueryParameter(this object Nesne)
        {
            NameValueCollection Sonuc = new NameValueCollection();
            foreach (System.Reflection.PropertyInfo p in Nesne.GetType().GetProperties())
            {
                if (p.CanRead)
                {
                    Sonuc.Add(p.Name, (p.GetValue(Nesne) != null ? p.GetValue(Nesne).ToString() : ""));
                }
            }
            return Sonuc;
        }

        //public static NameValueCollection ToQueryParameter(this FormCollection Nesne)
        //{
        //    NameValueCollection Sonuc = new NameValueCollection();
        //    foreach (var item in Nesne.Keys)
        //    {
        //        Sonuc.Add(item, (Nesne[item] != null ? Nesne[item].ToString() : ""));
        //    }
        //    return Sonuc;
        //}
        public static NameValueCollection ToEncodingUrl(this NameValueCollection Nesne)
        {
            NameValueCollection Sonuc = new NameValueCollection();
            foreach (var item in Nesne.AllKeys)
            {
                string Ifade = (Nesne[item] != null ? Nesne[item].ToString() : "");
                Ifade = HttpUtility.UrlDecode(Ifade);
                Ifade = HttpUtility.UrlEncode(Ifade, System.Text.Encoding.GetEncoding("ISO-8859-9"));
                Sonuc.Add(item, Ifade);
            }
            return Sonuc;
        }

        public static string ToQueryString(this NameValueCollection nameValueCollection)
        {
            NameValueCollection httpValueCollection = HttpUtility.ParseQueryString("");
            httpValueCollection.Add(nameValueCollection);
            string Ifade = httpValueCollection.ToString();
            return Ifade;
        }
    }
}
