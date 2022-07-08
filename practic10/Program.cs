// Задача 70

// void PrintDigit(int x, int y, int count, int s)
// {   
//     if (s >= count)
//     {
//         return;
//     }
//     else
//     {
        
//         Console.Write($"{x+y} ");
//         int temp = x;
//         x = y;
//         y += temp;
//         s++;
//         PrintDigit(x, y, count, s);
//     }
// }

// Console.WriteLine("введите 3 числа  и выведем ряд чисел");
// int N = int.Parse(Console.ReadLine());
// int M = int.Parse(Console.ReadLine());
// int Z = int.Parse(Console.ReadLine());
// PrintDigit(N, M, Z, 0);

// Задача 71

//*********** !!!тут версия с семинара!!! ************************************

// string[] Words(string[] alf, int number)
// {
//     if (number == 0)
//     {
//         string[] res = new string[1];
//         res[0] = "";
//         return res;
//     };

//     string[] temp = Words(alf, number - 1);
//     string[] result = new string[temp.Length * alf.Length];
//     int index = 0;
//     for (int i = 0; i < temp.Length; i++)
//     {
//         for (int j = 0; j < alf.Length; j++)
//         {
//             result[index] = temp[i] + alf[j];
//             index++;
//         }
//     }
//     return result;
// }


// string[] alf = { "а", "с", "и", "в", "Ж" };
// Console.WriteLine("Введите N");
// int number = int.Parse(Console.ReadLine());
// Console.WriteLine();
// string[] result = Words(alf, number);

// for (int i = 0; i < result.Length; i++)
// {
//     Console.Write(i + " " + result[i] + " ");
// }


// ********** свой вариант. Тоже РЕКУРСИЯ.  Итерации !!! не вариант !!! **************************

// void AlohaAbc(char [][] ms, int row, int col, int RowCount, int ColCount, string s) // Функция сбора и печати строки исходя
// {
//     if (row == RowCount & col == 0) // вывод на печать только одного варианта строки, т.к. иначе он выведет одну и ту же строку ColCount количество раз
//     {       
//         Console.WriteLine(s);
//         return;
//     }
//     else if (row == RowCount)  // просто выход из рекурсии без печати строки, которую мы уже имеем. Нужно проработать, чтобы  лишние одинаковые строки не собирать.
//     {       
//         return;
//     }
    
//     s += ms[row][col];  //   Начальная строка с символа первой строки
//     for (int i=0; i<ColCount; i++)  //   Дальше идем по всем символам каждой из более нижних строк
//     {
//         AlohaAbc(ms, row+1, i, RowCount, ColCount, s);  //   И для нового символа опускаемся еще ниже и ищем новый символ для построения строки
//     }
    
// }

// Console.WriteLine("введите алфавит");  
// string  s = Console.ReadLine(); //   Вводим афавит строкой
// char[] symb = s.ToCharArray();  //   Переводим весь введенный алфафит в массив
// Console.WriteLine("введите количество букв в слове");
// int count = int.Parse(Console.ReadLine()); //   Задаем кол-во символов в слове, собранного из заданного алфавтита
// int n = symb.Length;  //   Узнаем длину нашего алфавита
// char[][] FullSymb = new char[count][];  //   Задаем массив из массивов. Количество массивов в нем = количество символов в слове
// for (int i=0; i<count;i++)
// {
//     FullSymb[i] = new char[n]; //   выделяем память под каждый массив внутри отцовского массива
//     symb.CopyTo(FullSymb[i], 0);  //   ну и каждый массив у нас один и тот же -набор символов алфавита
// }

// for(int i=0; i<n;i++)
// {
//     AlohaAbc(FullSymb, 0, i, count, n, "");  //   Запускаем головную функцию столько раз, сколько начлаьных символов слова мы можем получить. Это n.
// }


// Задача 71

// int [] data = {0, 1, 1, 1, 1, 0, 0, 0, 1};
// int [] info = {2, 3, 3, 1};
// int n  = 0;
// foreach (int i in info) 
// {
//     string s = "";
//     for (int j = n; j< n + i; j++)
//     {
//         s += data[j].ToString();
//     }
//     Console.Write($"{s} ");
//     int x = Convert.ToInt32(s, 2);
//     Console.Write($" это число {x} ");
//     Console.WriteLine();
//     n += i;
// }

// Задача 73

// bool CheckItem (int [] ms, int c)
// {
//     int len = ms.Length;
//     for(int i=0; i<len; i++)
//     {
//         if(c % ms[i] == 0)
//         {
//             return true;
//         }
//     }
//     return false;
// }

// void ResizeMS(int [][] ms, int z, int i)
// {
//     while(CheckItem(ms[i], z))
//     {
//         i++;
//     }
//     if (i < ms.Length)
//     {
//         Array.Resize(ref ms[i], ms[i].Length + 1);
//         ms[i][ms[i].Length-1] = z;
//     }
//     else
//     {
//         Console.WriteLine("в этот массив мы ничего не добавим");
//     }
// }

// void PrintMS(int [][] ms)
// {
//     int len = ms.Length;
//     for(int i=0; i<len; i++)
//     {
//         Console.Write($"группа {i + 1}: ");
//         int internLen = ms[i].Length;
//         for(int j=0; j<internLen; j++)
//         {
//             Console.Write($"{ms[i][j]} ");
//         }
//         Console.WriteLine();
//     }
// }


// Console.WriteLine("введите число для разбивки на группы попарно неделящихся чисел");
// int M = int.Parse(Console.ReadLine());


// int n = 0;

// while(Math.Pow(2, ++n) <= M)
// {
// }


// Console.WriteLine($"кол-во групп {n} ");

// int[][] fullMs = new int[n][];



// for(int i=0; i<n; i++)
// {
//     fullMs[i] = new int [0];
// }


// for(int i=1; i<=M; i++)
// {
//     ResizeMS(fullMs, i, 0);
// }

// PrintMS(fullMs);