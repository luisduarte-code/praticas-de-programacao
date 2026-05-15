#include <stdio.h>

// Exemplo médio/difícil com while: contar quantos dígitos pares existem em um número
int main() {
    long numero;
    int pares = 0;

    printf("Digite um numero inteiro positivo: ");
    scanf("%ld", &numero);

    if (numero < 0) {
        numero = -numero;
    }

    while (numero > 0) {
        int digito = numero % 10;
        if (digito % 2 == 0) {
            pares++;
        }
        numero /= 10;
    }

    printf("Quantidade de digitos pares: %d\n", pares);
    return 0;
}
