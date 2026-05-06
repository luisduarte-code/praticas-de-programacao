#include <stdio.h>
int main() {
int N, contadorPrimos = 0, numero = 2, somaPrimos = 0;
printf("Digite quantos numeros primos deseja somar: ");
scanf("%d", &N);
for (; contadorPrimos < N; numero++) {
int divisores = 0;
for (int i = 1; i <= numero; i++) {
if (numero % i == 0) {
divisores++;
}
}
if (divisores == 2) {
somaPrimos += numero;
contadorPrimos++;
}
}
printf("Soma dos %d primeiros numeros primos = %d\n", N, somaPrimos);
return 0;
}