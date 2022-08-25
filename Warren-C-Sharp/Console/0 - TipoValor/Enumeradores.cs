namespace Console._0___TipoValor
{
    internal class Enumeradores
    {
        public static void Executa()
        {
            System.Console.WriteLine(DiasDaSemana.DOM);
            System.Console.WriteLine((byte)DiasDaSemana.DOM);
            System.Console.WriteLine((int)DiasDaSemana.SEX);

            DiasDaSemana seg = DiasDaSemana.SEG;
            System.Console.WriteLine(seg);
            DiasDaSemana ter = (DiasDaSemana)2;
            System.Console.WriteLine(ter);
        }

        public enum DiasDaSemana
        {
            DOM,
            SEG,
            TER,
            QUA,
            QUI,
            SEX,
            SAB
        }
    }
}