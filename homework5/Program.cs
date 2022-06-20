// Задача 34

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
// msStart(ms, N);
// msPrint(ms, N);
// Console.WriteLine();
// int n = 0;
// for (int i=0;i<N;i++)
// {
//     if (ms[i] % 2 == 0)
//     {
//         n++;
//     }
// }
// Console.WriteLine($"количество четных чисел {n}");

// Задача 36

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
// msStart(ms, N);
// msPrint(ms, N);
// Console.WriteLine();
// int summ = 0;
// for (int i=0;i<N;i++)
// {
//     if (i % 2 == 1)
//     {
//         summ += ms[i];
//     }
// }
// Console.WriteLine($"Сумма элементов с нечетных позиций {summ}");


// Задача 38

// void msStart(double []ms, int N)
// {
//     for (int i=0;i<N;i++)
//     {
//          ms[i] = new Random().NextDouble() * 100;
//     }
// }
// void msPrint(double []ms, int N)
// {
//     for (int i=0;i<N;i++)
//     {
//         Console.Write($" {ms[i]}");
//     }
// }
// Console.WriteLine("введите величину массива");
// int N = int.Parse(Console.ReadLine());
// double [] ms = new double [N];
// msStart(ms, N);
// msPrint(ms, N);
// Console.WriteLine();
// int min = 0;
// int max = 0;
// for (int i=0;i<N;i++)
// {
//     if (ms[i] > ms[max])
//     {
//         max = i;
//     }
//         if (ms[i] < ms[min])
//     {
//         min = i;
//     }
// }
// double diff = Math.Round(Math.Abs(ms[max] - ms[min]), 3);
// Console.WriteLine($"Разница между макс и мин эелементами массива {diff}");