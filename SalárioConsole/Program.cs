using System;

namespace SalárioConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Olá! Por favor, insira o valor do seu salário: ");
            double seuSalario = double.Parse(Console.ReadLine());

            double percentual =(seuSalario / 100) * 30;
            double aumentoDeSalario = seuSalario + percentual;

            if(seuSalario < 500){
            Console.WriteLine("Seu salário atual é: " + aumentoDeSalario);

            }
            else{
                Console.WriteLine("Você não tem direito ao aumento de salário :(");
            }

        }   
    }
}
