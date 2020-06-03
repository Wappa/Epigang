using System;

namespace First_Objet
{
    public class Animal
    {
        protected string prenom;

        protected bool estVivant;
        public int age;

        public int NombreDePattes { get; set; }

        public void Respirer()
        {
            Console.WriteLine("Je respire");
        }
    }
    public class Chien : Animal
    {
        public Chien(string prenomDuChien)
        {
            prenom = prenomDuChien;
        }
        public void Aboyer()
        {
            Console.WriteLine("Wouaf !");
        }
        public void Vieillir()
        {
            age++;
        }

        public void Naissance()
        {
            age = 0;
            estVivant = true;   // Erreur	> 'MaPremiereApplication.Animal.estVivant' 
            // est inaccessible en raison de son niveau de protection
        }
    }

    public class Chat : Animal
    {
        public Chat(string prenomDuChat)
        {
            prenom = prenomDuChat;
        }

        public void Miauler()
        {
            Console.WriteLine("Miaou");
        }
    }
}