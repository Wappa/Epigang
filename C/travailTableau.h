#include <stdio.h>
#include <stdlib.h>


int sommeTableau(int tableau[], int tailleTableau);
double moyenneTableau(int tableau[], int tailleTableau);
void copie(int tableauOriginal[], int tableauCopie[], int tailleTableau);
void maximumTableau(int tableau[], int tailleTableau, int valeurMax);
void ordonnerTableau(int tableau[], int tailleTableau);

int sommeTableau(int tableau[], int tailleTableau)
{
    int rtn = 0;

    for(int i = 0 ; i < tailleTableau; i++)
    {
        rtn += tableau[i];
    }
    return rtn;
}

double moyenneTableau(int tableau[], int tailleTableau)
{
    //A refaire avec pointeurs
    int moyenne = sommeTableau(tableau,tailleTableau)/tailleTableau;
    return moyenne;
}
