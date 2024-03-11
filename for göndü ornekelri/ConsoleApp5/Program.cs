using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Kaç kez döngü çalışsın?");
        int sayi = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < sayi; i++)
        {
            Console.WriteLine("Döngü {0}. kez çalışıyor.", i + 1);
        }
        
        Console.WriteLine("Döngü tamamlandı. Çıkmak için bir tuşa basın.");
        Console.ReadKey();
    }
}
//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Bir sayı girin:");
//        int sayi = Convert.ToInt32(Console.ReadLine());

//        bool asalMi = true;

//        for (int i = 2; i <= sayi / 2; i++)
//        {
//            if (sayi % i == 0)
//            {
//                asalMi = false;
//                break;
//            }
//        }

//        if (asalMi)
//        {
//            Console.WriteLine("{0} bir asal sayıdır.", sayi);
//        }
//        else
//        {
//            Console.WriteLine("{0} bir asal sayı değildir.", sayi);
//        }

//        Console.WriteLine("Çıkmak için bir tuşa basın.");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Kaç adet Fibonacci sayısı hesaplamak istersiniz?");
//        int adet = Convert.ToInt32(Console.ReadLine());

//        int sayi1 = 0;
//        int sayi2 = 1;

//        Console.WriteLine("Fibonacci Sayıları:");

//        for (int i = 0; i < adet; i++)
//        {
//            Console.Write(sayi1 + " ");

//            int gecici = sayi1;
//            sayi1 = sayi2;
//            sayi2 = gecici + sayi2;
//        }

//        Console.WriteLine("\nÇıkmak için bir tuşa basın.");
//        Console.ReadKey();
//    }
//}
//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Bir sayı girin:");
//        int sayi = Convert.ToInt32(Console.ReadLine());

//        int faktoriyel = 1;

//        for (int i = 1; i <= sayi; i++)
//        {
//            faktoriyel *= i;
//        }

//        Console.WriteLine("{0} sayısının faktoriyeli: {1}", sayi, faktoriyel);

//        Console.WriteLine("Çıkmak için bir tuşa basın.");
//        Console.ReadKey();
//    }
//}

//Console.WriteLine("Bir sayı girin:");
//int sayi = Convert.ToInt32(Console.ReadLine());
