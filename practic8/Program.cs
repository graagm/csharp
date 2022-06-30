// Задача 53

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

// Console.WriteLine("введите величину массива");
// int N = int.Parse(Console.ReadLine());
// int M = int.Parse(Console.ReadLine());
// int [,] ms = new int [N,M];
// msStart(ms);
// Console.WriteLine();
// msPrint(ms);
// for (int i=0;i<M;i++)
// {
//     (ms[0,i], ms[N-1,i]) = (ms[N-1,i], ms[0,i]);
// }
// Console.WriteLine();
// msPrint(ms);



// Задача 55

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

// Console.WriteLine("введите величину массива");
// int N = int.Parse(Console.ReadLine());
// int M = int.Parse(Console.ReadLine());
// int [,] ms = new int [N,M];
// msStart(ms);
// Console.WriteLine();
// msPrint(ms);
// if(N != M){
//     Console.WriteLine("Невозможно поменять столбцы и строки местами");
//     return;
// }
// for (int i=0;i<N;i++)
// {
//     for (int j=i;j<N;j++)
//     {
//         (ms[i,j], ms[j,i]) = (ms[j,i], ms[i,j]);            
//     }
    
// }
// Console.WriteLine();
// msPrint(ms);



// Задача 57

// using System.Linq;

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

// Console.WriteLine("введите величину массива");
// int N = int.Parse(Console.ReadLine());
// int M = int.Parse(Console.ReadLine());
// int [,] ms = new int [N,M];
// msStart(ms);
// Console.WriteLine();
// msPrint(ms);

// int [] ms1 = new int [N*M];
// int j = 0;
// int k = 0;
// for (int i=0;i<N*M;i++)
// {   
//     ms1[i] = ms[k,j];
//     if (j+1 < M){
//         j++;
//     }
//     else
//     {
//         j = 0;
//         k++;
//     }
// }
// Console.WriteLine();
// foreach (var x in ms1.GroupBy(p => p))
// 	Console.WriteLine("{0} => {1}", x.Key, x.Count());