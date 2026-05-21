#include <stdio.h>
#include <string.h>

int main(){
    char frase[100], frasese[100];
    printf("Informe uma frase: ");
    scanf(" %[^
]", frase);
    for(int i = 0, j = 0; frase[i] != '\0'; i++){
        if(frase[i] != ' '){
            frasese[j] = frase[i];
            j++;
        }
    }
    frasese[strlen(frase) - 1] = '\0';
    // Better to terminate using j in case there are trailing spaces
    frasese[j] = '\0';
    printf("Frase sem espaco: %s", frasese);
    return 0;
}
