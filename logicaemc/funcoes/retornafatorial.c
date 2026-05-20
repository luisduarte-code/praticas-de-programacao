#include <stdio.h>
int n, i;
int fatorial(int n);
int main(){
	printf("Informe o numero que desejas calcular o fatorial: ");
	scanf("%d",&n);
	printf("Ele fatorial ficou = %d",fatorial(n));
	
	
	
	return 0;
}
int fatorial(int n){
	int oqquero = n;
	for(i=1;i<oqquero;i++ ){
		n = n * i;
	}
	return n;
}