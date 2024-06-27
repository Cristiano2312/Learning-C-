

using System.Reflection.Metadata.Ecma335;

int[] v = { 1,2,0 };

    Array.Sort(v);

    for(int i=0; i<v.Length-1; i++)
{
    if (v[i] < 0) continue;

    if (v[i] - v[i + 1] < -1)
    {
        Console.WriteLine(v[i] + 1);
        break;
    }
    if (v[i+1] == v[v.Length-1]) 
    {
        Console.WriteLine(v[v.Length-1]+1);
        break;
    }
}

  



