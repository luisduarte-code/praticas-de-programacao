#include <stdio.h>
int parouimpar(int x);
int main()
{
	int x;
	printf("Inform o numero: ");
	scanf("%d",&x);
	parouimpar(x);
	
	if(parouimpar(x)==1){
		printf("O numero eh par");
	}
	else{
		printf("O numero eh impar");
	}
	
}
int parouimpar(int x){
	if(x % 2 == 0)
	{
	return 1;
	}
	else
	{
	return 0;	
	}	
}