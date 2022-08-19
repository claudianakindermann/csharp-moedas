using System;
using System.Globalization;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("------------------ FORMATANDO VALOR NUMÉRICO ----------------------");

            decimal valor = 1235.80m;
            Console.WriteLine(valor.ToString(CultureInfo.CreateSpecificCulture("pt-BR")));

            //Formatador de Moeda
            Console.WriteLine(valor.ToString("G", CultureInfo.CreateSpecificCulture("pt-BR")));

            //C = Currency 
            Console.WriteLine(valor.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")));
            //Tem o mesmo resultado com String.Format:
            Console.WriteLine("{0:C}", valor);


            //E04 = Padrão de calculadora
            Console.WriteLine(valor.ToString("E04", CultureInfo.CreateSpecificCulture("pt-BR")));

            //F = Uma casa decimal a mais
            Console.WriteLine(valor.ToString("F", CultureInfo.CreateSpecificCulture("pt-BR")));

            //N = número
            Console.WriteLine(valor.ToString("N", CultureInfo.CreateSpecificCulture("pt-BR")));

            //P = Porcentagem
            Console.WriteLine(valor.ToString("P", CultureInfo.CreateSpecificCulture("pt-BR")));

            Console.WriteLine("------------------ USANDO MATH ----------------------");

            //Arredondando valor
            valor = 1235.30m;
            Console.WriteLine(Math.Round(valor));

            //Arredondando valor para cima
            Console.WriteLine(Math.Ceiling(valor));

            //Arredondando valor para baixo
            Console.WriteLine(Math.Floor(valor));

        }
    }
}