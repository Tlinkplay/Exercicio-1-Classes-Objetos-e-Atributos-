using System;
using System.Globalization;
using Exercicio_1__Classe__Objeto_e_Atributo_;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            Idade Ia, Ib;

            Ia = new Idade();
            Ib = new Idade();

            Console.WriteLine("Um nome");
            string N = Console.ReadLine();
            Console.WriteLine("Uma idade");
            Ia.A = int.Parse(Console.ReadLine());

            Console.WriteLine("Outro nome");
            string N2 = Console.ReadLine();
            Console.WriteLine("Outra idade");
            Ib.B = int.Parse(Console.ReadLine());

            if (Ia.A < Ib.B)
            {
                Console.WriteLine($"{N2} E mais velho(a)");
            }
            else if (Ia.A > Ib.B)
            {
                Console.WriteLine($"{N} E mais velho(a)");
            }
            else if (Ia.A == Ib.B)
            {
                Console.WriteLine("Ambos possuem a mesma idade");
            }
        }
    }
}