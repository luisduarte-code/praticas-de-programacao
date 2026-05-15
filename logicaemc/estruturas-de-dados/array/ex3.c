#include <stdio.h>
int main(){

float array[8],maior,menor;
//ler todos os 8 valores
for(int i =0; i<8;i++){
	printf("insira valores pro meu vetor de 8 posicoes:");
	scanf("%f",&array[i]);
}
// Definição for do loop
	maior=array[0];
	menor=array[0];
	//For para a verificação 
for(int i =0; i<8;i++){	
	if(array[i]>=maior){
		maior = array[i];
	}else if(array[i]<=menor){
		menor = array[i];
	}
}
printf("O maior eh = %.2f",maior);
printf("O menor eh = %.2f",menor);
return 0;
}