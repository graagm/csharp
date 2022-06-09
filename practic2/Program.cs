// Задача 1

// Console.WriteLine("Введите трехзначное число");
// int x = int.Parse(Console.ReadLine());
// x = x % 10 + (x / 100) * 10;
// Console.WriteLine($"после обрезки получилось число {x}");

// Задача 2

// Console.WriteLine("Введите 2 целых числа");
// int x = int.Parse(Console.ReadLine());
// int y = int.Parse(Console.ReadLine());
// int z = x % y;
// if (z == 0)
// {
//     Console.WriteLine("кратно");
// }
// else
// {
//     Console.WriteLine($"не кратно, остаток {z}");
// }

// Задача 3

Console.WriteLine("Введите целое число и мы проверим делится ли оно оновременно на 7 и на 23");
int x = int.Parse(Console.ReadLine());
if ((x % 7 == 0) & (x % 23 == 0))
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}