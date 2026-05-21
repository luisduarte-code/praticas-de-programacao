#include <stdio.h>
#include <string.h>

int main(){
    char frase[100];
    char p, u;
    printf("Digite uma frase: ");
    scanf(" %[^
]", frase);
    for(int i = 0; frase[i] != '\0'; i++){
        if(frase[i] != ' '){
            p = frase[i];
            break;
        }
    }
    u = frase[strlen(frase) - 1];
    printf("A primeira letra eh: %c\n", p);
    printf("A ultima letra eh: %c", u);
    return 0;
}
