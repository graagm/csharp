// Задача 69

// void PrintDigit(int x, int y)
// {
//     if (x == y + 1)
//     {
//         return;
//     }
//     else
//     {
        
//         Console.Write($"{x} ");
//         PrintDigit(++x, y);
//     }
// }

// Console.WriteLine("введите 2 числа  и выведем диапазон");
// int N = int.Parse(Console.ReadLine());
// int M = int.Parse(Console.ReadLine());
// PrintDigit(N, M);

// Задача 66

// int PrintDigit(int x, int y)
// {
//     int summ = 0;
//     if (x == y)
//     {
//         return y;
//     }
//     else
//     {
        
//         summ += x;
//         return(summ + PrintDigit(++x, y));
//     }
// }

// Console.WriteLine("введите 2 числа  и выведем сумму");
// int N = int.Parse(Console.ReadLine());
// int M = int.Parse(Console.ReadLine());
// Console.WriteLine(PrintDigit(N, M));


// Задача 68

// int Akkermann(int x, int y)
// {

//     if (x == 0)
//     {
//         return (y + 1);
//     }
//     else if (x > 0 & y == 0)
//     {
//         return(Akkermann(x-1, 1));
//     }

//     else 
//     {
//         return(Akkermann(x-1, Akkermann(x, y-1)));
//     }
// }

// Console.WriteLine("введите 2 числа  и выведем результат функции Аккермана");
// int N = int.Parse(Console.ReadLine());
// int M = int.Parse(Console.ReadLine());
// Console.WriteLine(Akkermann(N, M));