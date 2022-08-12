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


            switch (x)
            {

                case 1:
                    CachorroQuente();
                    break;
                case 2:
                    XSalada();
                    break;
                case 3:
                    XBacon();
                    break;
                case 4:
                    TorradaSimples();
                    break;
                case 5:
                    Refrigerante();
                    break;
                case 6:
                   XDog();
                    break;
                case 7:
                    
                    break;
                   
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
