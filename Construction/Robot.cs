using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Console = Colorful.Console;

namespace Construction
{
    internal class Robot
    {
        protected string nom;
        protected string descriprion;
        protected int resistance;
        protected Piece[]lesPieces;
        public Robot(string nom, string description, int resistance)
        {
            this.resistance = resistance;
            this.nom = nom;
            this.descriprion = description;
            lesPieces = new Piece[3];
        }
        public void AjouterPiece(Piece laPiece,int rang)
        {
            lesPieces[rang] = laPiece;

        }
        public void AfficherInfo()
        {
            string message = "INFORMATIONS D'UN ROBOT";
            Console.WriteLine(message, Color.DarkOrange);
            Console.WriteLine("NOM DU ROBOT :             " + nom);
            Console.WriteLine("DESCRIPTION DU ROBOT  :         " + descriprion);
            Console.WriteLine("RESISTANCE DU ROBOT  :         " + resistance);
            for (int i = 0; i < lesPieces.Length; i++)
            {
                lesPieces[i].AfficherInfo();

            }

        }
        public virtual void Explorer(Batiment[] taBatim)
        {
            Console.WriteLine("Exploration");

        }
        public virtual void Construire(Batiment Batim)
        {
            Console.WriteLine("Construire");

        }
        public virtual Batiment[] RetournerBat()
        {
            Batiment[]  lesBatiments = new Batiment[5];
            return lesBatiments;

        }
        

    }
}
