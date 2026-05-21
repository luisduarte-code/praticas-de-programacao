#include <stdio.h>
#include <string.h>

int main(){
    char frase[100];
    int countSpace = 0;
    printf("Informe uma frase: ");
    scanf(" %[^
]", frase);
    for(int i = 0; frase[i] != '\0'; i++){
        if(frase[i] == ' '){
            countSpace++;
        }
    }
    printf("Essa frase tem %d espacos", countSpace);
    return 0;
}
