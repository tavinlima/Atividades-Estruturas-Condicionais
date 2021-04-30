using System;

namespace IdadeTempoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira sua idade: ");
            int SuaIdade = int.Parse(Console.ReadLine());

            int MesesIdade = SuaIdade * 12;
            int DiasIdade = SuaIdade * 365;
            int HorasIdade = DiasIdade * 24;
            int MinutosIdade = HorasIdade * 60;

            Console.WriteLine("Sua idade em meses é: " + MesesIdade + "\n");
            Console.WriteLine("Sua idade em dias é: " + DiasIdade + "\n");
            Console.WriteLine("Sua idade em horas é: " + HorasIdade + "\n");
            Console.WriteLine("Sua idade em minutos é: " + MinutosIdade + "\n");
        }
    }
}
