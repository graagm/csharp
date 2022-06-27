// Задача 47

// void msStart (double [,] ms)
// {
// 	for(int i=0; i<ms.GetLength(0);i++)
//     {
//         for(int j=0;j<ms.GetLength(1);j++)
//         {
// 	        ms[i, j] = new Random().NextDouble();
// 	    }
//     }
// }

// void msPrint(double [,]ms)
// {
// 	for(int i=0;i<ms.GetLength(0);i++)
//     {
//         for(int j=0;j<ms.GetLength(1);j++)
//         {
// 	        Console.Write($"{Math.Round(ms[i,j], 2)} ");
// 	    }
//         Console.WriteLine();
//     }
// }

// Console.WriteLine("введите величину массива");
// int N = int.Parse(Console.ReadLine());
// int M = int.Parse(Console.ReadLine());
// double [,] ms = new double [N,M];
// msStart(ms);
// Console.WriteLine();
// msPrint(ms);


// Задача 50

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
// Console.WriteLine("введите индексы элемента массива");
// int n = int.Parse(Console.ReadLine());
// int m = int.Parse(Console.ReadLine());
// if(n > N || m > M)
// {
//     Console.WriteLine("Такого элемента в массиве нет");
//     return;
// }

// Console.WriteLine($"Искомый элемент {ms[n-1, m-1]}");


// Задача 52

void msStart (int [,] ms)
{
	for(int i=0; i<ms.GetLength(0);i++)
    {
        for(int j=0;j<ms.GetLength(1);j++)
        {
	        ms[i, j] = new Random().Next(3, 9);
	    }
    }
}

void msPrint(int [,]ms)
{
	for(int i=0;i<ms.GetLength(0);i++)
    {
        for(int j=0;j<ms.GetLength(1);j++)
        {
	        Console.Write($"{ms[i,j]} ");
	    }
        Console.WriteLine();
    }
}

Console.WriteLine("введите величину массива");
int N = int.Parse(Console.ReadLine());
int M = int.Parse(Console.ReadLine());
int [,] ms = new int [N,M];
msStart(ms);
Console.WriteLine();
msPrint(ms);
int s = 0;
for (int i=0;i<N;i++)
{
    for (int j=0;j<M;j++)
    {
        s += ms[i,j];
    }
    Console.WriteLine($"Сумма элементров строки {i+1} равно {s}");
    s = 0;
}
Console.WriteLine();
