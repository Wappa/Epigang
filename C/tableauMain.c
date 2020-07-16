#include <stdio.h>
#include <stdlib.h>
#include "travailTableau.h"

int main()
{
    int tableau[4] = {1,2,3,4};
    int teblo [5] = {5,1,4,2,8};
    int Copie[4] = {0,0,0,0};
    //printf("%d \n",sommeTableau(tableau, 4));
    ordonnerTableau(teblo,5);
    printf("\n");
    return 0;
}
