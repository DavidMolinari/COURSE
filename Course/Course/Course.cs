using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{/// <summary>
/// Chaque objet de la classe Course est une épreuve de la Coupe du Monde.
/// </summary>
    abstract class Course
    {
        public string NomCompetition { get; set; }
        // peu sûr du format :  DateTime thisDate1 = new DateTime(2011, 6, 10);
        public DateTime DateCompetition { get; set; }

        protected List<Participation> lesParticipants;


        /// <summary>
        /// Procedure à implémenter plus tard
        /// </summary>
        protected void classerLesParticipant() { }
        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="pNomCompetition"></param>
        /// <param name="pDateCompetition"></param>
        /// <param name="pParticipants"></param>

        public Course(string pNomCompetition, DateTime pDateCompetition, List<Participation> pParticipants)
        {
            this.NomCompetition = pNomCompetition;
            this.DateCompetition = pDateCompetition;
            this.lesParticipants = pParticipants;
        }



        /// <summary>
        /// La méthode est à définir dans les classes Filles de Course
        /// </summary>
        public abstract void traitementDossards();


    
    }
}
