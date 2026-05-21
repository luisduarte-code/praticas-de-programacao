#include <stdio.h>
void trocar(int *a,int *b);
int a,b;
int main(){
	printf("Informe o valor de a: ");
	scanf("%d",&a);
	printf("informe o valor de b: ");
	scanf("%d",&b);
	trocar(&a, &b);
	printf("a= %d e b= %d",a,b);	
	
	
	return 0;
}
void trocar(int *a, int *b){
	int temp = *a;
	*a = *b;
	*b = temp;
}