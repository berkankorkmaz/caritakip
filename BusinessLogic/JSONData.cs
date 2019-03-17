using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Web.Script.Serialization;
using System.Reflection;
using Entity.ViewModels;
using Entity.Models;

namespace BusinessLogic
{
    public abstract class JSONData<T> where T : class
    {
        public List<T> Liste { get; set; } = new List<T>();
        protected void Save()
        {
            JavaScriptSerializer tercuman = new JavaScriptSerializer();
            string ceviri = tercuman.Serialize(Liste);
            
            string dosyaAdi = typeof(T).ToString() + ".json";
            File.WriteAllText(dosyaAdi, ceviri);
        }
        protected void Load()
        {
            JavaScriptSerializer tercuman = new JavaScriptSerializer();
            string dosyaAdi = typeof(T).ToString() + ".json";
            if (File.Exists(dosyaAdi))
            {
                try
                {
                    string okunan = File.ReadAllText(dosyaAdi);
                    Liste = tercuman.Deserialize<List<T>>(okunan);
                }
                catch { }
            }
        }

        public void YedekAl(string path)
        {
            try
            {
                JavaScriptSerializer tercuman = new JavaScriptSerializer();
                Yedek y = new Yedek();
                y.HesapHareketleri = new HesapHareketRepository().Liste;
                y.Cariler = new CariHesapRepository().Liste;
                y.Gruplar = new CariGrupRepository().Liste;
                string sonuc = tercuman.Serialize(y);
                File.WriteAllText(path+"\\Yedek.json", sonuc);
            }
            catch { }
        }

        public Yedek YedekIceAktar(string path)
        {
            try
            {
                JavaScriptSerializer tercuman = new JavaScriptSerializer();
                Yedek y = tercuman.Deserialize<Yedek>(File.ReadAllText(path));
                return y;
                
            }
            catch
            {
                return null;
            }
        }
        
    }
}
