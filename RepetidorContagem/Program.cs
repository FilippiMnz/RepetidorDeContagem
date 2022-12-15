using System;

namespace Repetidor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira a quantidade de vezes que deseja digitar o número: ");
            int rep = int.Parse(Console.ReadLine());
            int Somatorio = 0;
            for ( int prim = 1; prim <= rep; prim++)
            {
                Console.Write("Digite um Numero#"+ prim+": ");
                int valor =int.Parse(Console.ReadLine());
                Somatorio = Somatorio + valor;

            }
            Console.WriteLine("A soma total dos produtos mostrados anteriormente equivalem a: " + Somatorio);
        }

    }

}