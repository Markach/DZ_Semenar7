 // Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
void FillArray(int[,] table)
    {
    Random random = new Random();
    for (int i = 0; i < table.GetLength(0); i++)
        {
            for (int j = 0; j < table.GetLength(1); j++)
                {
                    table[i,j] = random.Next(1,10);
                }
        }
    }
void PrintArray(int[,] table)
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
double Average(int[,] table)
    {
        double average =0;
            for(int j=0;j<table.GetLength(1); j++)
                {
                    double sum=0; 
                        for (int i = 0; i < table.GetLength(0); i++)
                            {
                                sum+= table[i,j];
                                average = sum/table.GetLength(0);
                            }
                Console.WriteLine($"Среднее арифметическое {j+1} столбца: " + average);
                }
    return average;
    }
int[,] table = new int[4,5];
FillArray(table);
PrintArray(table);
Average(table);

