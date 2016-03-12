using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    class Course_Slalom : Course
    {





        /// <summary>
        /// Méthode à implémenter plus tard 
        /// </summary>
        public override void traitementDossards()
        {

            //throw new NotImplementedException();
        }

        /// <summary>
        ///  Ctor PROVISOIR, pour éviter l'érreur des parametres Obligatoires à implémenter plus tard 
        /// </summary>
        /// <param name="pNomCompetition"></param>
        /// <param name="pDateCompetition"></param>
        /// <param name="pParticipants"></param>
        public Course_Slalom(string pNomCompetition, DateTime pDateCompetition, List<Participation> pParticipants):base(pNomCompetition, pDateCompetition, pParticipants)
        {

        }
    }
}
