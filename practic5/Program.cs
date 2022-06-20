// Задача 31

// void msStart(int []ms, int N)
// {
//     for (int i=0;i<N;i++)
//     {
//          ms[i] = new Random().Next(-99, 100);
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
// msStart(ms, N);
// int s = 0;
// int S = 0;
// for (int i=0;i<N;i++)
// {
//   if(ms[i] < 0)
//   {
//         s += ms[i];
//   }

//   else
//     {
//         S += ms[i];
//     }
// }
// msPrint(ms, N);
// Console.WriteLine();
// Console.WriteLine($"Сумма отрицательных {s}");
// Console.WriteLine($"Сумма положительных {S}");

// Задача 32

// void msStart(int []ms, int N)
// {
//     for (int i=0;i<N;i++)
//     {
//          ms[i] = new Random().Next(-99, 100);
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
// msStart(ms, N);
// msPrint(ms, N);
// for (int i=0;i<N;i++)
// {
//     ms[i] = - ms[i];
// }
// Console.WriteLine();
// msPrint(ms, N);

// Задача 33

// void msStart(int []ms, int N)
// {
//     for (int i=0;i<N;i++)
//     {
//          ms[i] = new Random().Next(-99, 100);
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
// msStart(ms, N);
// msPrint(ms, N);
// Console.WriteLine();
// Console.WriteLine("введите Целое чилос для проверки нахождения его в массиве");
// int x = int.Parse(Console.ReadLine());
// for (int i=0;i<N;i++)
// {
//     if( ms[i] == x)
//     {
//         Console.WriteLine("Да");
//         return;
//     }
// }
// Console.WriteLine("Нет");

// Задача 35

// void msStart(int []ms, int N)
// {
//     for (int i=0;i<N;i++)
//     {
//          ms[i] = new Random().Next(-99, 100);
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
// msStart(ms, N);
// msPrint(ms, N);
// Console.WriteLine();
// int n = 0;
// for (int i=0;i<N;i++)
// {
//     if( ms[i] >= 10 & ms[i] <= 99)
//     {
//         n++;
//     }
// }
// Console.WriteLine($"количество членов массив в отрезке {n}");

// Задача 37

// void msStart(int []ms, int N)
// {
//     for (int i=0;i<N;i++)
//     {
//          ms[i] = new Random().Next(-5, 6);
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
// msStart(ms, N);
// msPrint(ms, N);
// Console.WriteLine();
// Console.WriteLine("произведение попарно выводим");
// int n = 0;
// for (int i=0;i<N/2;i++)
// {
//     Console.Write($" {ms[i] * ms[N-1-i]}");
//     if (N % 2 == 1)
//     {
//         Console.Write($" {ms[i+1]}");
//     }
// }
