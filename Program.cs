// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/
/*double[,] Create2DRandomArray ( int rows, int columns)
{
    double[,] array = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
       for (int j = 0; j < columns; j++)
       {
          array[i,j] = new Random().NextDouble() * 100;
       }
       
    }
    return array;
}
void Show2DArray (double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
       for (int j = 0; j < array.GetLength(1); j++)
       {
          Console.Write(array[i,j]+" ");
       }
       Console.WriteLine();
    }
}
Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());
Show2DArray(Create2DRandomArray(rows,columns));*/

