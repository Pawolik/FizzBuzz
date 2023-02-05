using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tydzień_4_Zadanie_2
{
    class FizzBuzz
    {
        public void Rules() //objaśnienie zasad gry
        {
            Console.WriteLine("Zasady gry");
            Console.WriteLine("Jeżeli liczba użytkownika będzie podzielna przez 3 bez reszty, to zostanie zwrócony wynik „Fizz”.");
            Console.WriteLine("Jeżeli liczba użytkownika będzie podzielna przez 5 bez reszty, to zostanie zwrócony wynik „Buzz”.");
            Console.WriteLine("Jeżeli liczba użytkownika będzie podzielna przez 3 i przez 5 jednocześnie bez reszty, to zostanie zwrócony wynik „FizzBuzz”.");
            Console.WriteLine("Jeżeli liczba użytkownika nie będzie podzielna przez 3 ani przez 5 bez reszty, to zostanie zwrócona podana liczba.");
        }
        public string Game() //główne działanie programu
        {
            Console.WriteLine("\nPodaj Liczbę");
            int number = Choice();

            if (number % 15 == 0)
                Console.WriteLine("FizzBuzz");

            else if (number % 5 == 0)
                Console.WriteLine("Buzz");

            else if (number % 3 == 0)
                Console.WriteLine("Fizz");

            return $"Podana liczba {number} nie jest podzielna przez 3 i/lub 5.";

        }
        public int Choice() //zabezpieczenie programu
        {
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Błędna wartość");
            }
            return choice;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witaj w grze FizzBuzz.");
            Console.WriteLine("Wybierz jedną z opcji menu co chcesz zrobić");
            FizzBuzz game = new FizzBuzz();
            bool keep_going = true;
            while (keep_going) //menu gry
            {
                Console.WriteLine("1. Nowa gra \n2. Zasady gry \n3. Wyjście z gry.");
                int option = game.Choice();
                switch (option)
                {
                    case 1:
                        game.Game();
                        break;
                    case 2:
                        game.Rules();
                        break;
                    case 3:
                        Console.WriteLine("Czy chcesz wyjść z gry? tak/nie");
                        if (Console.ReadLine() == "tak" || Console.ReadLine() == "TAK")
                        {
                            keep_going = false;
                        }
                        break;
                    default:
                        Console.WriteLine("wybierz opjce 1 - 3");
                        break;
                }
                Console.WriteLine("\nKliknij ENTER aby kontynuować.");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
