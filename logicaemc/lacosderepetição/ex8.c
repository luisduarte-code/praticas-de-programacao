#include <stdio.h>
int main(){
int n=0, maior=0;
for(int i=1;i<=5; i++){
printf("Informe o numero %d:",i);
scanf("%d",&n);
if(maior<n){
maior = n;
}
}
printf("O maior numero eh: %d",maior);
return 0;
}