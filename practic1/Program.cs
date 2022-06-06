// See https://aka.ms/new-console-template for more information

// Задача1

// Console.WriteLine("Hello, World!");
// int x;
// x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(x * x);

// Задача2
// int x, y;
// Console.WriteLine("Введите 2 числа для проверки является ли втрое квадратом первого");
// x = int.Parse(Console.ReadLine());
// y = int.Parse(Console.ReadLine());
// if (Math.Pow(x,2) == y) 
// {
//     Console.WriteLine("Да");
// }
// else
// {
//     Console.WriteLine("Нет");
// }

// Задача3
Console.WriteLine("введите день недели от 1 до 7");
string day; 
int num = int.Parse(Console.ReadLine());
if (num == 1)
{
    Console.WriteLine("Понедельник");
}
else if (num == 2)
{
    Console.WriteLine("Вторник");
}
else if (num == 3)
{
    Console.WriteLine("Среда");
}
else if (num == 4)
{
    Console.WriteLine("Четверг");
}
else if (num == 5)
{
    Console.WriteLine("Пятница");
}
else if (num == 6)
{
    Console.WriteLine("Суббота");
}
else if (num == 7)
{
    Console.WriteLine("Воскресенье");
}