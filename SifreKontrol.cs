using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_Proje
{
    public class SifreKontrol
    {
        //private int _Sifre;
        //private int _Kullanici;
        public int Sifre { get; set; }
        //public int Kullanici { get; set; }
        public void Password()
        {
            int s = 3;
            do
            {
                Console.WriteLine("şifre giriniz");
                Sifre=Convert.ToInt32(Console.ReadLine());
                if (Sifre == 123)
                {
                    Console.WriteLine("Hoşgeldiniz");
                    break;
                }
                else if (Sifre!=123)
                {
                    Console.Write("{0} hakkınız kaldı yanlış şifre lütfen tekrar ",s-1);
                }
                else
                {
                    Console.WriteLine("giriş hakkınız doldu");
                }
                s--;
            }
            while (s>0);
        }
        
        
    }
}

