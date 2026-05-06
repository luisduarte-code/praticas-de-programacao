#include <stdio.h>
int main(){
int num;
printf("Digite um numero inteiro: ");
scanf("%d", &num);
for(; num > 0; num = num / 10){
printf("%d\n", num % 10);
}
return 0;
}