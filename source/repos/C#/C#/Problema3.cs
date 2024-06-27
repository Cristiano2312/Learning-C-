

    int input = 1111;
int input2 = input;
    int contor = 0;

    
    int i = 0;
    int k = 0;
    while(input != 0)
    {
    k++;
    input /= 10;
    }   

    int[] v = new int[k];

    while(input2 != 0) {

    v[i] = input2 % 10;
    input2 /= 10; 

    }
   

void recursiv(int i)
{
    if (i >= v.Length)
    {
        contor++;
    }
    else
    {
        if (i < v.Length-1 && v[i]*10 + v[i + 1] <= 26)
        {
            recursiv(i + 1);
            recursiv(i + 2);
        }
        else recursiv(i + 1);
    }

}
recursiv(0);
Console.WriteLine(contor);

