using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalNamespace
{
    enum humeurAnim
    {
       bonne,
       mauvaise,
    }

    class Animal
    {
        protected  string NomCode{ get; set; }
        public humeurAnim Humeur { get; set; }
        public  string MeilleurAmi { get; set; }

        public Animal(string nomCode, humeurAnim humeur)
        {
            this.NomCode = nomCode;
            this.Humeur = humeur;
            this.MeilleurAmi = "";

        }
        public void AfficherEtat()
        {
            Console.WriteLine("NOM ANIMAL : " + NomCode);
            Console.WriteLine("HUMEUR ANIMAL  :" + Humeur);
            Console.WriteLine("MEILLEUR AMI : "+ MeilleurAmi);
           
        }


    }
}
