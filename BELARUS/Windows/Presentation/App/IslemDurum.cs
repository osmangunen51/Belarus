using System;

namespace BELARUS.App
{
    public class IslemDurum
    {
        public enum IslemMesajTip
        {
            Basarili = 1,
            Hata = 2,
            Uyari = 3,
            Bilgi = 4
        }

        #region -Alanlar-

        /// <summary>
        /// İşlem Durumu
        /// </summary>
        private bool _Durum = true;

        /// <summary>
        /// İşlem Durumu
        /// </summary>
        public bool Durum
        {
            get
            {
                return _Durum;
            }
            set
            {
                _Durum = value;
            }
        }

        /// <summary>
        /// İşlem Mesajı
        /// </summary>
        private string _Mesaj = "";

        /// <summary>
        /// İşlem Mesajı
        /// </summary>
        public string Mesaj
        {
            get
            {
                return _Mesaj;
            }
            set
            {
                _Mesaj = value;
            }
        }

        /// <summary>
        /// İşlem Degerı
        /// </summary>
        private object _Deger;

        /// <summary>
        /// İşlem Degerı
        /// </summary>
        public object Deger
        {
            get
            {
                return _Deger;
            }
            set
            {
                _Deger = value;
            }
        }

        private Exception _Hata = new Exception();

        public Exception Hata
        {
            get { return _Hata; }
            set { _Hata = value; }
        }

        public IslemMesajTip Tip { get; set; }

        #endregion -Alanlar-

        public IslemDurum()
        {
            this.Tip = IslemMesajTip.Basarili;
        }
    }
}