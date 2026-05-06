#include <stdio.h>
int main(){
int num, soma = 0;
printf("Digite um numero: ");
scanf("%d", &num);
for(int i = 1; i < num; i++){
if(num % i == 0){
soma += i;
}
}
if(soma == num){
printf("Numero perfeito");
} else {
printf("Nao eh numero perfeito");
}
return 0;
}