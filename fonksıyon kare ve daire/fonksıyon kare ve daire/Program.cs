using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("İki farklı rakam girin:");

        Console.Write("1. rakamı girin: ");
        double sayi1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("2. rakamı girin: ");
        double sayi2 = Convert.ToDouble(Console.ReadLine());

       
        double dikdortgenAlan = sayi1 * sayi2;
        Console.WriteLine("Dikdörtgenin Alanı: " + dikdortgenAlan);

        
        double daireAlan = Math.PI * Math.Pow(sayi1, 2);
        Console.WriteLine("Dairenin Alanı: " + daireAlan);
    }
}
