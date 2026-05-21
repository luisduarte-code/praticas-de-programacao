#include <stdio.h>
#include <string.h>

int main(){
    char palavra[20], palavraInvertida[20];
    printf("Digite a palavra que deseja inverter: ");
    scanf("%19s", palavra);
    int len = strlen(palavra);
    for(int i = len - 1, y = 0; i >= 0; i--, y++){
        palavraInvertida[y] = palavra[i];
    }
    palavraInvertida[len] = '\0';
    printf("Aqui esta a palavra invertida: %s", palavraInvertida);
    return 0;
}
