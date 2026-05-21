#include <stdio.h>
#include <string.h>
#include <ctype.h>

int main(){
    char palavra[20], palavramini[20];
    printf("Digite uma palavra: ");
    scanf("%19s", palavra);
    for(int i = 0; i < (int)strlen(palavra); i++){
        palavramini[i] = tolower((unsigned char)palavra[i]);
    }
    palavramini[strlen(palavra)] = '\0';
    printf("Palavra minuscula: %s", palavramini);
    return 0;
}
