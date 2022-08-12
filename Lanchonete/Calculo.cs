using System;
using System.Globalization;


namespace Lanchonete
{
    class Calculo
    {
        public double Quantidade;
        public double Produto;
        public double Total;
       
        public double ValorPedido()
        {
            Console.Write("Entre com a quantidade: ");
            Quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Total = Quantidade * Produto;

            return Total;
        }
        public override string ToString()
        {
           return"Total : R$" + ValorPedido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
