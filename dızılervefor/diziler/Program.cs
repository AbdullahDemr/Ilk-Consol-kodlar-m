string[] cevap = new string[10];
string[] num1 = new string[10];
string[] num2 = new string[10];
string[] num3 = new string[10];
int dogru1 = 0;
int dogru2 = 0;
int dogru3 = 0;

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("cevapalrını girin[" + i + "]: ");
    cevap[i] = Console.ReadLine();
}
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("1.ogrencı cevapalrı[" + i + "]: ");
    num1[i] = Console.ReadLine();
    if (cevap[i] == num1[i])
    {
        dogru1++;
    }
}
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("2.ogrencı cevapalrı[" + i + "]: ");
    num2[i] = Console.ReadLine();
    if (cevap[i] == num2[i])
    {
        dogru2++;
    }
}
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("3.ogrencı cevapalrı[" + i + "]: ");
    num3[i] = Console.ReadLine();

    if (cevap[i] == num3[i])
    {
        dogru3++;
    }

}
Console.WriteLine("1. ogrenciDoğru cevap sayısı (num1): " + dogru1);
Console.WriteLine("2. ogrenciDoğru cevap sayısı (num1): " + dogru2);
Console.WriteLine("3. ogrenci dogru cevap sayısı (num1): " + dogru3);

string[,] cevap = new string[3, 10];
int[] dogru = new int[3];
int index = 0;

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Cevapları girin[" + i + "]: ");
    cevap[0, i] = Console.ReadLine();
}

for (int i = 0; i < 3; i++)
{
    Console.WriteLine((i + 1) + ". öğrencinin cevaplarını girin:");
    for (int j = 0; j < 10; j++)
    {
        Console.WriteLine("Cevap[" + j + "]: ");
        cevap[i + 1, j] = Console.ReadLine();
        if (cevap[0, j] == cevap[i + 1, j])
        {
            dogru[i]++;
        }
    }
}

for (int i = 0; i < 3; i++)
{
    Console.WriteLine((i + 1) + ". öğrenci doğru cevap sayısı: " + dogru[i]);
}
string[,] cevap = new string[3, 10];
int[] dogru = new int[3];

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Cevapları girin[" + i + "]: ");
    cevap[0, i] = Console.ReadLine();
}

for (int i = 0; i < 3; i++)
{
    Console.WriteLine((i + 1) + ". öğrencinin cevaplarını girin:");
    for (int j = 0; j < 10; j++)
    {
        Console.WriteLine("Cevap[" + j + "]: ");
        cevap[i + 1, j] = Console.ReadLine();
        if (cevap[0, j] == cevap[i + 1, j])
        {
            dogru[i]++;
        }
    }
}

for (int i = 0; i < 3; i++)
{
    Console.WriteLine((i + 1) + ". öğrenci doğru cevap sayısı: " + dogru[i]);
}
string[,] cevap = new string[3, 10];
int[] dogru = new int[3];

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Cevapları girin[" + i + "]: ");
    cevap[0, i] = Console.ReadLine();
}

for (int i = 0; i < 3; i++)
{
    Console.WriteLine((i + 1) + ". öğrencinin cevaplarını girin:");
    for (int j = 0; j < 10; j++)
    {
        Console.WriteLine("Cevap[" + j + "]: ");
        cevap[i, j] = Console.ReadLine();
        if (cevap[0, j] == cevap[i, j])
        {
            dogru[i]++;
        }
    }
}

for (int i = 2; i >= 0; i--)
{
    Console.WriteLine((i - 1) + ". öğrenci doğru cevap sayısı: " + dogru[i]);
}
string[,] cevap = new string[3, 10];
int[] dogru = new int[3];

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Cevapları girin[" + i + "]: ");
    cevap[0, i] = Console.ReadLine();
}

for (int i = 0; i < 3; i++)
{
    Console.WriteLine((i + 1) + ". öğrencinin cevaplarını girin:");
    for (int j = 0; j < 10; j++)
    {
        Console.WriteLine("Cevap[" + j + "]: ");
        cevap[i, j] = Console.ReadLine();
        if (cevap[0, j] == cevap[i, j])
        {
            dogru[i]++;
        }
    }
}

for (int i = 0; i < 3; i++)
{
    Console.WriteLine((i + 1) + ". öğrenci doğru cevap sayısı: " + dogru[i]);
}
string[] cevaplar = new string[10];
int[] dogruCevapSayisi = new int[3];

Console.WriteLine("Cevapları girin:");
for (int i = 0; i < 10; i++)
{
    Console.Write("Soru " + (i + 1) + ": ");
    cevaplar[i] = Console.ReadLine();
}

for (int i = 0; i < 3; i++)
{
    Console.WriteLine((i + 1) + ". öğrencinin cevaplarını girin:");
    for (int j = 0; j < 10; j++)
    {
        Console.Write("Soru " + (j + 1) + ": ");
        string cevap = Console.ReadLine();

        if (cevap == cevaplar[j])
        {
            dogruCevapSayisi[i]++;
        }
    }
}

for (int i = 0; i < 3; i++)
{
    Console.WriteLine((i + 1) + ". öğrencinin doğru cevap sayısı: " + dogruCevapSayisi[i]);
}

string[] cevaplar = new string[10];
int[] dogruCevapSayisi = new int[3];

Console.WriteLine("Cevapları girin (cevapları aralarında boşluk bırakarak yan yana girin):");
string cevaplarStr = Console.ReadLine();
cevaplar = cevaplarStr.Split(' ');

for (int i = 0; i < 3; i++)
{
    Console.WriteLine((i + 1) + ". öğrencinin cevaplarını girin (cevapları aralarında boşluk bırakarak yan yana girin):");
    string ogrenciCevaplariStr = Console.ReadLine();
    string[] ogrenciCevaplari = ogrenciCevaplariStr.Split(' ');

    for (int j = 0; j < 10; j++)
    {
        if (j < ogrenciCevaplari.Length && cevaplar[j] == ogrenciCevaplari[j])
        {
            dogruCevapSayisi[i]++;
        }
    }
}

for (int i = 0; i < 3; i++)
{
    Console.WriteLine((i + 1) + ". öğrencinin doğru cevap sayısı: " + dogruCevapSayisi[i]);
}
