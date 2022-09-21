// Задана целочисленная матрица, состоящая из N строк и M столбцов. Требуется транспонировать ее относительно горизонтали. 
Console.WriteLine(" Введите количество строк : ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Введите количество столбцов : ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
       matrix[i, j] = new Random().Next(1,10);
       Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();
int[,] a = new int[n, m];
for (int i = 0; i < a.GetLength(0); i++)
{
    for (int j = 0; j < a.GetLength(1); j++)
   {
    a[i, j] = matrix[matrix.GetLength(0) - i - 1, j];;
 
    Console.Write($"{a[i, j]} ");
    }
Console.WriteLine();
}
