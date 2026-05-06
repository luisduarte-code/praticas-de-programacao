#include <stdio.h>
int main(){
char a = '*';
int n;
printf("Qual eh o tamanho da base de sua piramide? ");
scanf("%d", &n);
for(int i = 1; i <= n; i++){
for(int j = 1; j <= i; j++){
printf("%c", a);
}
printf("\n");
}
return 0;
}