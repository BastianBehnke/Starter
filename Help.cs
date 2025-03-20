namespace Starter
{
    public class Help
    {

        #region Datentypen

        //====================================================
        //           Häufig verwendete Datentypen
        //====================================================

        //Ein einziges Zeichen
        char Character;
        char CharacterInitialisiert = 'a';

        //Eine beliebege Verkettung von Zeichen: "Mein string". Ein string kann auch als Array von char verwendet werden (siehe Arrays).
        string Zeichenkette;
        string ZeichenKetteInitialisiert = "Meine Zeichenkette";

                //Ein ID format (f54829d6-b384-4230-9a6d-5bf183fa0f84)
        Guid Uid;
        Guid UidInitialisiert = Guid.NewGuid();

        //Integer: eine Zahl von: -2,147,483,648 bis 2,147,483,647
        int Zahl;
        int ZahlInitialisiert = 4;

        //Boolean: Entweder true oder false
        bool State;
        bool StateInitialisiert = true;

        //====================================================
        //                      Arrays
        //====================================================

        //Arrays werden eines typs werden erstellt indem "[]" hinter den datentyp gehängt wird. zusätzlich wird ein array folgernder maßen initialisiert: new datentyp[größe/anzahl der elemente]
        //Wird 10 als größe angegeben, kann dass array maximal 10 elemente beinhalten.

        //string array
        string[] ZeichenkettenArray = new string[10];

        //int array
        int[] IntArray = new int[10];

        //bool array
        bool[] boolArray = new bool[10];

        //Auf array inhalt zugreifen:
        //Man muss sich ein array wie eine tabelle vorstellen.
        //Um nun auf den inhalt einer zeile zuzugreifen wird der index, also die tabllenzeile angegeben.
        //Hierbei ist zu beachten, dass das erste Element in einem array den index bzw. die zeilennummer 0 hat.
        //Die syntax hierfür ist IntArray[0] / boolArray[5] / ZeichenkettenArray[9].
        //Da das erste element den index 0 hat, ist der letzte index immer die größe des Arrays - 1.
        //
        //Arrays haben immer eine feste größe, die bei der Initialisierung festgelegt wird. 

        void ArrayBeispiel()
        {
            ZeichenkettenArray[1] = "Mein string";
            string ZeichenkettenWertVonArray = ZeichenkettenArray[1];

            IntArray[0] = 9;
            int IntVonArray = IntArray[0];

        }

        void StringAlsArrayVonCharacters()
        {
            string myString = "some string";

            //ein string kann wie ein array verwendet werden. Wichtig, dies geht nur zum lesen.
            //Man kann also das Zeichen an einer Position ermitteln, jedoch nicht das Zeichen an einer
            //Position austauschen
            char eCharacter = myString[3];


        }

        #endregion

        #region Functions

        //====================================================
        //              Methoden und Funktionen
        //====================================================

        //void ist ein spezieller Datentyp der nur bei Methoden valide ist. void Bezeichnet, dass die Methode nichts zurück gibt.
        public void ReturnNothing()
        {
            Console.WriteLine("This method does not return anything but executes some code");
        }


        //Diese Funktion gibt einen int wert zurück
        public int ReturnInt()
        {
            return 1;
        }


        //Diese Funktion gibt einen string wert zurück
        public string ReturnString()
        {
            return "This string is about to get returned!";
        }

        #endregion

        #region Accessor

        //====================================================
        //                    Accessor
        //====================================================

        /*
         * Accessor steuern wer von wo code verwenden darf.
         * Public: Die Methode/Funktion/Variable ist immer verfügbar
         * Private: Die Methode/Funktion/Variable ist nur innerhalb der Class verfügbar. Alles was keinen Accessor angegben hat ist ebenfalls private
         * Internal: Die Methode/Funktion/Variable ist nur innerhalb der Assembly bzw. innerhalb des Projekts verfügbr
         */


        //public field
        public int IntegerPublic;

        //private field
        private int IntegerPrivate;

        //internal field
        internal int IntegerInternal;


        //public method
        public void AccessorMethodPublic()
        {

        }

        //private method
        private void AccessorMethodPrivate()
        {

        }

        //internal method
        internal void AccessorMethodInternal()
        {

        }

        #endregion

        #region Vergleichoperatoren & logische operatoren

        //====================================================
        //               Vergleichsoperatoren
        //====================================================

        //das Ergebnis von Vergleichoperatoren ist immer ein bool (true oder false)

        //equals ==
        bool equals = 1 == 1; //true

        //not equal !=
        bool notEqual = 1 != 1; //false

        //Less than <
        bool lessThan = 1 < 7; //true

        //Less than or equal <=
        bool lessThanOrEqual = 7 <= 7; //true

        //Greater than >
        bool greaterThan = 7 > 1; //true

        //Greater than or equal >=
        bool greaterThanOrEqual = 7 >= 7; //true


        //====================================================
        //               Logische operatoren
        //====================================================

        //logische operatoren können verwendet werden um boolean ausdrücke zu verbinden.
        // && - Logischer UND operator. beide booleans müssen true sein, damit das ergebnis ebenfalls true ist
        // || - Logischer OR operator. Mindestens einer der booleans true sein
        // ! - Verneinung. Negiert das Ergebnis eines booleans

        bool sunIsShining = true;

        bool isNightTime = false;

        void CheckForSunnyDay()
        {
            //isNightTime ist negiert. Dementsprechend ist dies true wenn sunIsShining true ist und isNightTime false ist.
            bool sunnyDay = sunIsShining && !isNightTime; // true

            //beide booleans sind negiert. Dementsprechend ist dies true wenn sunIsShining false ist und isNightTime false ist.
            bool rainyDay = !sunIsShining && !isNightTime; //true

            //alternativ könnte man dies auch so vereinfachen:
            rainyDay = !sunnyDay;
        }




        #endregion

        #region Kontrollstrukturen und Schleifen

        //====================================================
        //        Kontrollstrukturen und Schleifen
        //====================================================

        //Kontrollstrukturen und schleifen werden verwendet um den Ablauf des Codes zu beeinflussen. Diese können nur in Methoden und Funktionen verwendet werden

        //====================================================
        //                   if & else
        //====================================================

        //If Statements führen ihren code aus, wenn die condition true ist. Optional kann else verwendet werden um code auszuführen wenn die condition false ist
        void IfStatement()
        {
            bool condition = true;

            if(condition)
            {
                Console.WriteLine("Because the value of condition is true, this get executed");
            }
            else
            {
                Console.WriteLine("This does not run.");
            }


            if(1 > 9)
            {
                Console.WriteLine("This does not run");
            }
            else
            {
                Console.WriteLine("Because the condition is not true, this get executed.");
            }


        }


        //====================================================
        //                       loops
        //====================================================

        //While Loops führen ihren Inhalt aus, solange die condition true ist
        void WhileLoop()
        {
            int number = 0;

            while(number < 10)
            {
                number = number + 1;
                Console.WriteLine("Each run \"number\" gets incremented. This this loop runs 10 times because at run 11 the condition is not true anymore");
            }
        }


        void ForLoop()
        {

            //Ein for loop wird verwendet wenn die anzahl der schleifendürläufe
            //kennt oder ein bestimmte Anzhal an durchläufen benötigt oder man mit zugriff auf die aktuellen schleifendruchläufe benötigt.
            //Bei einem for loop wird ein int deklariert und initialisiert.
            //Anschließend wird die Endbedingung beschrieben, die dazu führen soll, dass der loop abgeschlossen ist.
            //Zuletzt wird beschrieben, was nach jedem Schleifendurchlauf geschehen soll.

            //In diesem fall wird "int number" deklariert und initialisiert.
            //Es wird bestimmt, dass die Schleife laufen soll, solange "number" kleiner als 10 ist.
            //Nach jedem durchlauf wird "number" um eins erhöht ("number++" bedeutet das gleiche wie "number + 1")
            //Anders als bei einem "for each" loop oder einem "while" loop hat man bei einem "for" loop einen Zähler (number) der Auskunft
            //über den aktuellen durchlauf gibt
            for (int number = 0; number < 10; number++)
            {
                Console.WriteLine("This is itteration number: " + number);
            }

            //Schleifen dieser Art sind vorallem interessant wenn man mit Arrays arbeitet

            int[] myArray = new int[10];
            for (int i = 0; i < myArray.Length; i++)
            {
                //schreibt den aktuellen wert von i in den index i des arrays
                myArray[i] = i;
            }

        }

        //ForEach loops werden verwendet um etwas mit oder etwas für ein jedes objekt in einer Sammlung wie z.B. Arrays zu machen
        void ForEachLoop()
        {
            //Deklariert und initialisiert ein Array für int
            int[] arrayOfNumbers = new int[10];

            //Die Notation ist so zu lesen: für jedes objekt in "arrayOfNumbers", speicher das object in "number" vom typ "int" und führe den code aus.
            foreach (int number in arrayOfNumbers)
            {
                //Innerhalb des Loops kann nun "number" verwendet werden. Der Loop stellt uns bei jedem
                //Schleifendurchlauf ein neues Element zur verfügung um damit zu arbeiten
                Console.WriteLine("The number is: " + number);
            }
        }

        #endregion

        #region Datentypkonvertierung

        //====================================================
        //                       loops
        //====================================================

        void ConvertToInt()
        {
            //In diesem Fall besteht der string nur aus Zahlen. Dementsprechend steht einer Konvertierung nichts im Weg.
            string numberAsString = "43";

            //Parse Methoden werden verwendet um aus einem Datentyp einen anderen zu machen. Dies funktioniert nur, wenn die Werte kompatibel sind (also die Zeichenkette eine reine Zahl dastellt).
            int convertedNumber = int.Parse(numberAsString); 


            //In diesem Fall befindet sich ein Buchstabe im string. Diese Operation würde fehlschlagen und eine Exception erzeugen.
            numberAsString = "a34";
            convertedNumber = int.Parse(numberAsString);

            //Ein string hingegen kann aus jedem datentyp mit der Methode ToString() erzeugt werden
            string newString = convertedNumber.ToString();
        }

        #endregion

        #region Ausnahmen behandlung / Exception handling

        //====================================================
        //                 Exception handling
        //====================================================

        //Exceptions sind Fehler in der Programmierung. Exceptions treten auf, wenn der Code auf eine Situation trifft, die der Programmierer beim Programmieren nicht angenommen
        //bzw. nicht beachtet hat. Beispiele:
        //beim konvertieren eines strings zu einer Zahl befinden sich nicht numerische Zeichen im string
        //beim versuch eine Datei zu lesen existiert die Datei nicht
        //beim schreiben einer Datei ist die Datei schreibgeschützt
        //
        //Ein Programmierer muss sicherstellen, dass entweder alle möglichen Situationen behandelt werden oder muss sicherstellen, dass im Falle einer unbedachten Situation
        //ein Plan B existiert
        //Hier zu wird das try/catch Pattern verwendet

        void ExceptionHandling()
        {
            //im try bereich befindet sich Plan A, also der teil des codes der potentiell fehlschlagen könnte.
            //Sollte es zu einem Fehler bzw. einer Exception kommen wird der Code an der jeweiligen Stelle abgebrochen und es geht weiter mit Plan B
            //
            //Das try/catch Pattern kann man sich auch so vorstellen:
            //Mach dies (try) und wenn es nicht klappt, mach das (catch)
            try
            {
                //Dieser Teil wird eine Exception erzeugen, da "abc" nicht in eine Zahl konvertiert werden kann.
                int myNumber = int.Parse("abc");

                //Dieser teil wird nicht ausgeführt, da es zuvor zu einer Exception gekommen ist.
                int result = myNumber * 3;
            }
            //im catch bereich befindet sich Plan B, also was passieren soll, wenn es zu einer Exception kommt
            catch
            {
                //Hier geht es nach der Exception weiter
                Console.WriteLine("Es kam zu einem Fehler beim konvertieren einer Zahl");
            }

            
        }

        #endregion

        #region Oft verwendete Werkzeuge

        //====================================================
        //                 Arbeiten mit strings
        //====================================================

        //spezielle Zeichen
        void SpecialCharacters()
        {
            //Das zeichen \ wird in strings verwendet um spezielle, funktionelle Zeichen zu signalisieren. Z.B. hat \n die Funktion von "new line" und erzeugt einen Zeilenumbruch.
            //Diese speziellen Zeichen werden besonders highlighted (etwas heller).
            string stringWithNewLine = "first line \n second line";

            //Sollte man nun tatsächlich \n als Zeichen wollen und nicht dessen kombinierte funktion, muss man das zeichen \ escapen (escapen: quasi aus der speziellen Funktion "fliehen").
            //Zum escapen wird ebenfalls \ verwendet. Der selbe string, ohne Zeilenumbruch und den zeichen \n würde nun folgender Maßen aussehen.
            //Beachte, dass das highlighting nun geändert hat. Nun ist die Kombination von Zeichen \\ welche zu \ werden.
            string stringWithoutNewLine = "first line \\n still first line";

            //Oft möchte man einfach nur einen string, so wie man ihn selbst sieht und verzichtet auf jegliche speziellen Zeichen (wie z.B. \n). Hierzu kann ein string mit @ begonnen werden.
            //Dabei werden spezielle Zeichen ignoriert und der string als buchstäblich interpretiert
            string stringLitteral = @"litteral \n string;";

        }

        //Verbinden von strings
        void AddStrings()
        {
            string stringOne = "abc";
            string stringTwo = "def";

            //Dies fügt stringTwo dem stringOne hinzu
            string combinedString = stringOne + stringTwo;

            //oder auch so:
            combinedString = "abc" + "def";

            //oder:
            combinedString = stringOne + "def";
        }

        //Strings auf inhalte checken
        void CheckStringForContent()
        {
            //Hier wird geprüft ob sich die Zeichenreihenfolge "is" im string befindet. 
            string mystring = "This is my string";

            //in diesem fall wäre contains true. Hier ist jedoch vorsicht geboten, denn "is" befindet sich auch im Wort "This". Auch wenn das Wort "is" nicht im string enthalten wäre,
            //wäre das Ergebnis true.
            bool contains = mystring.Contains("is");

            //Für diesen speziellen Fall wäre es besser auf " is " zu prüfen. Wichtig ist, dass operationen dieser Art immer abhängig vom Kontext sind.
            contains = mystring.Contains(" is ");


            //Zwei weitere nützliche Methoden sind StartsWith() und EndsWith()
            bool startsWith = mystring.StartsWith("Th");
            bool endsWith = mystring.EndsWith("ing");


            //wichtig ist, dass all diese Operationen "case sensitiv" sind, also auch Groß- und Kleinschreibung beachten. "This" ist nicht das gleiche wie "thiS".
        }


        //====================================================
        //                Konsolen Werkzeuge
        //====================================================

        void ConsoleTools()
        {

            //Ausgabe von einer vollständigen Zeile inklusive Zeilenumbruch
            Console.WriteLine();

            //Schreibt in die Ausgabe der Konsole. Jedes weitere mal wenn Write() aufgerufen wird, wird der Wert in der gleichen Zeile an den bereits vorhandenen Inhalt heran gehängt.
            Console.Write("asd");
            Console.Write("def");

            //Die Konsolenapplikation wartet darauf, dass der Benutzer enter drückt. Die Applikation läuft nicht weiter bis dies passiert ist. Anschließend wird der Wert,
            //der eingegeben wurde, zurückgegeben und kann in einer variable gespeichert werden.
            string result = Console.ReadLine();
        }

        #endregion

    }
}
