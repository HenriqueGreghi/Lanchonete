using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Lanchonete
{
    class Lanches
    {
        public static void Calculo(double valor)
        {
            Console.Write("Entre com a quantidade: ");
            double quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double total = valor * quantidade;
            Console.WriteLine("Total : R$" + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
