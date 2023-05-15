// Homework 6

// Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.

// int PosNum(int M)
// {
//     int count = 0;
//     for( int i= 0 ; i < M; i++)
//     {
//         int n = Convert.ToInt32(Console.ReadLine());
//         if (n >= 0)
//         {
//             count++;
//         }

//     }
//     return count; 
// }
// Console.WriteLine("Введите числа");
// int num =Convert.ToInt32(Console.ReadLine());

// Console.Write(PosNum(num));
// Console.WriteLine(" положительных чисел ввел пользователь");

//  Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, 
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//  значения b1, k1, b2 и k2 задаются пользователем.

// double ReadData(string msg)
// {
//     Console.WriteLine(msg);
//     return Convert.ToDouble(Console.ReadLine() ?? "0");
// }

// double xVolume(double b1, double k1, double b2, double k2)
// {
//     double xVol = (b2 - b1) / (k1 - k2);
//     return xVol;
// }

// double yVolume(double b1, double k1, double x)
// {
//     double y = k1 * x + b1;
//     return y;
// }
// double b1 = ReadData("Введите значение b1: ");
// double k1 = ReadData("Введите значение k1: ");
// double b2 = ReadData("Введите значение b2: ");
// double k2 = ReadData("Введите значение k2: ");


// double x = xVolume(b1, k1, b2, k2);
// double y = yVolume(b1, k1, x);

// Console.WriteLine("Значение Х = " + x);
// Console.WriteLine("Значение Y = " + y);
