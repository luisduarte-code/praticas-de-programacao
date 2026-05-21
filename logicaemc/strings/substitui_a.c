#include <stdio.h>
#include <string.h>

int main(){
    char frase[100];
    printf("Informe uma frase: ");
    scanf(" %[^
]", frase);
    for(int i = 0; frase[i] != '\0'; i++){
        if(frase[i] == 'a'){
            frase[i] = '@';
        }
    }
    printf("frase nova: %s", frase);
    return 0;
}
