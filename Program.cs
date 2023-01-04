// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// double [,] Create2DArray (int rows, int cols, double min, double max){
//     double[,] array = new double [rows, cols];
//     for (int i=0; i<rows; i++){
//         for (int j=0; j<cols; j++){
//             array[i,j] = min + new Random().NextDouble()*(max-min);
//         }
//     }
//     return array;
// }
// void ShowArray (double [,] array){
//     for (int i=0; i<array.GetLength(0); i++){
//         for (int j=0; j<array.GetLength(1); j++){
//             Console.Write($"{Math.Round(array[i,j], 2)} ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.Write("Введите кол-во строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите кол-во столбцов: ");
// int cols = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите минимальное значение элемента: ");
// double min = Convert.ToDouble(Console.ReadLine());

// Console.Write("Введите максимальное значение элемента: ");
// double max = Convert.ToDouble(Console.ReadLine());

// double [,] array = Create2DArray(rows, cols, min, max);
// ShowArray(array);


// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// int [,] Create2DArray (int rows, int cols, int min, int max){
//     int[,] array = new int [rows, cols];
//     for (int i=0; i<rows; i++){
//         for (int j=0; j<cols; j++){
//             array[i,j] = new Random().Next(min, max+1);
//         }
//     }
//     return array;
// }
// void ShowArray (int [,] array){
//     for (int i=0; i<array.GetLength(0); i++){
//         for (int j=0; j<array.GetLength(1); j++){
//             Console.Write($"{array[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// void FindElem (int [,] array, int m, int n){
//  if (m<array.GetLength(0) && n<array.GetLength(0))
//     Console.WriteLine($"{array[m,n]}");
//  else 
//     Console.WriteLine("Такого числа в массиве нет");
// }


// Console.Write("Введите кол-во строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите кол-во столбцов: ");
// int cols = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите минимальное значение элемента: ");
// int min = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите максимальное значение элемента: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int [,] array = Create2DArray(rows, cols, min, max);
// ShowArray(array);

// Console.Write("Введите положение элемента в строке: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите положение элемента в столбце: ");
// int n = Convert.ToInt32(Console.ReadLine());
// FindElem(array, m, n);

// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// int [,] Create2DArray (int rows, int cols, int min, int max){
//     int[,] array = new int [rows, cols];
//     for (int i=0; i<rows; i++){
//         for (int j=0; j<cols; j++){
//             array[i,j] = new Random().Next(min, max+1);
//         }
//     }
//     return array;
// }
// void ShowArray (int [,] array){
//     for (int i=0; i<array.GetLength(0); i++){
//         for (int j=0; j<array.GetLength(1); j++){
//             Console.Write($"{array[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// void FindSum (int [,] array){
//     int j = 0;
//     while (j<array.GetLength(1)){
//         double sum = 0;
//         for (int i=0; i<array.GetLength(0); i++){
//             sum = sum + array[i,j];   
//         }
//         Console.Write($"{Math.Round(sum/array.GetLength(0),2)} ");
//         j++;
//     }
// }
// Console.Write("Введите кол-во строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите кол-во столбцов: ");
// int cols = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите минимальное значение элемента: ");
// int min = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите максимальное значение элемента: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int [,] array = Create2DArray(rows, cols, min, max);
// ShowArray(array);
// Console.Write("Среднее арифместическое в столбцах: ");
// FindSum(array);