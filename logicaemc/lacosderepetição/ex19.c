#include <stdio.h>
int main(){
int n;
float soma = 0;
printf("Digite o valor de N: ");
scanf("%d", &n);
for(int i = 1; i <= n; i++){
soma += 1.0 / i;
}
printf("Soma = %.2f", soma);
return 0;
}