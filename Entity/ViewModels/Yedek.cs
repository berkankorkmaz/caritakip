using Entity.Models;
using System.Collections.Generic;

namespace Entity.ViewModels
{
    public class Yedek
    {
        public List<CariGrup> Gruplar { get; set; }
        public List<CariHesap> Cariler { get; set; }
        public List<HesapHareket> HesapHareketleri { get; set; }
        
    }
}
