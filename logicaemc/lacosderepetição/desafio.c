#include <stdio.h>
int main() {
int N;
int contador = 0;
int somaTotal = 0;
printf("Digite quantos numeros perfeitos deseja: ");
scanf("%d", &N);
printf("Numeros perfeitos encontrados: ");
for (int numero = 1; contador < N; numero++) {
int somaDivisores = 0;
for (int i = 1; i < numero; i++) {
if (numero % i == 0) {
somaDivisores += i;
}
}
if (somaDivisores == numero && numero != 0) {
printf("%d ", numero);
somaTotal += numero;
contador++;
}
}
printf("\nSoma = %d\n", somaTotal);
return 0;
}