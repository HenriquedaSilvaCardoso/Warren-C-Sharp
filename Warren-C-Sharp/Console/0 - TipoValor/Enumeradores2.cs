using System;

namespace Console._0___TipoValor
{
    internal class Enumeradores2
    {
        public static void Executa()
        {
            System.Console.WriteLine(DiasDaSemana2.DOM);
            DiasDaSemana2 diasPresencias = (DiasDaSemana2)20;
            System.Console.WriteLine(diasPresencias);
        }
    }

    [Flags]
    public enum DiasDaSemana2
    {
        DOM = 1,
        SEG = 2,
        TER = 4,
        QUA = 8,
        QUI = 16,
        SEX = 32,
        SAB = 64
    }
}