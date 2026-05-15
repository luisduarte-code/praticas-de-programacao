#include <stdio.h>
int main(){

float Numeros[10],media=0,soma=0;
for (int i = 0; i<10 ; i++){
	printf("Insira o numero: \n",i);
	scanf("%f", &Numeros[i]);
	soma += Numeros[i];
}
media=soma/10;
printf("Soma = %.2f ",soma);
printf("Media = %.2f",media);	


return 0;
}