#include <stdio.h>
int x,y,z;
int maior(int x, int y);
int maiorDeTres(int x,int y,int z);
int main()
{
	printf("Informe o n1: ");
	scanf("%d",&x);
	printf("Informe o n2: ");
	scanf("%d",&y);
	printf("Informe o n3: ");
	scanf("%d",&z);
	printf("O maior numero dentre os 3 eh: %d ",maiorDeTres(x,y,z));
	return 0;
}
int maior(int x, int y){
	if(x>y){
		return x;
	}
	else{
		return y;
	}
}
int maiorDeTres(int x,int y,int z){
	maior(x,y);
	if(	maior(x,y)>z){
		return maior(x,y);
	}
	else{
		return z;
	}
	
}