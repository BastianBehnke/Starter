using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starter.Aufgaben
{

    /*
         A
        B B
       C   C
      D     D
       C   C
        B B
         A
     
     Aufgabe:
     Schreibe den code der benötigt ist um einen Diamanten aus Buchstaben auszugeben.
     Der User soll eine Zahl eingeben. Basierend auf dieser Zahl soll die größe des Diamants angegeben werden.
     Beispiel: Der User gibt die Zahl 4 ein:

     1    A
     2   B B
     3  C   C
     4 D     D
        C   C
         B B
          A

     Beispiel: Der User gibt die Zahl 2 ein:
     1  A
     2 B B
        A
     
     */


    internal class DiamondOfLetters : ITask
    {
        public void Run()
        {
            Console.WriteLine("Diamond of letters");
        }
    }
}
