using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction
{
    internal class RobotEclaireur : Robot
    {
        private Batiment[] batiments;
        public RobotEclaireur(string nom, string description, int resistance) : base(nom, description, resistance)
        {
            batiments = new Batiment[5];

        }
        /*public void ParcourirEtCollecter(Batiment[]taBatim)
        {
            for(int i = 0; i < taBatim.Length; i++)
            {
                for(int j = 0; j < batiments.Length; j++)
                {
                    batiments[j] = taBatim[i];

                }

            }*/
        public override void Explorer(Batiment[] taBatim)
        {
            for (int i = 0; i < taBatim.Length; i++)
            {
                if(taBatim[i].Etat == statutBatiment.parfait)
                {
                    for (int j = 0; j < batiments.Length; j++)
                    {
                        batiments[j] = taBatim[i];

                    }

                }
               


            }

        }
        public override Batiment[] RetournerBat()
        {
            return batiments;
        }




    }
}
