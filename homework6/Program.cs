// Задача 41

// Console.WriteLine("введите количество чисел");
// int N = int.Parse(Console.ReadLine());

// int s = 0;
// int x = 0;

// Console.WriteLine($"введите {N} чисел");
// for (int i=0;i<N;i++)
// {
//     x = int.Parse(Console.ReadLine());
//     if(x > 0)
//     {
//         s++;
//     }
// }

// Console.WriteLine();
// Console.WriteLine($"количество положительных {s}");

// Задача 43

// Console.WriteLine("задайте 2 прямые через коэффициенты уравнения y = k*x + b");
// double k1 = double.Parse(Console.ReadLine());
// double b1 = double.Parse(Console.ReadLine());
// double k2 = double.Parse(Console.ReadLine());
// double b2 = double.Parse(Console.ReadLine());
// double x, y;
// if (k1 == k2 & b1 == b2)
// {
//     Console.WriteLine("прямые совпали");
//     return;
// }
// if (k1 == k2 || k1 * b2 == k2 * b1 )
// {
//     Console.WriteLine("прямые параллельны");
//     return;
// }
// y = ((k2 * b1) - (k1 * b2))/(k2 - k1);
// Console.WriteLine($"координата y =  {Math.Round(y, 2)}");
// x = (y - b1) / k1;
// Console.WriteLine($"координата x =  {Math.Round(x, 2)}");