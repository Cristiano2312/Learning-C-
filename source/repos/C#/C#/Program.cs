internal class Program
{

    private static void Main(string[] args)
    {

        int[] array = { 3, 2, 1 };

        int[] arrayNou = new int[array.Length];

        int produs = 1;

        for (int i = 0; i < array.Length; i++)
        {
            produs *= array[i];

        }

        for (int i = 0; i < array.Length; i++)
        {
            arrayNou[i] = produs / array[i];
            Console.WriteLine(arrayNou[i]);
        }


    }
}