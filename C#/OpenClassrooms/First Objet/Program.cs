using System;
using System.Collections.Generic;

namespace First_Objet
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animaux = new List<Animal>();
            Animal chien = new Chien("Bill");
            Animal tom = new Chat("Tom");
            Animal felix = new Chat("Félix");

            animaux.Add(chien);
            animaux.Add(tom);
            animaux.Add(felix);

            foreach (Animal animal in animaux)
            {
                animal.Respirer();
            }
        }
    }
    
}