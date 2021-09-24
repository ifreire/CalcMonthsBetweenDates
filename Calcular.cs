using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcMonthsBetweenDates
{
    public class Calcular
    {
        public int CalcMonths_Simplificado(DateTime dataCompra, DateTime dataHoje)
        {
            // DATA DA COMPRA DO EQUIPAMENTO
            DateTime dataInicio = dataCompra;
            int mesesInicio = dataInicio.Year * 12 + dataInicio.Month;

            // DATA DE HOJE
            DateTime dataFim = dataHoje;
            int mesesFim = dataFim.Year * 12 + dataFim.Month;

            // QUANTIDADE DE MÊSES ENTRE AS DUAS DATAS
            int idadeEquipamentoEmMeses = mesesFim - mesesInicio;

            if (dataInicio.Day > dataFim.Day)
                idadeEquipamentoEmMeses--;

            return idadeEquipamentoEmMeses;
        }
    }
}