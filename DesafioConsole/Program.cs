using System;

namespace DesafioConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira sua idade aqui: ");
            int suaIdade = int.Parse(Console.ReadLine());

            if (suaIdade < 5){
                Console.WriteLine("Você não pode se matricular :(");
            }
            if (suaIdade >= 5 && suaIdade <= 7){
                Console.WriteLine("Você está na turma: Infantil A");
            }
            if (suaIdade >= 8 && suaIdade <= 10){
                Console.WriteLine("Você está na turma: Infantil B");
            }
            if (suaIdade >= 11 && suaIdade <= 13){
                Console.WriteLine("Você está na turma: Juvenil A");
            }
            if (suaIdade >= 14 && suaIdade <= 17){
                Console.WriteLine("Você está na turma: Juvenil B");
            }
            if (suaIdade >= 18){
                Console.WriteLine("Você está na turma: Sênior");
            }

        }
    }
}
