using System;

namespace First_Objet
{
    class Program
    {
        static void Main(string[] args)
        {
            Voiture voitureNicolas = new Voiture();
            voitureNicolas.Rouler();
            voitureNicolas.Vitesse = 50;
            voitureNicolas.Rouler();
        }
    }
    
}