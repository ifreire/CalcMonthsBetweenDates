using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcMonthsBetweenDates
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Let's calc months between 2 dates!");
            CalcMonths();
            Console.ReadKey();
        }

        private static int ConvertDateToMonths(DateTime d)
        {
            return d.Year * 12 + d.Month;
        }

        private static void CalcMonths()
        {
            // DATA DA COMPRA DO EQUIPAMENTO
            DateTime inicio = new DateTime(2011, 9, 23);

            // DATA DE HOJE
            DateTime fim = DateTime.Now;

            // QUANTIDADE DE MÊSES ENTRE AS DUAS DATAS
            int mesesDiff = ConvertDateToMonths(fim) - ConvertDateToMonths(inicio);

            if (inicio.Day > fim.Day)
                mesesDiff--;

            Console.WriteLine($"{mesesDiff} months.");
        }
    }
}