#include <stdio.h>

// Exemplo com do-while: ler números até que o usuário digite 0
int main() {
    int valor;
    int soma = 0;

    do {
        printf("Digite um número (0 para sair): ");
        scanf("%d", &valor);
        soma += valor;
    } while (valor != 0);

    printf("A soma dos valores digitados é %d\n", soma);
    return 0;
}
