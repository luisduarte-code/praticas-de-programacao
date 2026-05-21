#include <stdio.h>
#include <string.h>
#include <ctype.h>

int main(){
    char palavra[20], palavramais[20];
    printf("Digite uma palavra: ");
    scanf("%19s", palavra);
    for(int i = 0; i < (int)strlen(palavra); i++){
        palavramais[i] = toupper((unsigned char)palavra[i]);
    }
    palavramais[strlen(palavra)] = '\0';
    printf("Palavra maiuscula: %s", palavramais);
    return 0;
}
