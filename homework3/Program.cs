// Задача 19
// Console.WriteLine("Введите число и проверим, является ли оно палиндромом");
// string c = Console.ReadLine();
// int l = c.Length;
// int zt = l / 2;
// bool flag = true;
// for(int i=0;i<=zt;i++)
// {
//     if(c[i] != c[l-1-i])
//     {
//          Console.WriteLine("не палиндром");
//          flag = false;
//          break;

//     }
// }
// if (flag)
// {
//     Console.WriteLine("палиндром");
// } 

// Задача 21
// Console.WriteLine("Введите 2 точки в координатах x и y и z для нахождения расстояния между ними");
// int x1 = int.Parse(Console.ReadLine());
// int y1 = int.Parse(Console.ReadLine());
// int z1 = int.Parse(Console.ReadLine());
// int x2 = int.Parse(Console.ReadLine());
// int y2 = int.Parse(Console.ReadLine());
// int z2 = int.Parse(Console.ReadLine());
// double s = Math.Round(Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2) + Math.Pow((z1 - z2), 2)), 2);
// Console.WriteLine($"расстоняие получилось {s}");

// Задача 23
// Console.WriteLine("Введите число и выведем ряд кубов");
// int x = int.Parse(Console.ReadLine());
// for(int i=1; i<=x; i++)
// {
//     Console.Write(Math.Pow(i, 3));
//     if (i != x)
//     {
//         Console.Write(", ");
//     }
// }
// Console.Write('.');