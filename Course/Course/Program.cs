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

            List<Participation> testParticip = new List<Participation>();
            testParticip.Add(new Participation(09, 1,00,"Ricard", "QQ", 21, 31));
            testParticip.Add(new Participation(03, 1, 00, "MEhRp", "GS", 25, 32));
            testParticip.Add(new Participation(04, 1, 00, "RicMEhRpard", "JeFan", 11, 35));
            testParticip.Add(new Participation(05, 1, 00, "RicarFDSd", "JeaSn", 25, 36));


            foreach (Participation unParticipant in testParticip)
            {
                Console.WriteLine(unParticipant);
            }


            Console.Read();
        }
    }
}
