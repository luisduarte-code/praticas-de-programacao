#include <stdio.h>
int main(){
float n,ns, i=0, m, s=0;
printf("Informe a quantidade de numeros que vc deseja faze a media: ");
scanf("%f",&n);
for(i=0; i<n; i++){
printf("Informe os numeros:",i);
scanf("%f",&ns);
s=s+ns;
}
m=s/n;
printf("A media eh= %.2f",m);
return 0;
}