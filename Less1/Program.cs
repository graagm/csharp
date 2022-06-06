// int x = 57;
// int z = 87;
// Console.WriteLine( x + z );
// string name1 = Console.ReadLine();
// string name2 = Console.ReadLine();
// if (name2 == ""){
//     Console.WriteLine("Ура");
// }
int N = 10;
int [] c = new int [N];
for (int i=0; i<N; i++)
{
    c[i] = new Random().Next(15, 39);
    Console.Write(c[i]);
    Console.Write(' ');
}
