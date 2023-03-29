using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalNamespace;
using ChienNamespace;
using ChatNamespace;

namespace AmitieNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            Chat cat =  new Chat("Cat", humeurAnim.bonne);
            Chien dog = new Chien("Dog",humeurAnim.bonne);
            Chien doggy= new Chien("Doggy", humeurAnim.bonne);
            if (cat.Humeur is humeurAnim.bonne)
            {
                cat.MeilleurAmi = "Dog";
                dog.MeilleurAmi = "Cat";
                doggy.Humeur = humeurAnim.mauvaise;
            }
            else
            {
                Console.WriteLine("cat est parti");
            }
            if(doggy.Humeur is humeurAnim.mauvaise)
            {
                dog.MeilleurAmi = "Doggy";
                doggy.MeilleurAmi = "Dog";
                doggy.Humeur = humeurAnim.bonne;
                
            }
            Console.WriteLine("Etats des animaux");
            cat.AfficherEtat();
            dog.AfficherEtat();
            doggy.AfficherEtat();





        }


    }
}
