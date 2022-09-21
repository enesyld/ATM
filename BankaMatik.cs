using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_Proje
{
    public class BankaMatik
    {
        public void BankaBilgileri()
        {
            char islem = 'a';
            int bakiye = 10000, miktar;
            char y = '4';
            do
            {
                Console.WriteLine("yapmak istediğiniz işlemi seçiniz\n 1 Para Çekme\n 2 Para Yatırma \n 3 Bakiye göster \n 4 Çıkış yap");
                islem = Convert.ToChar(Console.ReadLine());
                switch (islem)
                {
                    case '1':
                        {
                            Console.WriteLine("Çekmek istediğiniz miktarı girin");
                            miktar = Convert.ToInt32(Console.ReadLine());
                            bakiye -= miktar;
                            y = '1';
                            break;
                        }
                    case '2':
                        {
                            Console.WriteLine("Yatırmak istediğiniz miktarı girin");
                            miktar = Convert.ToInt32(Console.ReadLine());
                            bakiye += miktar;
                            y = '1';
                            break;

                        }
                    case '3':
                        {
                            Console.WriteLine("bakiye bilgisi");
                            Console.WriteLine(bakiye);
                            y = '1';
                            break;
                        }
                    case '4':
                        {
                            Console.WriteLine("çıkış yapılıyor");
                            y = '4';
                            break;
                        }
                    default:
                        Console.WriteLine("Yanlış değer girdiniz");
                        break;
                }


            }
            while (y == '1');
        }


    }
}
