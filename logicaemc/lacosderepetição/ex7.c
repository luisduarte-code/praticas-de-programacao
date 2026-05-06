#include <stdio.h>
int main(){
	int  senhainserida;

	printf("Insira a senha no console:");
	scanf("%d",&senhainserida);
	if(senhainserida!=1234){
		for(int i=2;i>0;i--){
			printf("Voce tem mais %d: chances",i);
			scanf("%d",&senhainserida);
			if(senhainserida==1234){
				break;
			}
			printf("Acesso negado!");
		}
	}
	if(senhainserida==1234){
		printf("acesso liberado");
	}



return 0;
}