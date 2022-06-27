// Задача 46

// void msStart (int [,] ms)
// {
// 	for(int i=0; i<ms.GetLength(0);i++)
//     {
//         for(int j=0;j<ms.GetLength(1);j++)
//         {
// 	        ms[i, j] = new Random().Next(-10, 10);
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
// Console.WriteLine();
// msPrint(ms);
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

// Задача 48

// void msStart (int [,] ms)
// {
// 	for(int i=0; i<ms.GetLength(0);i++)
//     {
//         for(int j=0;j<ms.GetLength(1);j++)
//         {
// 	        ms[i, j] = i + j;
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
// Console.WriteLine();
// msPrint(ms);

// Задача 49

// void msStart (int [,] ms)
// {
// 	for(int i=0; i<ms.GetLength(0);i++)
//     {
//         for(int j=0;j<ms.GetLength(1);j++)
//         {
// 	        ms[i, j] = new Random().Next(1,9);
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
// Console.WriteLine();
// msPrint(ms);
// for (int i=0;i<N;i++)
// {
//     for (int j=0;j<M;j++)
//     {
//         if(i % 2 == 1 & j % 2 == 1)
//         {
//             ms[i,j] *= ms[i,j];
//         }
//     }
// }
// Console.WriteLine();
// msPrint(ms);