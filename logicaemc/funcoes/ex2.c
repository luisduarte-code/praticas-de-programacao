#include <stdio.h>
#include <stdlib.h>
// função que retorna o quadrado de um numero, e as duas formas de imprimir o resultado
int quadrado(int a){
	return a*a;
}
int main(){
	int n, valorquadrado;
	printf("informe o numero que desejas calcular o quadrado: ");
	scanf("%d",&n);
	//valorquadrado = quadrado(n);
	//printf("O valor do quadrado do seu numero eh: %d",valorquadrado); 
	printf("O valor do quadrado do seu numero eh: %d",quadrado(n)); 
	

	
	
	
	return 0;
}