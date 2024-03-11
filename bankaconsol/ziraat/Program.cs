
namespace BankaProgramı
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Ziraat Bankasına Hoş Geldiniz");
            Console.WriteLine("Şifrenizi Giriniz");
            int sifre = int.Parse(Console.ReadLine());
            int bakiye = 1000;
            int kalan = 0;

            if (sifre == 1234)
            {
                Console.WriteLine("Yapmak İstediğiniz İşlemi Seçin");
                Console.WriteLine("a) Para Çekme");
                Console.WriteLine("b) Bakiye Girişi");

                string islem = Console.ReadLine();

                if (islem == "a")
                {
                    Console.WriteLine("Çekmek İstediğiniz Para Miktarını Girin");
                    int para = int.Parse(Console.ReadLine());

                    if (para <= bakiye)
                    {
                        kalan = bakiye - para;
                        bakiye = kalan;
                        Console.WriteLine("İyi Günler Dileriz");
                        Console.WriteLine("Kalan Bakiye: " + kalan);
                    }
                    else
                    {
                        Console.WriteLine("Yetersiz Bakiye");
                        Console.WriteLine("Yeni Para Miktarını Seçin");
                        int yeniPara = int.Parse(Console.ReadLine());

                        if (yeniPara <= bakiye)
                        {
                            kalan = bakiye - yeniPara;
                            bakiye = kalan;
                            Console.WriteLine("İyi Günler Dileriz");
                            Console.WriteLine("Kalan Bakiye: " + kalan);
                        }
                        else
                        {
                            Console.WriteLine("Kart İade İşlemi Başarısız");
                        }
                    }
                }
                else if (islem == "b")
                {
                    Console.WriteLine("Bakiyeniz 1000 TL'dir");
                    Console.WriteLine("Kart İadesi");
                    bakiye = 1000;

                }
            }
            else
            {
                    Console.WriteLine("Şifre Hatalı");
                }
            }
        }
    }

