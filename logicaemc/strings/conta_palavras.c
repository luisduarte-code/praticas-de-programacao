#include <stdio.h>
#include <string.h>
#include <ctype.h>

int main(){
    char frase[100];
    int qtdpalavras = 0;
    printf("Informe uma frase: ");
    scanf(" %[^
]", frase);
    for(int i = 0; frase[i] != '\0'; i++){
        if((frase[i] != ' ' && frase[i+1] == ' ') || (frase[i] != ' ' && frase[i+1] == '\0')){
            qtdpalavras++;
        }
    }
    printf("Essa frase tem %d palavras", qtdpalavras);
    return 0;
}
