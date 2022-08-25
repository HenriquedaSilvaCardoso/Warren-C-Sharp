using System;

namespace Console._0___TipoValor
{
    internal class TipoNumerico
    {
        public void Executa()
        {
            byte tipo1 = 0; // de 0 até 255
            byte byteMin = Byte.MinValue; // descobre o menor valor para byte, assumo que tenha para diferentes tipos numéricos
            byte byteMax = Byte.MaxValue; // descobre o maior valor para o tipo
            System.Console.WriteLine($"Byte Min: {byteMin}");
            System.Console.WriteLine($"Byte Max: {byteMax}");

            sbyte sbyteMin = sbyte.MinValue;
            sbyte sbyteMax = sbyte.MaxValue;
            System.Console.WriteLine($"SByte Min: {sbyteMin}\nSByte Max: {sbyteMax}");

            short shortMin = short.MinValue;
            short shortMax = short.MaxValue;
            System.Console.WriteLine($"short Min: {shortMin}\nshort Max: {shortMax}");

            ushort ushortMin = ushort.MinValue;
            ushort ushortMax = ushort.MaxValue;
            System.Console.WriteLine($"ushort Min: {ushortMin}\nushort Max: {ushortMax}");

            Int16 int16Min = Int16.MinValue;
            Int16 int16Max = Int16.MaxValue;
            System.Console.WriteLine($"Int16 Min: {int16Min}\nInt16 Max: {int16Max}");

            int intMin = int.MinValue;
            int intMax = int.MaxValue;
            System.Console.WriteLine($"int Min: {intMin}\nint Max: {intMax}");

            Int32 int32Min = Int32.MinValue;
            Int32 int32Max = Int32.MaxValue;
            System.Console.WriteLine($"Int32 Min: {int32Min}\nInt32 Max: {int32Max}");

            Int64 int64Min = Int64.MinValue;
            Int64 int64Max = Int64.MaxValue;
            System.Console.WriteLine($"Int64 Min: {int64Min}\nInt64 Max: {int64Max}");
            long longMin = long.MinValue;
            long longMax = long.MaxValue;
            System.Console.WriteLine($"long Min: {longMin}\nlong Max: {longMax}");
        }
    }
}