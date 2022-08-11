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
            Console.WriteLine("6 - Sair.");
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
            else
            {

            }



        }
        public static void CachorroQuente()
        {
            double valor = 4.00;
            Console.Write("Entre com a quantidade: ");
            double quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double total = valor * quantidade;
            Console.WriteLine("Total : R$" + total.ToString("F2", CultureInfo.InvariantCulture));
        }
        public static void XSalada()
        {
            double valor = 4.50;
            Console.Write("Entre com a quantidade: ");
            double quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double total = valor * quantidade;
            Console.WriteLine("Total : R$" + total.ToString("F2", CultureInfo.InvariantCulture));

        }
        public static void XBacon()
        {
            double valor = 5.00;
            Console.Write("Entre com a quantidade: ");
            double quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double total = valor * quantidade;
            Console.WriteLine("Total : R$" + total.ToString("F2", CultureInfo.InvariantCulture));

        }
        public static void TorradaSimples()
        {
            double valor = 2.00;
            Console.Write("Entre com a quantidade: ");
            double quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double total = valor * quantidade;
            Console.WriteLine("Total : R$" + total.ToString("F2", CultureInfo.InvariantCulture));
        }
        public static void Refrigerante()
        {
            double valor = 1.50;
            Console.Write("Entre com a quantidade: ");
            double quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double total = valor * quantidade;
            Console.WriteLine("Total : R$" + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
