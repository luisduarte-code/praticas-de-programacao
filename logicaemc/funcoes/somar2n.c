#include <stdio.h>
float soma(float x, float y);
float x,y;
int main()
{
	printf("Informe o valor de x e de y: ");
	scanf("%f""%f",&x,&y);
	printf("O valor da soma eh:%.2f ",soma(x,y));
	return 0;
}
float soma(float x,float  y){
	float resultado;
	resultado = x+y;
	return  resultado;//poderia retornar direto só com um return fazendo a soma return x+y;
}