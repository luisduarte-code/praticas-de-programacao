#include <stdio.h>
#include <string.h>


int minhaStrlen(char str[]){
	int tam = 0;
	while(str[tam] != '\0'){
		tam++;
	}
	return tam;
}


int main(){
char vet[20]={"luis"};
printf("strlen: %d\n",strlen(vet));
printf("minhastrlen: %d\n",minhaStrlen(vet));
	
	
	
	return 0;
}