    // int a[10] = { 1, 0, 0, 2, 10, 4, 40, 92, 352, 724 };


bool check(int i, int j, int [] ms)
{
	ms[i] = j;
	for (int k = 0; k < i; k++) 
    {
		if (ms[i] == ms[k] || (i - ms[i] == k - ms[k]) || (i + ms[i] == k + ms[k]))
        { 
            // ms[i] = 0;
            return false; 
        } 	
    }	
    return true;																
}

void PrintMS(int [] ms)
{

    int k = ms.Length;
    for (int i=0; i<k;i++)
    {
        Console.Write($"{ms[i]} ");
    }
}

int ferzMach(int n, int [] ms, int i = 0)
{
	int count = 0;							 
	if (i == n) 
    { 
            PrintMS(ms);
            Console.WriteLine();
            return 1; 
    }							
	for (int j = 0; j < n; j++) 
    {
        if (check(i, j, ms))
        {
            count += ferzMach(n, ms, i + 1); 
        }
    }	
    return count;
}


int n;
Console.WriteLine("введите размер шахматной доски");
n = int.Parse(Console.ReadLine()); 
int [] ms = new int[n];		
var  startTime = DateTime.Now;
Console.WriteLine($"кол-во растановок {ferzMach(n, ms)}");
var FullTime = DateTime.Now -  startTime;
Console.WriteLine($"время исполнения {FullTime}");