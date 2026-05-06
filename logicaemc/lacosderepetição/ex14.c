#include <stdio.h>
int main(){
int num, soma = 0;
printf("Digite um numero inteiro: ");
scanf("%d", &num);
for(; num != 0; num = num / 10){
soma = soma + (num % 10);
}
printf("A soma dos digitos eh: %d", soma);
return 0;
}