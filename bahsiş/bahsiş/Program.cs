using System;

class Program
{
    static void Main()

    {
    //    string Name = "abdullah";
    //    Name.Remove(5);
    //    Console.WriteLine(Name);

        Console.WriteLine("Hesabı girin:");
        int num1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Bahsis tutarını girin:");
        int num2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Kişi sayısını girin:");
        int num3 = Convert.ToInt32(Console.ReadLine());

    float hesap = Hesaplama(num1, num2, num3);
    Console.WriteLine("Hesap: " + hesap);


      



    }

static float Hesaplama(int num1, int num2 = 10, int num3 = 1)
{
    int hesap = (num1 * num2 * num3) / 100;
    hesap += num1;

    return hesap;
}
    
        
}
