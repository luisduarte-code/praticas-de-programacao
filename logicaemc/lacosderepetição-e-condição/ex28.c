#include <stdio.h>

// Exemplo difícil com do-while: menu de operações até o usuário escolher sair
int main() {
    int opcao;
    int soma = 0;
    int contador = 0;

    do {
        printf("\n=== Menu de operacoes ===\n");
        printf("1 - Adicionar numero\n");
        printf("2 - Mostrar soma atual\n");
        printf("3 - Mostrar media atual\n");
        printf("0 - Sair\n");
        printf("Escolha uma opcao: ");
        scanf("%d", &opcao);

        if (opcao == 1) {
            int valor;
            printf("Digite um numero: ");
            scanf("%d", &valor);
            soma += valor;
            contador++;
        } else if (opcao == 2) {
            printf("Soma atual: %d\n", soma);
        } else if (opcao == 3) {
            if (contador == 0) {
                printf("Nenhum numero foi digitado ainda.\n");
            } else {
                double media = (double)soma / contador;
                printf("Media atual: %.2f\n", media);
            }
        } else if (opcao != 0) {
            printf("Opcao invalida. Tente novamente.\n");
        }
    } while (opcao != 0);

    printf("Programa encerrado.\n");
    return 0;
}
