using System;

namespace IdadeConversãoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira seu ano de nascimento: ");
            int SeuNascimento = int.Parse(Console.ReadLine());

            // Console.WriteLine("Em que ano está vendo isso: ");
            int AnoAtual = DateTime.Now.Year;

            Console.WriteLine("Já fez aniversário esse ano?");
            Console.WriteLine("Responda com sim ou não (em minúsculo)");
            string niver = Console.ReadLine();

            int SuaIdade = AnoAtual - SeuNascimento;
            int SemanasIdade = SuaIdade * 48;


            if(niver == "sim") {
                Console.WriteLine("Sua idade atual é: " + SuaIdade + " anos" + "\n");
                Console.WriteLine("Sua idade em semanas é: " + SemanasIdade + "\n");
            }
            else{
                Console.WriteLine("Sua idade atual é: " + (SuaIdade - 1) + " anos" + "\n");
                Console.WriteLine("Sua idade em semanas é: " + SemanasIdade + "\n");
            }

        }
    }
}
