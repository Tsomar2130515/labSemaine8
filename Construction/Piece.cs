using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Console = Colorful.Console;

namespace Construction
{
    
    internal class Piece
    {
        protected string nom;
        protected int force;
        public Piece(string nom ,int force)
        {
            this.nom = nom;
            this.force = force;
            
        }
        public void AfficherInfo()
        {
            string message = "INFORMATIONS D'UNE PIECE DE ROBOT";
            Console.WriteLine(message, Color.DarkOrange);
            Console.WriteLine("NOM DE LA PIECE :             " + nom);
            Console.WriteLine("FORCE DE LA PIECE   :         " +force );

        }
    }
}
