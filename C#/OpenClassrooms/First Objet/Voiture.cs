using System;

namespace First_Objet
{
    public class Voiture
    {

        public string couleur;
        public int vitesse;
        public string Couleur
        {
            get => couleur;
            set => couleur = value;
        }

        public int Vitesse
        {
            get;
            set;
        }

        public void Klaxonner()
        {
            if (!VitesseAutorisée(180))
            {
                Console.WriteLine("Pouet !");
            }
        }
        
        public bool VitesseAutorisée(int vitesse)
        {
            bool estVitesseAutorise = vitesse <= 90;
            return estVitesseAutorise;
        }
        public bool Demarrer()
        {
            if (ClesSurLeContact())
            {
                DemarrerLeMoteur();
                return true;
            }
            return false;
        }

        public void SortirDeLaVoiture()
        {
            if (ClesSurLeContact())
                PrevenirLUtilisateur();
        }
        private bool ClesSurLeContact()
        {
            // faire quelque chose pour vérifier
            return true;
        }
        
        private void DemarrerLeMoteur()
        {
            // faire quelque chose pour démarrer le moteur
        }

        private void PrevenirLUtilisateur()
        {
            Console.WriteLine("Bip bip bip");
        }
    }
}