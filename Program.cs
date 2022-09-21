namespace Ornek_Proje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SifreKontrol sifreKontrol = new SifreKontrol();
            sifreKontrol.Password();
            BankaMatik bankaMatik = new BankaMatik();
            bankaMatik.BankaBilgileri();
            
        }
    }
}