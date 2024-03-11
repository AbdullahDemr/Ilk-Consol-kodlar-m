using System.ComponentModel.Design;

int cinsiyet1 = 0;
int cinsiyet2 = 0;
int cinsiyet3 = 0;

Console.WriteLine("1. çocuğun kaç yaşında?");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("1. çocuğun çinsiyeti erkerse 1  ?");
int.Parse(Console.ReadLine());

Console.WriteLine("2. çocuğun kaç yaşında? ");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine("2. çocuğun çinsiyeti erkerse 1 0 ?");
int.Parse(Console.ReadLine());

Console.WriteLine("3. çocuğun kaç yaşında  ?");
int num3 = int.Parse(Console.ReadLine());
Console.WriteLine("3. çocuğun çinsiyeti erkerse 1 ?");
 int.Parse(Console.ReadLine());

int fiyat1 = 0;
int fiyat2 = 0;
int fiyat3 = 0;
int fiyat4 = 240;

if (cinsiyet1 > 1)
{
    if (5 < num1 && num1 <= 11)
        fiyat1 = 60;
    else if (12 <= num1)
        fiyat1 = 120;

}
else if(cinsiyet1 < 1) 
{
    if (5 < num1 && num1 <= 11)
        fiyat1 = 48;
    else if (12 <= num1)
        fiyat1 = 96;

}
if (cinsiyet2 > 1)
{
    if (5 < num2 && num2 <= 11)
        fiyat2 = 60;
    else if (12 <= num2)
        fiyat2 = 120;

}
else if (cinsiyet2 < 1)
{
    if (5 < num2 && num2 <= 11)
        fiyat2 = 48;
    else if (12 <= num2)
        fiyat2 = 96;

}
if (cinsiyet3 > 1)
{
    if (5 < num3 && num3 <= 11)
        fiyat3 = 60;
    else if (12 <= num1)
        fiyat3 = 120;

}
else if (cinsiyet3 < 1)
{
    if (5 < num3 && num3 <= 11)
        fiyat3 = 48;
    else if (12 <= num3)
        fiyat3 = 96;

}










