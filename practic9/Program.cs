// Задача 63

// void msStart (int [,] ms)
// {
// 	for(int i=0; i<ms.GetLength(0);i++)
//     {
//         for(int j=0;j<ms.GetLength(1);j++)
//         {
// 	        ms[i, j] = new Random().Next(3, 9);
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

// Console.WriteLine("введите количество строк треугольника Паскаля");
// int N = int.Parse(Console.ReadLine());
// int [] ms1 = new int [1];
// for(int i=0; i<N; i++)
// {
//     int M = i + 1;
//     int [] ms = new int [M];

//     (ms[0], ms[M - 1]) = (1, 1);
//     if (i>1)
//     {
//         for(int s=1; s<= M/2; s++)
//         {
//             (ms[s], ms[M-1-s]) = (ms1[s-1]+ms1[s], ms1[s-1]+ms1[s]);
//         }
//     }
//     int probel = N - M;
//     for (int z=0; z<probel; z++)
//     {
//         Console.Write("\t");
//     }
//     for (int j=0; j<M; j++)
//     {

//         Console.Write($"{ms[j]}\t\t");
//     }
//     Console.WriteLine();
//     Array.Resize(ref ms1, M);
//     for (int j=0; j<M; j++)
//     {
//         ms1[j] = ms[j];
//     }
// }

// void PrintDigit(int x)
// {
//     if (x == 0)
//     {
//         return;
//     }
//     else
//     {
        
//         PrintDigit(--x);
//         Console.Write($"{x } ");
//     }
// }

// Console.WriteLine("введите число и выведем все числа от 1 до..");
// int N = int.Parse(Console.ReadLine());
// PrintDigit(N);

// Задача 65

// void PrintDigit(int x, int y)
// {
//     if (x == y)
//     {
//         return;
//     }
//     else
//     {
        
//         PrintDigit(x, --y);
//         Console.Write($"{y } ");
//     }
// }

// Console.WriteLine("введите числа и выведем все числа от первого до второго");
// int N = int.Parse(Console.ReadLine());
// int M = int.Parse(Console.ReadLine());
// PrintDigit(N, M+1);


// Задача 67

// int PrintDigit(int x)
// {
//     int summ = 0;
//     if (x == 0)
//     {
//         return 0;
//     }
//     else
//     {
        
//         summ +=  x % 10;
//         return(summ += PrintDigit(x / 10));
//     }
// }

// Console.WriteLine("введите число  и посчитаем сумму его цифр");
// int N = int.Parse(Console.ReadLine());
// Console.WriteLine(PrintDigit(N));


// Задача 69

// int PrintDigit(int x, int y)
// {
//     int stepen = 1;
//     if (y == 0)
//     {
//         return 1;
//     }
//     else
//     {
        
//         stepen *=  x;
//         return(stepen *= PrintDigit(x, --y));
//     }
// }

// Console.WriteLine("введите 2 числа  и посчитаем степень первого в величине второго");
// int N = int.Parse(Console.ReadLine());
// int M = int.Parse(Console.ReadLine());
// Console.WriteLine(PrintDigit(N, M));