using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    public class Competiteur
    {
        private int NumeroCompetiteur { get; set; }
        private string NomCompetiteur { get; set; }
        private string PrenomCompetiteur { get; set; }
        private int ClassementFIS { get; set; }
        private int ClassementWCSL { get; set; }


        public Competiteur(int num, string nom, string prenom, int classFIS, int classWCSL)
        {
            this.NumeroCompetiteur = num;
            this.NomCompetiteur = nom;
            this.PrenomCompetiteur = prenom;
            this.ClassementFIS = classFIS;
            this.ClassementWCSL = classWCSL;
        }


    }
}
