#include <stdio.h>

void dobrar(int array[],int tam);
int main(){
	
 int array[10], tam;
		printf("informe o tamanho do array: ");
		scanf("%d",&tam);
		for(int i= 0;i<tam;i++){
			printf("Informe o numero: ");
			scanf("%d",&array[i]);
		}
		dobrar(array, tam);
		for(int i = 0; i < tam; i++){
		    printf("%d ", array[i]);
		}		
		
	
	
	
	return 0;
}
void dobrar(int array[],int tam){
	for(int i = 0;i<tam;i++){
		array[i]=array[i]*2;
	}
}
	// se a função faz algo novoela vaiter que retonar algo, mas se ela so modifica ent ela é void pois as funcao vai ser parar modificar o que ja se tinha
	