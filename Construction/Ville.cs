using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Console = Colorful.Console;
namespace Construction
{
    

    internal class Ville
    {
        private string nom;
        private int nombreBatiment;
        protected Batiment[] lesBatiments;
        public Ville(string nom, int nombreBatiment)
        {
            this.nom = nom;
            this.nombreBatiment = nombreBatiment;
            lesBatiments = new Batiment[nombreBatiment];
        }
        public void AjouterBatiment(Batiment batiment ,int rang)
        {
            lesBatiments[rang] = batiment;

        }
        public void AfficherInfo()
        {
            string message = "INFORMATIONS DE LA VILLE";
            Console.WriteLine(message, Color.DarkOrange);
            Console.WriteLine("NOM DE LA VILLE :             " + nom);
            Console.WriteLine("NOMBRE DE BATIMENT  :         " + nombreBatiment);
            for(int i = 0; i < lesBatiments.Length; i++)
            {
                lesBatiments [i].AfficherInfo();

            }

        }
        public Batiment[] RetournerBat()
        {
           return lesBatiments;
        }
    }
}
