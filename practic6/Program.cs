// Задача 31

// void msStart (int [,] ms)
// {
// 	for(int i=0; i<ms.GetLength(0);i++)
//     {
//         for(int j=0;j<ms.GetLength(1);j++)
//         {
// 	        ms[i, j] = new Random().Next(0, 10);
// 	    }
//     }
// }

// void msPrint(int [,]ms)
// {
// 	for(int i=0;i<ms.GetLength(0);i++)
//     {
//         for(int j=0;j<ms.GetLength(1);j++)
//         {
// 	        Console.Write($"{ms[i,j]} ");
// 	    }
//         Console.WriteLine();
//     }
// }

// Console.WriteLine("введите величину массива");
// int N = int.Parse(Console.ReadLine());
// int M = int.Parse(Console.ReadLine());
// int [,] ms = new int [N,M];
// msStart(ms);

// int s = 0;
// int S = 0;

// for (int i=0;i<N;i++)
// {
//     for (int j=0;j<M;j++)
//     {
//         if(ms[i,j] < 0)
//         {
//             s += ms[i,j];
//         }
//         else
//         {
//             S += ms[i,j];
//         }
//     }
// }
// msPrint(ms);

// Console.WriteLine();
// Console.WriteLine($"Сумма отрицательных {s}");
// Console.WriteLine($"Сумма положительных {S}");

// Задача 40

// Console.WriteLine("введите 3 стороны треугольника");
// int a = int.Parse(Console.ReadLine());
// int b = int.Parse(Console.ReadLine());
// int c = int.Parse(Console.ReadLine());

// if ((a + b > c) & (b +c > a) & (a + c > b))
// {
//     Console.WriteLine("такой треугольник возможен");
// }
// else
// {
//     Console.WriteLine("С такими сторонами треугольника нет");
// }

// Задача 42
 
// Console.WriteLine("введите число и мы его преобразуем в двоичный код");
// int a = int.Parse(Console.ReadLine());
// string s = string.Empty;
// string s1 = string.Empty;
// while (a>0)
// {
//     s1 += (a % 2).ToString();
//     a /= 2;
//     s = s1 + s;
//     s1 = string.Empty;
// }


// Console.WriteLine($"двоичный код {s}");

// Задача 44
 
// Console.WriteLine("введите порядковый номер числа Фибонначи");
// int a = int.Parse(Console.ReadLine());
// int f1 = 0;
// int f2 = 1;
// int f3 = 1;
// int f4 = 0;
// Console.Write($"{f1} {f2} {f3} ");
// for (int i=0;i<a -3; i++)
// {
//     f4 = f2 + f3;
//     Console.Write($"{f4} ");
//     f1 = f2;
//     f2 = f3;
//     f3 = f4;
// }

// Задача 45

// void msCopy(int []ms,int []ms1, int N)
// {
//     for(int i=0; i<N; i++)
//     {
//         ms1[i] = ms[i];
//     }
// }

// void msStart(int []ms, int N)
// {
//     for (int i=0;i<N;i++)
//     {
//          ms[i] = new Random().Next(100, 1000);
//     }
// }
// void msPrint(int []ms, int N)
// {
//     for (int i=0;i<N;i++)
//     {
//         Console.Write($" {ms[i]}");
//     }
// }

// Console.WriteLine("введите величину массива");
// int N = int.Parse(Console.ReadLine());
// int [] ms = new int [N];
// int [] ms1 = new int [N];
// msStart(ms, N);
// msPrint(ms, N);
// Console.WriteLine();
// msCopy(ms, ms1, N);
// msPrint(ms1, N);