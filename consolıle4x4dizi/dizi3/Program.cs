int[,] matrix = new int[4, 4];
Console.WriteLine("Lütfen 4x4 matrisin elemanlarını giriniz:");
for (int i = 0; i < 4; i++)
{
    string[] row = Console.ReadLine().Split(" ");
    for (int j = 0; j < 4; j++)
    {
        matrix[i, j] = int.Parse(row[j]);
    }
}
int maxElement = matrix[0, 0];
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        if (matrix[i, j] > maxElement)
        {
            maxElement = matrix[i, j];
        }
    }
}
Console.WriteLine("Matrisin en büyük elemanı: " + maxElement);
