using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Sayı girin:");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("İkinci sayı girin:");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int pisagorSonucu = Pisagor(num1, num2);
        double kok = Math.Sqrt(pisagorSonucu);

        Console.WriteLine("Sonucun karekökü: {0}", kok);
    }

    static int Pisagor(int num1, int num2)
    {
        return num1 * num1 + num2 * num2;
    }
}
