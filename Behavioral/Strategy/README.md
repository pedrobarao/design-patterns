# Strategy 🗺️

Referência: [Refactoring Guru](https://refactoring.guru/pt-br/design-patterns/strategy)

![structure.png](structure.png)

## Propósito 🧐

O Strategy é um padrão de projeto comportamental que permite que você defina uma família de algoritmos, coloque-os em
classes separadas, e faça os objetos deles intercambiáveis.

## Motivação 🫶

Imagine que temos uma aplicação que planeja rotas de viagem. O primeiro passo é escolher o meio de transporte: carro,
bicicleta, transporte público ou a pé. Dependendo da escolha, a aplicação deve fornecer uma lista de rotas apropriadas.
Se focarmos na implementação de um desses comportamentos podemos ter um código acoplado e difícil de manter conforme
novos comportamentos são adicionados.
O **Strategy** permite que tenha uma classe com comportamento específico em diversas maneiras diferentes e extraia esse
comportamento em classes separadas. Essas classes separadas são chamadas de **Strategies**.

## Solução 🤩

O padrão **Strategy** sugere que você tome uma classe que faz algo específico de muitas maneiras e extraia todos esses
algoritmos em classes separadas chamadas **Strategies**.
A classe original, também conhecida como Context, deve ter um campo para fazer referência a uma das estratégias. O
Context delega todo o trabalho para as estratégias ao invés de fazer tudo sozinho.
O contexto não deve ser o responsável por criar uma instância das estratégias, isso deve ser feito por um cliente que
passa a estratégia desejada para o contexto.