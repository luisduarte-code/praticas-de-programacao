#include <stdio.h>

// Exemplo com while: somar os números pares de 0 a N
int main() {
    int N;
    int soma = 0;
    int i = 0;

    printf("Digite um número inteiro positivo: ");
    scanf("%d", &N);

    while (i <= N) {
        if (i % 2 == 0) {
            soma += i;
        }
        i++;
    }

    printf("A soma dos pares de 0 a %d é %d\n", N, soma);
    return 0;
}
