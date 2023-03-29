using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Console = Colorful.Console;
namespace Construction
{
    enum statutBatiment
    {
        parfait,
        necessiteReparation,
        aDemolir,
    }

    internal class Batiment
    {
        protected string nature;
        public statutBatiment Etat{ get; set; }
        protected int priorite;
        protected int quantiteRessources;
        public Batiment(string nature, statutBatiment etat,int priorite,int quantiteRessources) 
        {
            this.nature= nature;
            this.Etat = etat;
            this.priorite = priorite;
            this.quantiteRessources = quantiteRessources;
        }
        public void AfficherInfo()
        {
            string message = "INFORMATIONS D'UN BATIMENT";
            Console.WriteLine(message, Color.DarkOrange);
            Console.WriteLine("NATURE DU BATIMENT :             " + nature);
            Console.WriteLine("ETAT DU BATIMENT  :         " +    Etat);
            Console.WriteLine("PRIORITE DU BATIMENT  :         " + priorite);
            Console.WriteLine("QUANTITE DE RESSOURCES NECESSAIRES  :         " + quantiteRessources);

        }
        
    }
}
