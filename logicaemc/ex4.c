#include <stdio.h>
int main(){
//fazer a tabuada
int i=0,n=0,tab=0;
printf("informe um numero no console: ");
scanf("%d",&n);
for (i=0; i<=10;i++){
	tab = i*n;
	printf("%d\n",tab);
}
return 0;
}