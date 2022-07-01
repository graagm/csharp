// Задача 54

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


// void msSort(int [,]ms)
// {
// 	for(int i=0;i<ms.GetLength(0);i++)
//     {
//         int max = ms[i,0];
//         for(int j=0;j<ms.GetLength(1)-1;j++)
//         {
// 	        for(int k=j+1;k<ms.GetLength(1);k++)
//             {
//                 if(ms[i,k] > ms[i,j])
//                 {
//                     (ms[i,k], ms[i,j]) = (ms[i,j], ms[i,k]);
//                 }
//             }
// 	    }
//     }
// }

// Console.WriteLine("введите величину массива");
// int N = int.Parse(Console.ReadLine());
// int M = int.Parse(Console.ReadLine());
// int [,] ms = new int [N,M];
// msStart(ms);
// Console.WriteLine();
// msPrint(ms);
// msSort(ms);
// Console.WriteLine();
// msPrint(ms);


// Задача 56

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
// Console.WriteLine();
// int row = 0;
// int fixSumm = 999999999;
// for (int i=0;i<N;i++)
// {
//     int tempSumm = 0;
//     for (int j=0;j<M;j++)
//     {
//         tempSumm += ms[i,j];
//     }
//     if(tempSumm < fixSumm)
//     {
//         fixSumm = tempSumm;
//         row = i;
//     }
// }
// Console.Write($"Строка c индексом {row} имеет минимальную сумму {fixSumm}");
// Console.WriteLine();
// for (int j=0;j<M;j++)
// {
//     Console.Write($"{ms[row,j]} ");
// }


// Задача 58

// void msStart (int [,] ms)
// {
// 	for(int i=0; i<ms.GetLength(0);i++)
//     {
//         for(int j=0;j<ms.GetLength(1);j++)
//         {
// 	        ms[i, j] = new Random().Next(0, 2);
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


// Console.WriteLine("введите кол-во строк первой матрицы");
// int N = int.Parse(Console.ReadLine());
// Console.WriteLine("введите кол-во столбцов первой матрицы");
// int M = int.Parse(Console.ReadLine());
// int [,] ms = new int [N,M];
// Console.WriteLine("введите кол-во строк второй матрицы");
// int X = int.Parse(Console.ReadLine());
// int [,] ms2 = new int [M,X];
// msStart(ms);
// msStart(ms2);
// Console.WriteLine();
// msPrint(ms);
// Console.WriteLine();
// msPrint(ms2);
// int [,] msRezult = new int [N,X];

// for (int i=0;i<N;i++)
// {
//     for (int j=0;j<X;j++)
//     {
//         int summ = 0;
//         for (int z=0;z<M;z++)
//         {
//             summ += ms[i,z] * ms2[z, j];
//         }
//         msRezult[i,j] = summ;
//     }

// }

// Console.WriteLine();
// msPrint(msRezult);


// Задача 60

// using System.Collections.Generic;

// void msStart (int [,,] ms)
// {
// 	HashSet<int> set1 = new HashSet<int>();
//     for(int i=0; i<ms.GetLength(0);i++)
//     {
//         for(int j=0;j<ms.GetLength(1);j++)
//         {
// 	        for(int k=0;k<ms.GetLength(2);k++)
//             {
//                 int temp = new Random().Next(10, 100);
//                 while (set1.Contains(temp))
//                 {
//                     temp = new Random().Next(10, 100);
//                 }
//                 ms[i,j,k] = temp;
//                 set1.Add(temp);
//             }
            
// 	    }
//     }
// }

// void msPrint(int [,,]ms)
// {
// 	for(int z=0;z<ms.GetLength(2);z++)
//     { 
//         Console.WriteLine();
//         Console.WriteLine($"уровень {z}");
//         for(int i=0;i<ms.GetLength(0);i++)
//         {
// 	        for(int j=0;j<ms.GetLength(1);j++)
//             {
//                 Console.Write($"{ms[i, j, z]} ");
//             }
//             Console.WriteLine();
// 	    }
//     }
// }


// Console.WriteLine("введите кол-во строк");
// int N = int.Parse(Console.ReadLine());
// Console.WriteLine("введите кол-во столбцов");
// int M = int.Parse(Console.ReadLine());
// Console.WriteLine("введите кол-во уровней");
// int X = int.Parse(Console.ReadLine());
// int [,,] ms = new int [N,M,X];
// msStart(ms);
// Console.WriteLine();
// msPrint(ms);


// Задача 62

// void msPrint(int [,]ms)
// {
// 	for(int i=1;i<ms.GetLength(0)-1;i++)
//     {
//         for(int j=1;j<ms.GetLength(1)-1;j++)
//         {
// 	        Console.Write($"{ms[i,j]}\t");
// 	    }
//         Console.WriteLine();
//     }
// }

// Console.WriteLine("введите кол-во строк");
// int N = int.Parse(Console.ReadLine());
// Console.WriteLine("введите кол-во столбцов");
// int M = int.Parse(Console.ReadLine());
// int [,] ms = new int [N+2,M+2];
// for(int i=0; i<ms.GetLength(0);i++)
//     {
//         for(int j=0;j<ms.GetLength(1);j++)
//         {
//             if(i == 0 || j == 0 || i == N + 1 || j == M + 1)
//             {
//                 ms[i,j] = -1;
//             }
//             else
//             {
//                 ms[i,j] = 0;
//             }
//         }
//     }
// int k = 1;
// int row = 1;
// int col = 1;
// for(int i=0; i<N*M;i++)
//     {
//         ms[row, col] = k++;
//         if (ms[row-1, col] == 0 & ms[row, col-1] != 0)
//         {
//             row--;
//         }
//         else if (ms[row, col+1] == 0 & ms[row, col-1] != 0)
//         {
//             col++;
//         }
//         else if (ms[row, col+1] != 0 & ms[row+1, col] != 0)
//         {
//             col--;
//         }
//          else if (ms[row, col+1] != 0 & ms[row+1, col] == 0)
//         {
//             row++;
//         }

//     }
// Console.WriteLine();
// msPrint(ms);