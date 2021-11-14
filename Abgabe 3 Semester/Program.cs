using System;
using System.Collections.Generic;

namespace Abgabe3Semester
{

    class Program
    {
        static void Main(string[] args)
        {

            InputConverter inputConverter = new InputConverter();
            CalculatorEngine calculatorEngine = new CalculatorEngine();


            Console.Write("Konsolenrechner | Version 2.0");
            Console.Write("\nerstellt von Gerhard Obermaier");
            Console.WriteLine("\n");

            Console.Beep(400, 800);


            Console.Write("\nGib die erste Zahl ein: ");
            Console.WriteLine("\n");
            double firstNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());

            if (!inputConverter.isConverted)
            {
                Console.WriteLine("\nEingabe nicht zulässig - zum weitermachen eine beliebige Taste drücken");
                Console.ReadKey();
                Environment.Exit(0);
            }

            Console.Write("\nGib die zweite Zahl ein: ");
            Console.WriteLine("\n");
            double secondNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());

            if (!inputConverter.isConverted)
            {
                Console.WriteLine("\nEingabe nicht zulässig - zum weitermachen eine beliebige Taste drücken");
                Console.ReadKey();
                Environment.Exit(0);
            }

            Console.Write("\nGib die Rechenart ein (+ | - | / | *): ");
            string operation = Console.ReadLine();

            var operatorValidator = new OperationValidator();

            if (operatorValidator.ValidateEntry(operation))
            {
                double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);
                Console.WriteLine(result);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"Eingabe {operation} nicht zulässig - zum weitermachen eine beliebige Taste drücken");
                Console.ReadKey();
                Environment.Exit(0);
            }


        }
    }
}