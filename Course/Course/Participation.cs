using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    class Participation : Competiteur
    {
        public int numDossard { get; set; }
        public int classement { get; set; }

        public Participation(int numD, int classement, int pNum, string pNom, string pPrenom, int pClassFIS, int pClassWCSL) 
            : base(pNum, pNom, pPrenom, pClassFIS, pClassWCSL)
        {
           
            this.numDossard = numD;
            this.classement = classement;
        }


        public override string ToString()
        {
            return base.ToString() + " " + this.numDossard + " classement : " + this.classement;
        }
    }
}
