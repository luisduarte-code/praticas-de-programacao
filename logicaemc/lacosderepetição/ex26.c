#include <stdio.h>
#include <stdbool.h>

// Exemplo médio com while: listar todos os números primos até N
int main() {
    int N;
    printf("Digite um numero inteiro maior ou igual a 2: ");
    scanf("%d", &N);

    if (N < 2) {
        printf("Nenhum primo encontrado.\n");
        return 0;
    }

    printf("Primos até %d:\n", N);
    int numero = 2;

    while (numero <= N) {
        bool primo = true;
        int i = 2;
        while (i * i <= numero) {
            if (numero % i == 0) {
                primo = false;
                break;
            }
            i++;
        }
        if (primo) {
            printf("%d ", numero);
        }
        numero++;
    }

    printf("\n");
    return 0;
}
