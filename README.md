# Jogo Da Forca - Console
![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white)

Este é um projeto para o final do módulo 1 (Lógica de Programação) do curso Back-end C# da AdaTech em parceria com a empresa Mercado Eletrônico. **Esse projeto foi feito completamente em C# focando em se limitar aos conceitos abordados no módulo**.

## Table of Contents

- [Uso](#uso)
- [Conceitos do módulo que foram aplicados](#conceitos-do-módulo-que-foram-aplicados)
- [Sobre o jogo](#sobre-o-jogo)
- [Lógica do projeto explicada](#lógica-do-projeto-explicada)
- [Project in development](#project-still-in-development)



## Uso

1. Dê git clone do repositório na sua máquina


## Conceitos do módulo que foram aplicados

1. Estrutura de projetos
2. ClassLibrary
3. Estruturas de repetição e condição
4. List, vetores, matrizes
5. Princípio de responsabilidade única
6. Modificiadores de acesso e classes static -> aplicando princípio do privilégio mínimo
7. Tratamento de erros possíveis do usuário

## Sobre o jogo

Existem 5 temas: geografia, empresas, histórias, entretenimento e Taylor Swift. 
A cada jogada, é solicitado que o usuário escolha um tema. Após escolher, uma palavra que não tenha sido escolhida ainda é sorteada para ser a nova palavra.
O usuário tem 6 chances de erro, tem a possibilidade de saber quais letras ele já tentou e tem à disposição uma dica.

## Lógica do projeto explicada

A classe mais básica é a **Palavras** da ClassLibrary que coordena o banco de palavras. A classe _static_ contém 5 matrizes de string (string[,]), cada uma contendo uma série de, respectivamente, dicas e palavras de cada tema. A classe contém 5 métodos públicos, um para cada tema, que retornam uma palavra orteada e sua respectiva dica. A classe, porém, é _internal_.

Na mesma ClassLibrary contém a classe também _static_ **FuncionalidadesJogoDaForca** que coordena um jogo. Possui um único método público chamdado Jogo(), que inicia e termina um jogo. Esse método faz chamadas aos métodos internos privados, como ShowHangingMan(), SetWord(), TryToAddLetter() e ShowPastLetters(). Os métodos internos privados utilizam dos métodos públicos da classe _Palavras_.

A ClassLibrary JogoDaForcaLib é referenciada como dependência do projeto JogoDaForca.

E, por fim, no projeto JogoDaForca, a class **Program** inicializa toda a aplicação e coordenada o loop de jogadas, fazendo chamada unicamente ao método Jogo() da classe FuncionalidadesJogoDaForca.



