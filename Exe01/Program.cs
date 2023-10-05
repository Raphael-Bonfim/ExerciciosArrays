/* 
 
Ler dez elementos de uma matriz unidimensional do tipo inteiro e apresentar os valores
lidos

*/

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        var array = new int[10];

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"Digite 10 numeros inteiros [{i + 1}] = ");

            array[i] = int.Parse(Console.ReadLine()!);
            Console.Clear();

            Console.WriteLine($"Numero digitado: {array[i]}");

            Thread.Sleep(600);
            Console.Clear();
        }


        Console.Write($"Valores no Array : ");

        foreach (int numero in array)
        {
            Console.Write($"{numero} ");
        }

        Console.ReadKey();
    }
}