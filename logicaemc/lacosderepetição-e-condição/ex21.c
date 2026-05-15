#include <stdio.h>
int main() {
int N, contadorPerfeitos = 0, numero = 2, somaPerfeitos = 0;
printf("Digite quantos numeros perfeitos deseja encontrar: ");
scanf("%d", &N);
printf("Numeros perfeitos encontrados: ");
for (; contadorPerfeitos < N; numero++) {
int somaDivisores = 0;
for (int i = 1; i < numero; i++) {
if (numero % i == 0) {
somaDivisores += i;
}
}
if (somaDivisores == numero) {
printf("%d ", numero);
somaPerfeitos += numero;
contadorPerfeitos++;
}
}
printf("\nSoma = %d\n", somaPerfeitos);
return 0;
}