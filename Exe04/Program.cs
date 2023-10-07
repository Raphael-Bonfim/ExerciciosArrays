/* 
 
Crie um algoritmo para ler 15 números inteiros e mostrar no final, os que forem maiores
ou igual a 10;

*/ 

namespace Exe04;

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
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            finally
            {
                if (reiniciar)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Deseja reiniciar? (s/n)");
                    string escolha = Console.ReadLine()!.ToLower();

                    reiniciar = (escolha == "s");
                }
            }
        }
    }

    static void MontaArray()
    {
        Console.Clear();

        var array = new int[15];

        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine("Crie um algoritmo para ler 15 números inteiros e mostrar no final, os que forem maiores\r\nou igual a 10;");
            Console.WriteLine();
            Console.Write($"Digite {array.Length} numeros inteiros para preencher o Array [{i + 1}] = ");

            array[i] = int.Parse(Console.ReadLine()!);

            if (i != array.Length - 1)
                Console.Clear();

        }

        Console.WriteLine();

        Console.Write($"Valores no Array : ");

        foreach (int numero in array)
        {
            Console.Write($"{numero} ");
        }

        Console.WriteLine();

        Console.Write($"Valores maiores ou igual a 10 : ");

        foreach (int numero in array)
        {
            if (numero >= 10)
                Console.Write($"{numero} ");
        }

        Console.WriteLine();

        Console.ReadKey();
    }
}