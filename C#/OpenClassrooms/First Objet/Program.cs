using System;

namespace First_Objet
{
    class Program
    {
        static void Main(string[] args)
        {
            Voiture voitureNicolas = new Voiture();
            voitureNicolas.Klaxonner();
            voitureNicolas.Couleur = "rouge";
            voitureNicolas.Vitesse = 50;
        }
    }
    
}