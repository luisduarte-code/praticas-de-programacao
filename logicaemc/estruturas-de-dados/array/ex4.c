#include <stdio.h>
int main(){
int array[5];
// lê o array 
	for (int i=0; i<5; i++){
		printf("Informe a sequencia que quer ter 1 por 1: ");
		scanf("%d",&array[i]);
		}
		printf("Assim ficou o array invertido: ");
        //retorna o array invertido
	for (int i=4; i>=0; i--){
		printf("%d",array[i]);
	}
	


return 0;
}