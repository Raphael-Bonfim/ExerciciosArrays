/*
 
Faça um algoritmo que leia 20 números e armazene em um vetor. Depois, some os 10
primeiros elementos deste vetor;

 */

namespace Exe05;

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

        var array = new int[20];
        var somaDez = 0;

        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine("Faça um algoritmo que leia 20 números e armazene em um vetor. Depois, some os 10\r\nprimeiros elementos deste vetor");
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

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] <= 10)
                somaDez = somaDez + array[i];
        }

        Console.WriteLine($"Soma dos 10 primeiros valores no vetor : {somaDez}");

        Console.WriteLine();

        Console.ReadKey();
    }
}