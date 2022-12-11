using System;

namespace Taschenrechner
{
    class Program
    {
        static void Main(string[] args)
        {
            // Programmwiederholung
            do
            {
                // Überschrift
                Console.WriteLine("--------------");
                Console.WriteLine("Taschenrechner");
                Console.WriteLine("--------------");

                // Variablendeklaration
                double Zahl_1, Zahl_2, ergebnis;

                Console.Write("Geben Sie die erste Zahl ein: ");
                // Zahl_1 durch sprechenden Variablennamen ersetzen
                Zahl_1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Geben Sie die zweite Zahl ein: ");
                Zahl_2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Wählen Sie eine Option aus: ");
                Console.WriteLine("\t+ : Addition");
                Console.WriteLine("\t- : Subtraktion");
                Console.WriteLine("\t* : Multiplikation");
                Console.WriteLine("\t/ : Division");

                string option = Console.ReadLine();
                if (option == "+")
                {
                    ergebnis = Zahl_1 + Zahl_2;
                    Console.WriteLine("Das Ergebnis lautet: " + ergebnis);
                }
                else if (option == "-")
                {
                    ergebnis = Zahl_1 - Zahl_2;
                    Console.WriteLine("Das Ergebnis lautet: " + ergebnis);
                }
                else if (option == "*")
                {
                    ergebnis = Zahl_1 * Zahl_2;
                    Console.WriteLine("Das Ergebnis lautet: " + ergebnis);
                }
                else if (option == "/")
                {
                    ergebnis = Zahl_1 / Zahl_2;
                    Console.WriteLine("Das Ergebnis lautet: " + ergebnis);
                }
                else
                {
                    Console.WriteLine("Geben Sie das nächste Mal bitte einen korrekten Operator an!");
                }
         
                Console.WriteLine("Möchten Sie fortfahren? (Y = Ja, N = Nein");
            }

            // Einlesen für Programmwiederholung
            while (Console.ReadLine().ToUpper() == "Y");
            Console.WriteLine("Tschüss!");
            Console.ReadLine();
        }
    }
}
