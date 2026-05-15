#include <stdio.h>
int main(){
int votos, voto;
int a = 0, b = 0, c = 0;
printf("Quantas pessoas vao votar? ");
scanf("%d", &votos);
printf("1 - Candidato A\n");
printf("2 - Candidato B\n");
printf("3 - Candidato C\n");
for(int i = 1; i <= votos; i++){
printf("Pessoa %d, digite seu voto: ", i);
scanf("%d", &voto);
if(voto == 1){
a++;
}
else if(voto == 2){
b++;
}
else if(voto == 3){
c++;
}
}
printf("\nResultado:\n");
printf("Candidato A: %d\n", a);
printf("Candidato B: %d\n", b);
printf("Candidato C: %d\n", c);
return 0;
}