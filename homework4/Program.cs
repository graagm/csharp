// Задача 25

// Console.WriteLine("введите 2 числа для расчета степени первого в величине второго");
// int x = int.Parse(Console.ReadLine());
// int y = int.Parse(Console.ReadLine());
// int s = 1;
// for (int i=0;i<y;i++)
// {
//     s *= x;
// }

// Console.WriteLine($"степень равна {s}");

// Задача 27

// Console.WriteLine("введите число для расчета суммы его цифр");
// int x = int.Parse(Console.ReadLine());
// int s = x.ToString().Length;
// int summ = 0;
// for (int i=0;i<s;i++)
// {
//     summ += x % 10;
//     x /= 10;
// }
// Console.WriteLine($"Сумма цифр получилась {summ}");

// Задача 29

// void msBegin(int[]ms, int N)
// {
//     for (int i=0;i<N;i++)
//     {
//         ms[i] = new Random().Next(1, 19);
//     }
// }
// void msPrint(int[]ms, int N)
// {
//     for (int i=0;i<N;i++)
//     {
//         Console.Write($" {ms[i]}");
//     }
// }

// Console.WriteLine("введите величину массива");
// int N = int.Parse(Console.ReadLine());
// int [] ms = new int [N];
// msBegin(ms, N);
// Console.WriteLine();
// Console.WriteLine("наш массив такой");
// msPrint(ms,  N);