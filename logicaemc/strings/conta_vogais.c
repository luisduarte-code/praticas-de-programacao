#include <stdio.h>
#include <string.h>
#include <ctype.h>

int main(){
    char palavra[20];
    int qtdvogais = 0;
    printf("Digite uma palavra: ");
    scanf("%19s", palavra);
    for(int i = 0; i < (int)strlen(palavra); i++){
        char c = toupper((unsigned char)palavra[i]);
        if(c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U'){
            qtdvogais++;
        }
    }
    printf("A quantidade de vogais que tem na sua palavra eh %d", qtdvogais);
    return 0;
}
