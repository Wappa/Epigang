#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int main ( int argc, char** argv )
{
    int continu = 1;
    while(continu)
    {

        int nombreMystere = 0, nombreEntre = 0, count = 0 ;
        int level = 1;
        const int MIN = 1;
        int MAX = 0;
        printf("Choisissez un niveau entre 1 et 3 \n");
        scanf("%d", &level);
        switch(level)
        {
            case 2:
                MAX = 1000;
                break;
            case 3:
                MAX = 10000;
                break;
            default:
                MAX = 100;
                break;
        }

        // Génération du nombre aléatoire

        srand(time(NULL));
        nombreMystere = (rand() % (MAX - MIN + 1)) + MIN;

    /* La boucle du programme. Elle se répète tant que l'utilisateur n'a pas trouvé le nombre mystère */

        do
        {
        // On demande le nombre
            printf("Quel est le nombre ? ");
            scanf("%d", &nombreEntre);

        // On compare le nombre entré avec le nombre mystère

            if (nombreMystere > nombreEntre)
            {
                printf("C'est plus !\n\n");
                count++;
            }
            else if (nombreMystere < nombreEntre)
            {
                printf("C'est moins !\n\n");
                count++;
            }
            else
                printf ("Bravo, vous avez trouve le nombre mystere !!!\n\n");
        }while (nombreEntre != nombreMystere);

        printf("Vous avez trouve en %d coups \n", count);

        printf("Voulez vous continuez ? Pressez 1 pour continuer sinon 0 ? \n");
        scanf("%d", &continu);
    }
    return 0;
}
