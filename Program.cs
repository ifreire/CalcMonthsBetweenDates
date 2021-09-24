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

            DateTime dataInicio = new DateTime(2011, 9, 23);
            DateTime dataHoje = DateTime.Now;

            Calcular calc = new Calcular();

            int idadeEquipamentoEmMeses = calc.CalcMonths_Simplificado(dataInicio, dataHoje);
            
            Console.WriteLine($"{idadeEquipamentoEmMeses} months.");
            
            Console.ReadKey();
        }
    }
}