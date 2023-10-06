/* 
 
Ler dez elementos de uma matriz unidimensional do tipo inteiro e apresentar os valores
lidos

*/

class Program
{
    static void Main(string[] args)
    {
        bool reiniciar = true;

        while (reiniciar)
        {
            try
            {
                MontaArray();
            }
            catch (FormatException)
            {
                Console.Clear();
                Console.WriteLine("Valor inválido. Digite um número inteiro.");
                Thread.Sleep(2000);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }

           if (reiniciar)
            {
                Console.Clear();
                Console.WriteLine("Deseja reiniciar? (s/n)");
                string escolha = Console.ReadLine()!.ToLower();

                reiniciar = (escolha == "s"); 
            }
        }
    }

    static void MontaArray()
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