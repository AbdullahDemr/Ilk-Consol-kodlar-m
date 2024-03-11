Console.WriteLine("3 basamaklı bir sayı giriniz: ");
int sayi = Convert.ToInt32(Console.ReadLine());
int sayi1 = sayi / 100;
int sayi2 = sayi / 10 % 10;
int sayi3 = sayi % 10;
int toplam = sayi1 + sayi2 + sayi3;
Console.WriteLine("Girdiğiniz sayının rakamlarının toplamı: " + toplam);
