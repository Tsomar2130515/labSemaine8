using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction
{
    internal class UsineDeCreation
    {
        private string nom;
        public UsineDeCreation(string nom)
        {
            this.nom = nom;
            
        }
        public Robot CreerRobot(string besoin,string nom,string description,int resistance)
        {
            Robot leRobot;
            if (besoin == "Transport")
            {
                leRobot= new RobotTransport(nom, description, resistance);
                PieceTransport piece1 = new PieceTransport("Bac de transport",10);
                Piece piece2 = new Piece("Corps", 8);
                PieceTransport piece3 = new PieceTransport("Roue", 10);
                leRobot.AjouterPiece(piece1,0);
                leRobot.AjouterPiece(piece2, 1);
                leRobot.AjouterPiece(piece3, 2);
            }
            else if(besoin == "Construction")
            {
                leRobot = new RobotConstruction(nom, description, resistance);
                PieceConstruction piece4 = new PieceConstruction("Bac de clous", 10);
                Piece piece5 = new Piece("Corps", 8);
                PieceConstruction piece6= new PieceConstruction("Bac de ciment", 15);
                leRobot.AjouterPiece(piece4, 0);
                leRobot.AjouterPiece(piece5, 1);
                leRobot.AjouterPiece(piece6, 2);
            }
            else if (besoin == "Destruction")
            {
                leRobot = new RobotDestruction(nom, description, resistance);
                PieceDestruction piece7 = new PieceDestruction("Marteau", 10);
                Piece piece8= new Piece("Corps", 8);
                PieceDestruction piece9 = new PieceDestruction("Broyeur", 15);
                leRobot.AjouterPiece(piece7, 0);
                leRobot.AjouterPiece(piece8, 1);
                leRobot.AjouterPiece(piece9, 2);
            }
            else 
            {
                leRobot = new RobotEclaireur(nom, description, resistance);
                PieceTransport piece10 = new PieceTransport("Bac de transport", 10);
                PieceDestruction piece11 = new PieceDestruction("Marteau", 10);
                Piece piece12 = new Piece("Corps", 8);
                leRobot.AjouterPiece(piece10, 0);
                leRobot.AjouterPiece(piece11, 1);
                leRobot.AjouterPiece(piece12, 2);
            }
            return leRobot;

        }

    }
}
