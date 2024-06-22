
using System;

namespace BELARUS.Data
{
    public partial class Kaynak
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int No { get; set; } = 0;
        public string Ad { get; set; } = "";
        public string Aciklama { get; set; } = "";
        public string Dosya { get; set; } = "";
        public Nullable<System.DateTime> Tarih { get; set; } = DateTime.Now;
        public Nullable<bool> Durum { get; set; } = false;
    }
}
