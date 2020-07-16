int main(int argc, char *argv[])

{

    char prenom[100];


    printf("Comment t'appelles-tu petit Zero ? ");

    scanf("%s", prenom);

    printf("Salut %s, je suis heureux de te rencontrer !", prenom);


    return 0;

}

#include <string.h>

int main(int argc, char *argv[])

{

    char chaine[] = "Salut";

    int longueurChaine = 0;


    // On récupère la longueur de la chaîne dans longueurChaine

    longueurChaine = strlen(chaine);


    // On affiche la longueur de la chaîne

    printf("La chaine %s fait %d caracteres de long", chaine, longueurChaine);


    return 0;

}

int main(int argc, char *argv[])

{

    /* On crée une chaîne "chaine" qui contient un peu de texte

    et une copie (vide) de taille 100 pour être sûr d'avoir la place

    pour la copie */



    char chaine[] = "Texte", copie[100] = {0};


    strcpy(copie, chaine); // On copie "chaine" dans "copie"


    // Si tout s'est bien passé, la copie devrait être identique à chaine

    printf("chaine vaut : %s\n", chaine);

    printf("copie vaut : %s\n", copie);


    return 0;

}

int main(int argc, char *argv[])

{

    /* On crée 2 chaînes. chaine1 doit être assez grande pour accueillir

    le contenu de chaine2 en plus, sinon risque de plantage */

    char chaine1[100] = "Salut ", chaine2[] = "Mateo21";


    strcat(chaine1, chaine2); // On concatène chaine2 dans chaine1


    // Si tout s'est bien passé, chaine1 vaut "Salut Mateo21"

    printf("chaine1 vaut : %s\n", chaine1);

    // chaine2 n'a pas changé :

    printf("chaine2 vaut toujours : %s\n", chaine2);


    return 0;

}

int main(int argc, char *argv[])

{

    char chaine1[] = "Texte de test", chaine2[] = "Texte de test";


    if (strcmp(chaine1, chaine2) == 0) // Si chaînes identiques

    {

        printf("Les chaines sont identiques\n");

    }

    else

    {

        printf("Les chaines sont differentes\n");

    }


    return 0;

}

int main(int argc, char *argv[])

{

    char chaine[] = "Texte de test", *suiteChaine = NULL;


    suiteChaine = strchr(chaine, 'd');

    if (suiteChaine != NULL) // Si on a trouvé quelque chose

    {

        printf("Voici la fin de la chaine a partir du premier d : %s", suiteChaine);

    }


    return 0;

}

int main(int argc, char *argv[])

{

    char *suiteChaine;


    // On cherche la première occurrence de x, d ou s dans "Texte de test"

    suiteChaine = strpbrk("Texte de test", "xds");


    if (suiteChaine != NULL)

    {

        printf("Voici la fin de la chaine a partir du premier des caracteres trouves : %s", suiteChaine);

    }


    return 0;

}

int main(int argc, char *argv[])

{

    char *suiteChaine;


    // On cherche la première occurrence de "test" dans "Texte de test" :

    suiteChaine = strstr("Texte de test", "test");

    if (suiteChaine != NULL)

    {

        printf("Premiere occurrence de test dans Texte de test : %s\n", suiteChaine);

    }


    return 0;

}

#include <stdio.h>

#include <stdlib.h>


int main(int argc, char *argv[])

{

    char chaine[100];

    int age = 15;


    // On écrit "Tu as 15 ans" dans chaine

    sprintf(chaine, "Tu as %d ans !", age);


    // On affiche chaine pour vérifier qu'elle contient bien cela :

    printf("%s", chaine);


    return 0;

}
