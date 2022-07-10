bool NextPermutation<T>(T[] elements) where T : IComparable<T>
{
    int count = elements.Length;
    bool done = true;
    for (int i = count - 1; i > 0; i--)
    {
        var curr = elements[i];
        if (curr.CompareTo(elements[i - 1]) < 0)
        {
            continue;
        }
        done = false;
        var prev = elements[i - 1];
        var currIndex = i;
        for (var j = i + 1; j < count; j++)
        {
            var tmp = elements[j];
            if (tmp.CompareTo(curr) < 0 && tmp.CompareTo(prev) > 0)
            {
                curr = tmp;
                currIndex = j;
            }
        }
        elements[currIndex] = prev;
        elements[i - 1] = curr;
        for (var j = count - 1; j > i; j--, i++)
        {
            var tmp = elements[j];
            elements[j] = elements[i];
            elements[i] = tmp;
        }
        break;
    }
    return done;
}

void PrintMS(int [] ms)
{

    int k = ms.Length;
    for (int i=0; i<k;i++)
    {
        Console.Write($"{ms[i]} ");
    }
}

bool CheckMate(int [] ms, int k)
{
    for (int i=0; i<k;i++)
    {
        if(ms[i] == ms[k] || (i - ms[i] == k - ms[k]) || (i + ms[i] == k + ms[k]))
        {
            return false;
        }
    }
    return true;
}

int Ferzez(int col, int Razmer, int [] msTemp)
{    
    int variants = 0;
    if (col == Razmer-1)
    {       
        return 1;
    }

    for (int j=0; j<Razmer; j++)
    {
        if (CheckMate(msTemp, col+1))
        {
            return variants += Ferzez(col+1, Razmer, msTemp);
        }  
    }   
    return variants;  
}


Console.WriteLine("введите размер шахматной доски");
int N = int.Parse(Console.ReadLine()); 

int[] Checking = new int[N];
for(int i=0; i<N;i++)
{
    Checking[i] = i;
}

int countPositive = 0;

var  startTime = DateTime.Now;

countPositive += Ferzez(0, N, Checking);
while (!NextPermutation(Checking))
{
    countPositive += Ferzez(0, N, Checking);
}
Console.WriteLine($"кол-во растановок {countPositive}");

var FullTime = DateTime.Now -  startTime;
Console.WriteLine($"время исполнения {FullTime}");