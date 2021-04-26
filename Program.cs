using System;

namespace Media_4_notas_1
{
    class Program
    {
        static void Main(string[] args)
        {
           Double Nota1, Nota2, Nota3, Nota4, Soma, Media;

            Console.ForegroundColor = ConsoleColor.DarkBlue;

            Console.WriteLine("----MÉDIA----");

            Console.ResetColor();

            Console.WriteLine();

            Console.WriteLine("Digite a primeira nota:");
            Nota1 = Convert.ToDouble(Console.ReadLine());

            if (Nota1 <0 || Nota1 >10){

                Console.ForegroundColor = ConsoleColor.DarkRed;

                Console.WriteLine("Digite somente notas entre 0 e 10");

                Console.ResetColor();

                Environment.Exit(1);
            }

            Console.WriteLine();

            Console.WriteLine("Digite a segunda nota:");
            Nota2 = Convert.ToDouble(Console.ReadLine());

            if (Nota2 <0 || Nota2 >10){

                Console.ForegroundColor = ConsoleColor.DarkRed;

                Console.WriteLine("Digite somente notas entre 0 e 10");

                Console.ResetColor();

                Environment.Exit(1);
            }

            Console.WriteLine();

            Console.WriteLine("Digite a terceira nota:");
            Nota3 = Convert.ToDouble(Console.ReadLine());

            if (Nota3 <0 || Nota3 >10){

                Console.ForegroundColor = ConsoleColor.DarkRed;

                Console.WriteLine("Digite somente notas entre 0 e 10");

                Console.ResetColor();

                Environment.Exit(1);
            }

            Console.WriteLine();

            Console.WriteLine("Digite a quarta nota:");
            Nota4 = Convert.ToDouble(Console.ReadLine());

            if (Nota4 <0 || Nota4 >10){

                Console.ForegroundColor = ConsoleColor.DarkRed;

                Console.WriteLine("Digite somente notas entre 0 e 10");

                Console.ResetColor();

                Environment.Exit(1);
            }

            Console.WriteLine();

            Soma = Nota1 + Nota2 + Nota3 + Nota4;
            Media = Soma /4;

            Console.WriteLine($"Sua média é: {Media}");
            
            Console.ForegroundColor = ConsoleColor.DarkBlue;

            if (Media >= 6){
                Console.WriteLine("Você foi aprovado!!");

                Console.ResetColor();
            }

            else if (Media >= 5)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;

                Console.WriteLine("Você esta de recuperação");

                Console.ResetColor();
            }

            else{
                Console.ForegroundColor = ConsoleColor.DarkRed;

                Console.WriteLine("Você foi reprovado");

                Console.ResetColor();
            }

            Console.ReadKey();
        }
    }
}
