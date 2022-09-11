//47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами. m = 3, n = 4. 0,5 7 -2 -0,2// 1 -3,3 8 -9,9// 8 7,8 -7,1 9
void PrintArray(double[,] table)
    {
         for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                    {
                        Console.Write(table[i,j] + "\t" );
                    }
            Console.WriteLine();
            }
    }
double[,] FillArray(double[,] array)
    {
    Random random = new Random();
        for (int i=0;i<array.GetLength(0);i++)
            {
                for (int j=0;j<array.GetLength(1);j++) 
                    {
                        array[i,j] = (random.NextDouble()*10)-(random.NextDouble()*10);
                    }
            }
            return array;
    }
void Number()
{
Console.WriteLine("Введите количество строк двумерного массива ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов  двумерного массива ");
int n = Convert.ToInt32(Console.ReadLine());
    double[,] mas = new double [m,n];
    FillArray(mas);
    PrintArray(mas);
}
try
{
    Number();
}
catch 
{
    Console.WriteLine("Нужно вводить число ");
}
