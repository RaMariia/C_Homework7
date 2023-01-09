//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
void CreateRandom2dArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
        for(int j = 0; j < array.GetLength(1); j++)
            array[i,j] = Convert.ToDouble(new Random().Next(-100, 100))/10;

}

void Show2dArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
}

Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[rows, columns];
CreateRandom2dArray(array);
Show2dArray(array);
*/

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//1 7 -> числа с такими индексами в массиве нет

/*
Console.WriteLine("введите номер строки");
int numRows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите номер столбца");
int numColumns = Convert.ToInt32(Console.ReadLine());
int [,] array = new int [4,4];
CreateArrayRandomNumbers(array);

if (numRows > array.GetLength(0) || numColumns > array.GetLength(1))
{
    Console.WriteLine("такого элемента нет");
}
else
{
    Console.WriteLine($"Значение элемента c индексами {numRows} и {numColumns} : {array[numRows-1,numColumns-1]}");
}

ShowArray(array);

void CreateArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(-100, 100)/10;
            }   
        }
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }   
        Console.Write("]");
        Console.WriteLine(""); 
    }
}
*/

//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

/*
Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows, columns];
CreateRandom2dArray(array);

for (int j = 0; j < array.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        avarage = (avarage + array[i,j]);
    }
    avarage = avarage / columns;
    Console.Write(avarage + "; ");
}
Console.WriteLine();
Show2dArray(array);

void CreateRandom2dArray(int[,] array)
{
   
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
}
*/