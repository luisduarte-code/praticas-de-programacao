#include <stdio.h>//para descobrir a quantidade de numeros pares e impares
int main(){
int  array[10], countpar=0, countimpar=0;
for(int i=0;i<10;i++){
	printf("informe os numeros: ");
	scanf("%d",&array[i]);
	if(array[i] % 2 == 0){
		countpar++;
	}else if(array[i] % 2 == 1 ){
		countimpar++;
	}
}
printf("A quantidade de numeros pares eh: %d \n",countpar);
printf("A quantidade de numeros impares eh: %d \n ",countimpar);






return 0;
}