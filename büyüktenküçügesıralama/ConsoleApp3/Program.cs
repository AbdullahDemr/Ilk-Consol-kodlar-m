




using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("1. Sayıyı giriniz: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("2. Sayıyı giriniz: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.Write("3. Sayıyı giriniz: ");
        int num3 = int.Parse(Console.ReadLine());

        Console.Write("4. Sayıyı giriniz: ");
        int num4 = int.Parse(Console.ReadLine());

        if (num1 > num2 && num1 > num3 && num1 > num4 && num2 > num3 && num2 > num4 && num3 > num4)
            Console.Write("{0}>{1}>{2}>{3}", num1, num2, num3, num4);
        else if (num1 > num2 && num1 > num3 && num1 > num4 && num2 > num3 && num2 > num4 && num4 > num3)
            Console.Write("{0}>{1}>{2}>{3}", num1, num2, num4, num3);
        else if (num1 > num4 && num1 > num3 && num1 > num4 && num4 > num2 && num4 > num3 && num2 > num3)
            Console.Write("{0}>{1}>{2}>{3}", num1, num4, num2, num3);
        else if (num1 > num3 && num1 > num2 && num1 > num3 && num4 > num2 && num4 > num3 && num3 > num2)
            Console.Write("{0}>{1}>{2}>{3}", num1, num4, num3, num2);
        else if (num1 > num3 && num1 > num4 && num1 > num2 && num3 > num4 && num3 > num2 && num4 > num2)
            Console.Write("{0}>{1}>{2}>{3}", num1, num3, num4, num2);
        else if (num1 > num4 && num1 > num2 && num1 > num3 && num3 > num2 && num3 > num4 && num2 > num4)
            Console.Write("{0}>{1}>{2}>{3}", num1, num3, num2, num4);
        else if (num2 > num1 && num2 > num4 && num2 > num3 && num1 > num3 && num1 > num4 && num3 > num4)
            Console.Write("{0}>{1}>{2}>{3}", num2, num1, num3, num4);
        else if (num2 > num1 && num2 > num4 && num2 > num3 && num1 > num3 && num1 > num4 && num4 > num3)
            Console.Write("{0}>{1}>{2}>{3}", num2, num1, num4, num3);
        else if (num2 > num1 && num2 > num4 && num2 > num3 && num3 > num1 && num3 > num4 && num1 > num4)
            Console.Write("{0}>{1}>{2}>{3}", num2, num3, num1, num4);
        else if (num2 > num1 && num2 > num4 && num2 > num3 && num3 > num1 && num3 > num4 && num4 > num1)
            Console.Write("{0}>{1}>{2}>{3}", num2, num3, num4, num1);
        else if (num2 > num1 && num2 > num4 && num2 > num3 && num4 > num1 && num4 > num1 && num3 > num1)
            Console.Write("{0}>{1}>{2}>{3}", num2, num4, num3, num1);
        else if (num2 > num1 && num2 > num4 && num2 > num3 && num4 > num1 && num4 > num1 && num1 > num3)
            Console.Write("{0}>{1}>{2}>{3}", num2, num3, num1, num3);
        else if (num3 > num1 && num3 > num4 && num3 > num2 && num1 > num4 && num1 > num2 && num2 > num4)
            Console.Write("{0}>{1}>{2}>{3}", num3, num1, num2, num4);
        else if (num3 > num1 && num3 > num4 && num3 > num2 && num1 > num4 && num1 > num2 && num4 > num2)
            Console.Write("{0}>{1}>{2}>{3}", num3, num1, num4, num2);
        else if (num3 > num1 && num3 > num4 && num3 > num2 && num4 > num1 && num4 > num2 && num1 > num2)
            Console.Write("{0}>{1}>{2}>{3}", num3, num4, num1, num2);
        else if (num3 > num1 && num3 > num4 && num3 > num2 && num4 > num1 && num4 > num2 && num2 > num1)
            Console.Write("{0}>{1}>{2}>{3}", num3, num4, num2, num1);
        else if (num3 > num1 && num3 > num4 && num3 > num2 && num2 > num4 && num2 > num4 && num4 > num1)
            Console.Write("{0}>{1}>{2}>{3}", num3, num2, num4, num1);
        else if (num3 > num1 && num3 > num4 && num3 > num2 && num2 > num4 && num2 > num4 && num1 > num4)
            Console.Write("{0}>{1}>{2}>{3}", num3, num2, num1, num4);
        else if (num4 > num1 && num4 > num3 && num4 > num2 && num1 > num2 && num1 > num3 && num2 > num3)
            Console.Write("{0}>{1}>{2}>{3}", num4, num1, num2, num3);
        else if (num4 > num1 && num4 > num3 && num4 > num2 && num1 > num2 && num1 > num3 && num3 > num2)
            Console.Write("{0}>{1}>{2}>{3}", num4, num1, num3, num2);
        else if (num4 > num1 && num4 > num3 && num4 > num2 && num3 > num2 && num3 > num1 && num1 > num2)
            Console.Write("{0}>{1}>{2}>{3}", num4, num3, num1, num2);
        else if (num4 > num1 && num4 > num3 && num4 > num2 && num3 > num2 && num3 > num1 && num2 > num1)
            Console.Write("{0}>{1}>{2}>{3}", num4, num3, num2, num1);
        else if (num4 > num1 && num4 > num3 && num4 > num2 && num2 > num3 && num2 > num1 && num3 > num1)
            Console.Write("{0}>{1}>{2}>{3}", num4, num2, num3, num1);
        else if (num1 == num2 && num1 > num3 && num1 > num4 && num2 > num3 && num2 > num4 && num3 > num4)
            Console.Write("{0}={1}>{2}>{3}", num1, num2, num3, num4);
        else if (num1 == num2 && num1 > num3 && num1 > num4 && num2 > num3 && num2 > num4 && num4 > num3)
            Console.Write("{0}={1}>{2}>{3}", num1, num2, num4, num3);
        else if (num1 == num3 && num1 > num2 && num1 > num4 && num3 > num2 && num3 > num4 && num2 > num4)
            Console.Write("{0}={1}>{2}>{3}", num1, num3, num2, num4);
        else if (num1 == num3 && num1 > num2 && num1 > num4 && num3 > num2 && num3 > num4 && num4 > num2)
            Console.Write("{0}={1}>{2}>{3}", num1, num3, num4, num2);
        else if (num1 == num4 && num1 > num2 && num1 > num3 && num4 > num2 && num4 > num3 && num3 > num2)
            Console.Write("{0}={1}>{2}>{3}", num1, num4, num3, num2);
        else if (num1 == num4 && num1 > num2 && num1 > num3 && num4 > num2 && num4 > num3 && num2 > num3)
            Console.Write("{0}={1}>{2}>{3}", num1, num4, num2, num3);
        else if (num2 == num3 && num2 > num1 && num2 > num4 && num3 > num1 && num3 > num4 && num1 > num4)
            Console.Write("{0}={1}>{2}>{3}", num2, num3, num1, num4);
        else if (num2 == num3 && num2 > num1 && num2 > num4 && num3 > num1 && num3 > num4 && num4 > num1)
            Console.Write("{0}={1}>{2}>{3}", num2, num3, num4, num1);
        else if (num2 == num4 && num2 > num3 && num2 > num1 && num4 > num1 && num4 > num3 && num3 > num1)
            Console.Write("{0}={1}>{2}>{3}", num2, num4, num3, num1);
        else if (num2 == num4 && num2 > num3 && num2 > num1 && num4 > num1 && num4 > num3 && num1 > num3)
            Console.Write("{0}={1}>{2}>{3}", num2, num4, num1, num3);
        else if (num3 == num4 && num3 > num2 && num3 > num1 && num4 > num1 && num4 > num2 && num1 > num2)
            Console.Write("{0}={1}>{2}>{3}", num3, num4, num1, num2);
        else if (num3 == num4 && num3 > num2 && num3 > num1 && num4 > num1 && num4 > num2 && num2 > num1)
            Console.Write("{0}={1}>{2}>{3}", num3, num4, num2, num1);
        else if (num1 == num2 && num1 == num3 && num1 > num4)
            Console.Write("{0}={1}={2}>{3}", num1, num2, num3, num4);
        else if (num1 == num2 && num1 == num4 && num1 > num3)
            Console.Write("{0}={1}={2}>{3}", num1, num2, num4, num3);
        else if (num1 == num3 && num1 == num4 && num1 > num2)
            Console.Write("{0}={1}={2}>{3}", num1, num3, num4, num2);
        else if (num3 == num2 && num3 == num4 && num4 > num1)
            Console.Write("{0}={1}={2}>{3}", num3, num4, num2, num1);
        else if (num3 == num2 && num3 == num4 && num4 == num1)
            Console.Write("{0}={1}={2}={3}", num1, num2, num3, num4);
        else if (num1 == num2 && num1 < num3 && num1 < num4 && num2 < num3 && num2 < num4 && num3 < num4)
            Console.Write("{0}={1}<{2}<{3}", num1, num2, num3, num4);
        else if (num1 == num2 && num1 < num3 && num1 < num4 && num2 < num3 && num2 < num4 && num4 < num3)
            Console.Write("{0}={1}<{2}<{3}", num1, num2, num4, num3);
        else if (num1 == num3 && num1 < num2 && num1 < num4 && num3 < num2 && num3 < num4 && num2 < num4)
            Console.Write("{0}={1}<{2}<{3}", num1, num3, num2, num4);
        else if (num1 == num3 && num1 < num2 && num1 < num4 && num3 < num2 && num3 < num4 && num4 < num2)
            Console.Write("{0}={1}<{2}<{3}", num1, num3, num4, num2);
        else if (num1 == num4 && num1 < num2 && num1 < num3 && num4 < num2 && num4 < num3 && num3 < num2)
            Console.Write("{0}={1}<{2}<{3}", num1, num4, num3, num2);
        else if (num1 == num4 && num1 < num2 && num1 < num3 && num4 < num2 && num4 < num3 && num2 < num3)
            Console.Write("{0}={1}<{2}<{3}", num1, num4, num2, num3);
        else if (num2 == num3 && num2 < num1 && num2 < num4 && num3 < num1 && num3 < num4 && num1 < num4)
            Console.Write("{0}={1}<{2}<{3}", num2, num3, num1, num4);
        else if (num2 == num3 && num2 < num1 && num2 < num4 && num3 < num1 && num3 < num4 && num4 < num1)
            Console.Write("{0}={1}<{2}<{3}", num2, num3, num4, num1);
        else if (num2 == num4 && num2 < num3 && num2 < num1 && num4 < num1 && num4 < num3 && num3 < num1)
            Console.Write("{0}={1}<{2}<{3}", num2, num4, num3, num1);
        else if (num2 == num4 && num2 < num3 && num2 < num1 && num4 < num1 && num4 < num3 && num1 < num3)
            Console.Write("{0}={1}<{2}<{3}", num2, num4, num1, num3);
        else if (num3 == num4 && num3 > num2 && num3 > num1 && num4 < num1 && num4 < num2 && num1 < num2)
            Console.Write("{0}={1}<{2}<{3}", num3, num4, num1, num2);
        else if (num3 == num4 && num3 < num2 && num3 < num1 && num4 < num1 && num4 < num2 && num2 < num1)
            Console.Write("{0}={1}<{2}<{3}", num3, num4, num2, num1);
        else if (num1 == num2 && num1 == num3 && num1 < num4)
            Console.Write("{0}={1}={2}<{3}", num1, num2, num3, num4);
        else if (num1 == num2 && num1 == num4 && num1 < num3)
            Console.Write("{0}={1}={2}<{3}", num1, num2, num4, num3);
        else if (num1 == num3 && num1 == num4 && num1 < num2)
            Console.Write("{0}={1}={2}<{3}", num1, num3, num4, num2);
        else if (num3 == num2 && num3 == num4 && num4 < num1)
            Console.Write("{0}={1}={2}<{3}", num3, num4, num2, num1);
        else if (num1 == num2 && num1 > num3 && num4 > num1 && num4 > num3)
            Console.Write("{0}>{1}={2}>{3}", num4, num2, num1, num3);
        else if (num1 == num2 && num1 < num3 && num1 > num4 && num3 > num4)
            Console.Write("{0}>{1}={2}>{3}", num3, num2, num1, num4);
        else if (num1 == num3 && num1 > num2 && num4 > num1 && num4 > num2)
            Console.Write("{0}>{1}={2}<{3}", num4, num3, num1, num2);
        else if (num1 == num3 && num1 > num4 && num2 > num1 && num2 > num4)
            Console.Write("{0}>{1}={2}>{3}", num2, num3, num1, num4);
        else if (num1 == num4 && num1 > num3 && num2 > num1 && num2 > num3)
            Console.Write("{0}>{1}={2}>{3}", num2, num4, num1, num3);
        else if (num1 == num4 && num1 > num2 && num3 > num1 && num3 > num2)
            Console.Write("{0}>{1}={2}>{3}", num3, num4, num1, num2);
        else if (num3 == num2 && num4 > num2 && num2 > num1 && num4 > num1)
            Console.Write("{0}>{1}={2}>{3}", num4, num3, num2, num1);
        else if (num3 == num2 && num2 > num4 && num1 > num2 && num1 > num4)
            Console.Write("{0}>{1}={2}>{3}", num1, num3, num2, num4);
        else if (num4 == num2 && num2 > num3 && num1 > num2 && num1 > num3)
            Console.Write("{0}>{1}={2}>{3}", num1, num2, num4, num3);
        else if (num4 == num2 && num3 > num2 && num2 > num1 && num3 > num1)
            Console.Write("{0}>{1}={2}>{3}", num3, num2, num4, num1);
        else if (num4 == num3 && num3 > num1 && num2 > num3 && num2 > num1)
            Console.Write("{0}>{1}={2}>{3}", num2, num4, num3, num1);
        else
            Console.Write("{0}>{1}={2}>{3}", num1, num4, num3, num2);


    }
}

