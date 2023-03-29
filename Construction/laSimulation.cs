using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Console = Colorful.Console;

namespace Construction
{
    internal class laSimulation
    {
        private string nom;
        public laSimulation(string nom)
        {
            this.nom = nom;
        }
        public string CreerDesBesoins(Batiment bat)
        {
            string besoin = "";
            if (bat.Etat == statutBatiment.necessiteReparation)
            {
                besoin = "Construction";
            }
            else if (bat.Etat == statutBatiment.aDemolir)
            {
                besoin = "Destruction";
            }
            else if(bat.Etat == statutBatiment.parfait)
            {
                besoin = "Exploration";
            }
            else
            {
                besoin = "Transport";
            }


            return besoin;
        }

        public string VerifierNatureRobot(Robot robot)
        {
            string nature = "";
            if (robot is RobotConstruction)
            {
                nature = "RobotConstruction";
            }
            else if (robot is RobotDestruction)
            {
                nature = "RobotDestruction";
            }
            else if (robot is RobotTransport)
            {
                nature = "RobotTransport";
            }
            else
            {
                nature = "RobotEclaireur";
            }
            return nature;
        }




        public void GererChantier(Robot robot, Batiment batim)
        {
            if (batim.Etat is statutBatiment.necessiteReparation && robot is RobotConstruction)
            {
                Console.WriteLine("ANCIEN ETAT DU BATIMENT  :" + batim.Etat) ;
                batim.Etat = statutBatiment.parfait;
                Console.WriteLine("NOUVEL ETAT DU BATIMENT  :" + batim.Etat);
            }
            else if (batim.Etat is statutBatiment.aDemolir && robot is RobotDestruction)
            {
                Console.WriteLine("ANCIEN ETAT DU BATIMENT  :" + batim.Etat);
                batim.Etat = statutBatiment.aDemolir;
                Console.WriteLine("NOUVEL ETAT DU BATIMENT  :" + batim.Etat);
            }
            else 
            {
                Console.WriteLine("ANCIEN ETAT DU BATIMENT  :" + batim.Etat);
                Console.WriteLine("NOUVEL ETAT DU BATIMENT  :" + batim.Etat);
            }

        }


        public void Simuler()
        {
            Ville montreal = new Ville("Montréal", 5);
            UsineDeCreation monUsine = new UsineDeCreation("Wallys");
            Batiment bat1 = new Batiment("maison", statutBatiment.necessiteReparation, 1, 10);
            Batiment bat2 = new Batiment("Usine", statutBatiment.necessiteReparation, 1, 10);
            Batiment bat3 = new Batiment("Centre commercial", statutBatiment.parfait, 3, 8);
            Batiment bat4 = new Batiment("maison", statutBatiment.aDemolir, 4, 10);
            Batiment bat5 = new Batiment("maison", statutBatiment.necessiteReparation, 1, 10);
            montreal.AjouterBatiment(bat1, 0);
            montreal.AjouterBatiment(bat2, 1);
            montreal.AjouterBatiment(bat3, 2);
            montreal.AjouterBatiment(bat4, 3);
            montreal.AjouterBatiment(bat5, 4);
            Robot rob1 = monUsine.CreerRobot("Eclaireur", "monRobot", "RobEclaireur", 15);
            rob1.Explorer(montreal.RetournerBat());
            Batiment batTest = rob1.RetournerBat()[0];
            string besoin = CreerDesBesoins(batTest);
            Robot rob2 = monUsine.CreerRobot(besoin, "monRob", "monRobot", 10);
            //GererChantier(rob2, rob1.RetournerBat()[0]);
            GererChantier(rob2, bat1);
            montreal.AfficherInfo();
            Console.WriteLine("Nature du robot :" + VerifierNatureRobot(rob1));
            rob1.AfficherInfo();
            Console.WriteLine("Nature du robot :" + VerifierNatureRobot(rob2));
            rob2.AfficherInfo();

        }









    }
}
