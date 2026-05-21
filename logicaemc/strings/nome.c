#include <stdio.h>
#include <string.h>

int main(){
    char nome[20];
    printf("Informe o seu nome: ");
    scanf("%19s", nome);
    printf("ola %s como estas?", nome);
    return 0;
}
