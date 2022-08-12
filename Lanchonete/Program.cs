using System;
using System.Globalization;

namespace Lanchonete
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("1 - Cachorro Quente.");
            Console.WriteLine("2 - X-Salada.");
            Console.WriteLine("3 - X-Bacon. ");
            Console.WriteLine("4 - Torrada Simples. ");
            Console.WriteLine("5 - Refrigerante.");
            Console.WriteLine("6 - X-Dog.");
            Console.WriteLine("7 - Sair.");
            Console.WriteLine();
            Console.Write("Escolha uma opição: ");

            int x = int.Parse(Console.ReadLine());


            if (x == 1)
            {

                CachorroQuente();
            }
            else if (x == 2)
            {
                XSalada();
            }
            else if (x == 3)
            {
                XBacon();
            }
            else if (x == 4)
            {
                TorradaSimples();
            }
            else if (x == 5)
            {
                Refrigerante();
            }
            else if (x == 6)
            {
                XDog();
            }
            else
            {

            }




        }
        public static void CachorroQuente()
        {
            Calculo l = new Calculo();
            l.Produto = 4.00;
            Console.WriteLine(l);

        }
        public static void XSalada()
        {
            Calculo l = new Calculo();
            l.Produto = 4.50;           
            Console.WriteLine(l);

        }
        public static void XBacon()
        {
            Calculo l = new Calculo();
            l.Produto = 5.00;
            Console.WriteLine(l);

        }
        public static void TorradaSimples()
        {
            Calculo l = new Calculo();
            l.Produto = 2.00;
            Console.WriteLine(l);
        }
        public static void Refrigerante()
        {
            Calculo l = new Calculo();
            l.Produto = 1.50;
            Console.WriteLine(l);
        }
        public static void XDog()
        {
            Calculo l = new Calculo();
            l.Produto = 5.50;
            Console.WriteLine(l);

        }
    }
}
