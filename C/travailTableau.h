#include <stdio.h>
#include <stdlib.h>


int sommeTableau(int tableau[], int tailleTableau);
double moyenneTableau(int tableau[], int tailleTableau);
void copie(int tableauOriginal[], int tableauCopie[], int tailleTableau);
void maximumTableau(int tableau[], int tailleTableau, int valeurMax);
void ordonnerTableau(int tableau[], int tailleTableau);
//Fonction Annexe:

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
    //Cast des valeurs en float
    float sumtab = (float) sommeTableau(tableau,tailleTableau);
    float taille = (float) tailleTableau;
    float moyenne = sumtab/taille;
    return moyenne;
}

void copie (int tableauOriginal[], int tableauCopie[], int tailleTableau)
{
    for (int i = 0; i < tailleTableau; i++)
    {
        tableauCopie[i] = tableauOriginal[i];
    }
    for (int j = 0; j < tailleTableau ; j++)
    {
        printf("%d", tableauOriginal[j]);
    }
    printf("\n");
    for(int k = 0 ; k  <tailleTableau ; k++)
    {
        printf("%d", tableauCopie[k]);
    }
    printf("\n");
}

void MaximumTableau (int tableau[],int tailleTableau , int valeurMax)
{
    for (int i = 0 ; i < tailleTableau ; i++)
    {
        if(tableau[i] > valeurMax)
        {
            tableau[i] = 0;
        }
    }
    for(int j = 0 ; j < tailleTableau ; j++)
    {
        printf("%d", tableau[j]);
    }
    printf("\n");
}


void swap(int *xp, int *yp) 
{
    int temp = *xp;
    *xp = *yp;
    *yp = temp;
}

void ordonnerTableau(int arr[], int n)
{
   int i, j;
   for (i = 0; i < n-1; i++)

       // Last i elements are already in place
       for (j = 0; j < n-i-1; j++)
           if (arr[j] > arr[j+1])
              swap(&arr[j], &arr[j+1]);

   for(int k = 0 ; k < n ; k++)
   {
       printf("%d", arr[k]);
   }
}
