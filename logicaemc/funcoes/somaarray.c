#include <stdio.h>
int somaArray(int array[], int tamanho);
int main(){
	int tamanho;
	printf("Informe o tamanho do array: ");
	scanf("%d",&tamanho);
	int array[tamanho];
	printf("A soma do array deu: %d", somaArray(array,tamanho));
	return 0;
}
int somaArray(int array[], int tamanho){
	int somaArrays = 0;
	for(int i=0;i<tamanho;i++){
		printf("Informe o %d numero:",i);
		scanf("%d",&array[i]);
		somaArrays = somaArrays + array[i];
	}
	return somaArrays;
}