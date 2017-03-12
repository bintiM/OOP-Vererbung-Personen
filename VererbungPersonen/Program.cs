using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VererbungPersonen
{
    class Program
    {
        static void Main(string[] args)
        {

            Student st = new Student();
            st.prename = "Hans";
            st.surname = "Klammer";
            st.studyNumber = 17;

            Console.WriteLine(st.ToString());
            string auswahl = "";
            do
            {
                Console.WriteLine("Bitte wählen Sie (A)nzeigen, (Ä)ndern der Personenliste:");
                auswahl = Console.ReadKey().KeyChar.ToString().ToUpper();
                Console.CursorLeft = 0;
            } while (!(auswahl == "A" || auswahl == "Ä"));

            Console.WriteLine("bin weiter");



        }
    }
}
