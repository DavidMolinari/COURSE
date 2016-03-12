using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    public class Competiteur
    {
        public int NumeroCompetiteur { get; set; }
        public string NomCompetiteur { get; set; }
        public string PrenomCompetiteur { get; set; }
        public int ClassementFIS { get; set; }
        public int ClassementWCSL { get; set; }


        public Competiteur(int num, string nom, string prenom, int classFIS, int classWCSL)
        {
            this.NumeroCompetiteur = num;
            this.NomCompetiteur = nom;
            this.PrenomCompetiteur = prenom;
            this.ClassementFIS = classFIS;
            this.ClassementWCSL = classWCSL;
        }

        public override string ToString()
        {
            return this.NumeroCompetiteur + " " +this.NomCompetiteur + " " +  this.PrenomCompetiteur + " " + this.ClassementFIS + " " + this.ClassementWCSL;
        }

    }
}
