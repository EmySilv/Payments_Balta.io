using System;

namespace Payments
{
    public static class Menu
    {
        public static void Principal()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Olá, Seja Bem-Vindo(a)");
            Console.WriteLine("Gostaria de abrir o menu? S/N");

            Console.ForegroundColor = ConsoleColor.Green;
            string resp = Console.ReadLine()!.ToUpper();

            if (resp == "S")
            {
                Menu.Show();
            }
            else if (resp == "N")
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("Até logo!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Desculpe não entendi, tente novamente.");
            }

        }
        public static void Show()
        {
            Console.Clear();
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("O que queres fazer?                ");

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("1 - Classes e Objeto               ");
            Console.WriteLine("2 - Encapsulamento                 ");

            string option = Console.ReadLine()!;
            try
            {
                switch (option)
                {
                    case "1": ClasseeObjeto.Show(); break;
                    case "2": Encapsulamento.Show(); break;

                    default: Menu.Principal(); break;
                }
            }
            catch (System.Exception)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\nDesculpe, não consegui realizar a operação.");
                Console.WriteLine("\nDica: Use os caracteres apresentados nas opções.");

                Console.ResetColor();
                Console.WriteLine("Aperte qualquer tecla para voltar ao menu.");

                Console.ReadKey();
                Menu.Show();
            }
        }
    }
}