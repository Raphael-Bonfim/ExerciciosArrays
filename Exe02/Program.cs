/*
 
Ler oito elementos inteiros em uma matriz unidimensional (A). Construir uma matriz B de
mesma dimensão com os elementos da matriz A multiplicados por 3. Após, apresente
os números da matriz B. Exemplo: o elemento B|0] deve ser implicado pelo elemento
A[0)*3, o elemento B[1] deve ser implicado pelo elemento A[1]*3 e assim por diante, até
a última posição:
 
 */

using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Exe02;

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

        var array = new int[8];
        var array2 = new int[8];

        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine("Ler oito elementos inteiros em uma matriz unidimensional (A). Construir uma matriz B de\r\nmesma dimensão com os elementos da matriz A multiplicados por 3. Após, apresente\r\nos números da matriz B. Exemplo: o elemento B|0] deve ser implicado pelo elemento\r\nA[0)*3, o elemento B[1] deve ser implicado pelo elemento A[1]*3 e assim por diante, até\r\na última posição:");
            Console.WriteLine();
            Console.Write($"Digite {array.Length} numeros inteiros para preencher o Array A [{i + 1}] = ");

            array[i] = int.Parse(Console.ReadLine()!);

            array2[i] = array[i] * 3;

            if (i != array.Length - 1)
            {
                Console.Clear();
            }
                
        }

        Console.WriteLine();

        Console.Write($"Valores no Array A : ");

        foreach (int numero in array)
        {
            Console.Write($"{numero} ");
        }

        Console.WriteLine();

        Console.Write($"Valores no Array B : ");

        foreach (int numero in array2)
        {
            Console.Write($"{numero} ");
        }

        Console.WriteLine();

        Console.ReadKey();
    }
}
