// int N = 9;
// int [] ms = new int [N];
// for(int i=0; i<N; i++)
// {
//     ms[i] = new Random().Next(10, 29);
//     Console.WriteLine(ms[i]);
// }

// int FindMaxOfThree(int x, int y, int z)
// {
//     int max;
//     if (x > y)
//     {
//         max = x;
//     }
//     else
//     {
//         max = y;
//     }
//     if(z > max)
//     {
//         max = z;
//     }
//     return max;
// }

// Console.WriteLine(FindMaxOfThree(7, 9, 0));

int N = int.Parse(Console.ReadLine());
int [] ms = new int [N];
int x  = int.Parse(Console.ReadLine());
int find = -1;
for(int i=0; i<N; i++)
{
    ms[i] = new Random().Next(10, 139);
    if (ms[i] == x)
    {if (find < 0)
    {
        find = i;
    }
        
    }
}

if (find >= 0)
{
    Console.WriteLine($"Искомый индекс равен {find}");
}
else 
{
    Console.WriteLine($"Такого эелемента нет");
}