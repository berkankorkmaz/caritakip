using Entity.Models;
using System;

namespace Entity.ViewModels
{
    public class HesapHareketiViewModel
    {
        public int CHHNo { get; set; }
        public string CariHesabi { get; set; }
        public DateTime IslemTarihi { get; set; }
        public decimal Tutar { get; set; }
        public IslemTipi IslemTipi { get; set; }
        public int VadeGunu { get; set; }
    }
}
