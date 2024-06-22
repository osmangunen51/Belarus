using System;

namespace BELARUS.Data
{
    public partial class Ayar
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int No { get; set; }
        public string SystemAd { get; set; }
        public string Deger { get; set; }
        public Nullable<bool> Durum { get; set; }
        public Nullable<System.DateTime> Tarih { get; set; }
    }
}

