#include <stdio.h>
#include <string.h>

int main(){
    char nome[20], sobrenome[20];
    printf("Digite seu primeiro nome: ");
    scanf("%19s", nome);
    printf("Digite o sobrenome: ");
    scanf("%19s", sobrenome);
    strcat(nome, sobrenome);
    printf("Seu nome completo: %s", nome);
    return 0;
}
