#include <stdio.h>
#include <string.h>

int main(){
    char p[20], pc[20];
    printf("informe a primeira palavra: ");
    scanf("%19s", p);
    strcpy(pc, p);
    printf("A palavra copiada eh: %s", pc);
    return 0;
}
