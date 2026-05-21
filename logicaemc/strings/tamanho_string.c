#include <stdio.h>
#include <string.h>

int main(){
    char palavra[20];
    printf("Digite uma palavra: ");
    scanf("%19s", palavra);
    printf("O tamanho da sua string eh %d", (int)strlen(palavra));
    return 0;
}
