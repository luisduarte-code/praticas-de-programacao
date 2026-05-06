#include <stdio.h>
int main(){
int num,count=0;
printf("Informe o numero do qual deseja contar a quantidade de divisores: ");
scanf("%d",&num);
for(int i=1; i<num;i++){
if(num % i==0 ){
count++;
}
}
printf("A quantidade de divisores eh: %d",count);
return 0;
}