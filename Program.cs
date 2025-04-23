/*
 * Dies ist ein using Statement. Ein using Statement wird verwendet um andere Namespaces verfügbar zu machen. using Statements wirken sich ausschließlich auf die aktuelle Datei aus.
 */
using Starter.Aufgaben;
using Starter.Beispiel;

/*
 * Dies ist der Namespace. Ein Namespace ist ein Bereich in dem Dinge bekannt sind. In diesem Fall heißt der Namespace "Starter".
 * Alles was unterhalb des Namespaces "Starter" erstellt wird, ist im "Starter" Namespace verfügbar.
 */
namespace Starter
{

    /*
     * Dies ist eine Klasse (Class), erkennbar an dem in blau geschriebenen Keyword "class". Classnames werden als türkis dargestellt. 
     * In diesem Fall ist der Name der Class "Program".
     */
    class Program
    {
        /*
         * Dies ist die eine Methode
         */
        static void Main(string[] args)
        {
            //Hier beginnt das Program
            ITask task = new SimpleCalculator();
            task.Run();
        }
    }
}
