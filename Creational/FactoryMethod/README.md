# Factory Method 🏭

Referência: [Refactoring Guru](https://refactoring.guru/pt-br/design-patterns/factory-method)

Também conhecido como Virtual Constructor.

## Propósito 🧐

Define uma interface para criar um objeto, mas deixa as subclasses decidirem que classe instanciar.

## Motivação 🫶

Imagine que temos uma aplicação de gerenciamento logístico em que lidamos apenas com transporte de caminhões, e a
maioria do seu código fica dentro da classe Truck. Se quisermos adicionar um novo tipo de transporte, como navios, 
isso exigiria uma grande mudança no código.

## Solução 🤩

O padrão **Factory Method** sugere que você substitua chamadas diretas de construção de objetos (usando o operador new) por chamadas para um método fábrica especial. 
Os objetos ainda são criados através do operador new, mas esse está sendo chamado de dentro do método fábrica. 
Objetos retornados por um método fábrica são geralmente chamados de produtos.