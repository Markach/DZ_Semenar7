//// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив: 1 4 7 2 // 5 9 2 3 // 8 4 2 4 // 17 -> такого числа в массиве нет
void FillArray(int[,] table)
    {
    Random random = new Random();
        for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                    {
                        table[i,j] = random.Next(100);
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
int[,] table = new int[7,10];
FillArray(table);
PrintArray(table);
void Number()
    {
        Console.WriteLine("Введите первое число(позиция элемента в строке) ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число (позиция элемента в столбце) ");
        int n = Convert.ToInt32(Console.ReadLine());
            if(m > table.GetLength(0)-1) Console.WriteLine("Нет такого числа в массиве ");
                else if (n > table.GetLength(1)-1) Console.WriteLine("Нет такого числа в массиве ");
                    else
                        {
                            Console.WriteLine("Значение элемента не заданной позиции: " + table[m,n]);
                        }
    }
try
{
    Number();
}
catch 
{
    Console.WriteLine("Нужно вводить число ");
}


