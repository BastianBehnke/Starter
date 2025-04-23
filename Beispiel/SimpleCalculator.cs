using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starter.Beispiel
{
    public class SimpleCalculator : ITask
    {
        public void Run()
        {

            //Benutzerdaten abfragen (siehe Konsolenwerkzeuge)
            Console.WriteLine("Bitte gebe die erste Zahl ein:");
            string firstInput = Console.ReadLine();

            Console.WriteLine("Bitte gebe die zweite Zahl ein:");
            string secondInput = Console.ReadLine();

            //Mittels try/catch checken ob die angaben in int (Zahlen) umgewandelt werden können (siehe Exception handling)
            //Der try Bereich wird ausgeführt bis es zu einem Fehler kommt. Bei einem Fehler wird der Code im try Bereich abgebrochen und macht im catch Bereich weiter
            try
            {

                //Konvertierung der 2 Eingaben.
                int firstNumber = int.Parse(firstInput);
                int secondNumber = int.Parse(secondInput);

                int sum = firstNumber + secondNumber;

                //Verkettung von zwei strings (siehe oft verwendete Werkzeuge / Arbeiten mit strings)
                string message = "Das Ergebnis is: " + sum.ToString();

                //Ausgabe von message
                Console.WriteLine(message);
            }
            catch
            {
                Console.WriteLine("Überprüfe deine Eingaben. Eine Eingabe konnte nicht zu einer Zahl konvertiert werden");
            }
        }
    }
}
