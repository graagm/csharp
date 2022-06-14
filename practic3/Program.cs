// Console.WriteLine("введите номер четверти");
// int P = int.Parse(Console.ReadLine());
// if (P == 1)
// {
//     Console.WriteLine("x > 0 и y > 0");
// }
// else if (P == 2)
// {
//      Console.WriteLine("x < 0 и y > 0");   
// }
// else if (P == 3)
// {
//      Console.WriteLine("x < 0 и y < 0");   
// }else if (P == 4)
// {
//      Console.WriteLine("x > 0 и y < 0");   
// }

// Задача 21

// Console.WriteLine("введите координаты x  и y 2-х точек для расчета расстояния между ними");
// int x1 = int.Parse(Console.ReadLine());
// int y1 = int.Parse(Console.ReadLine());
// int x2 = int.Parse(Console.ReadLine());
// int y2 = int.Parse(Console.ReadLine());
// double s;
// s = Math.Round(Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2)), 2);
// Console.WriteLine($"расстояние между точками равно {s}");

// Задача 22
Console.WriteLine("введите целое число и мы выведем все квадраты натуральных");
int N = int.Parse(Console.ReadLine());
for (int i=0; i<=N; i++)
{
    Console.Write(i * i);
    if ( i != N)
    {
        Console.Write(", ");
    }
}
Console.Write('.');