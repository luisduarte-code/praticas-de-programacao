#include <stdio.h>
#include <string.h>

int main(){
    char p1[20], p2[20];
    printf("Informe a p1: ");
    scanf("%19s", p1);
    printf("Informe a p2: ");
    scanf("%19s", p2);
    if (strcmp(p1, p2) == 0){
        printf("Elas sao iguais");
    } else {
        printf("Nao sao iguais");
    }
    return 0;
}
