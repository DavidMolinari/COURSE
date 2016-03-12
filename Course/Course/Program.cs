using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Competiteur> unCompetiteur = new List<Competiteur>();
            unCompetiteur.Add(new Competiteur(21, "Bertrand", "Joel", 01, 02));
            unCompetiteur.Add(new Competiteur(11, "Morel", "Daniel", 02, 02));
            unCompetiteur.Add(new Competiteur(22, "Meho", "Franky", 02, 04));


            foreach (Competiteur o in unCompetiteur)
            {
                Console.WriteLine(o);
            }


            List<Participation> testParticip = new List<Participation>();
            testParticip.Add(new Participation(09, 1,00,"Gotze", "Julie", 21, 31));
            testParticip.Add(new Participation(03, 1, 00, "Mario", "Daùmien", 25, 32));
            testParticip.Add(new Participation(04, 1, 00, "Sigurdson", "Carlos", 11, 35));
            testParticip.Add(new Participation(05, 1, 00, "Jaho", "Pedro", 25, 36));

            foreach (Participation o in testParticip)
            {
                Console.WriteLine(o);
            }

            Console.Read();
        }
    }
}
