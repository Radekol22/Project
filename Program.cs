using System;

namespace ConsoleCalculator
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("Aplikacja Kalkulator");
            

            while (true)
            {

                try
                {
                    Console.WriteLine("Podaj  pierwszą liczbę:");
                    var number1 = GetInput();

                    Console.WriteLine("Wybierz jedną z dostępnych operacji: '+', '-', '*', '/'.");
                    var operation = Console.ReadLine();

                    Console.WriteLine("Podaj drugą liczbę:");
                    var number2 = GetInput();

                    var result = Licz(number1, number2, operation);

                    Console.WriteLine($"Wynik działania to: {result}");
                    Console.WriteLine("Aby wyjść naciśnij 0, aby powtórzyć program podaj inną liczbę:");

                    var number3 = GetInput();
                    if (number3 == 0)
                    {
                        Environment.Exit(0);
                    }
                    else { 
                    Console.WriteLine("------------------------------------\n");
                        }

                }
                catch (Exception ex)
                {
                    //logowanie do pliku
                    Console.WriteLine(ex.Message);
                }
            }
        }
        
        private static int GetInput()
        {
            if (!int.TryParse(Console.ReadLine(), out int input))
                throw new Exception("Podana wartość nie jest liczbą.\n");

            return input;
        }
        
        private static int Licz(int number1, int number2, string operation)
        {
            switch (operation)
            {
                case "+":
                    return number1 + number2;
                case "-":
                    return number1 - number2;
                case "*":
                    return number1 * number2;
                case "/":
                    return number1 / number2;
                default:
                    throw new Exception("Wybrałeś złą operację!\n");
            }
        }
    }
}
