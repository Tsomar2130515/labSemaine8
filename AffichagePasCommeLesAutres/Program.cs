using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Humanizer;
using System.Drawing;
using Alba.CsConsoleFormat.Fluent;
using Console = Colorful.Console;
namespace Affichage
{
    class Program
    {
        static void TestHumainPhrase(string test)
        {
            Console.WriteLine(test.Humanize());/* Humanise le texte*/
            Console.WriteLine(test.Transform(To.LowerCase, To.TitleCase));/*Transforme les minuscules em majuscules*/
            Console.WriteLine(test.Dehumanize());/*Dehumanise le texte*/
            Console.WriteLine(test.Truncate(5));/*Raccourci le texte*/
        }
        static void TestHumainChiffre(int chiffre)
        {
            Console.WriteLine(DateTime.UtcNow.AddHours(chiffre).Humanize());

        }
        static void TestConsole(string test)
        {
            Console.WriteLine(test, Color.DeepPink);
            Console.WriteAscii("Utilisation de Nuget", Color.Pink);


        }



        static void Main(string[] args)
        {
            TestHumainPhrase("Premiere_Utilisation_Nuget");
            TestHumainChiffre(41);
            TestConsole("Premiere_Utilisation_Nuget");
            Colors.WriteLine("Hello".Red(), "\n", "world!".Yellow());



        }

    }
}
