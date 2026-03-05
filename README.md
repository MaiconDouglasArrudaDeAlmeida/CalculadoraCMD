# 🧮 Calculadora CMD em C#

Uma calculadora interativa de linha de comando (CLI) desenvolvida em C#. Este projeto permite realizar operações matemáticas fundamentais de forma rápida, direta e contínua através do terminal,
focando na estabilidade e na experiência do usuário.

## 🚀 Funcionalidades

Através de um menu interativo, o usuário pode escolher entre as seguintes operações:
* ➕ **Soma**
* ➖ **Subtração**
* ✖️ **Multiplicação**
* ➗ **Divisão**
* ⚡ **Potenciação**
* √ **Raiz Quadrada**

## 🛡️ Confiabilidade e Tratamento de Erros

A aplicação foi projetada para não interromper a execução abruptamente por falhas de digitação. 
* **Tratamento de Exceções (`try-catch`):** Implementado para capturar entradas inválidas (como a inserção de letras ou símbolos onde números são esperados). Caso ocorra um erro de formatação (`FormatException`),
 o sistema intercepta a falha, exibe uma mensagem amigável ao usuário e retorna ao menu principal de forma limpa e segura.

## 🛠️ Tecnologias Utilizadas

* **Linguagem:** C#
* **Plataforma:** .NET / Console Application

## ⚙️ Como Executar

**Pré-requisitos:** É necessário ter o [.NET SDK](https://dotnet.microsoft.com/download) instalado na sua máquina.

1. Clone este repositório para a sua máquina:
   ```bash
   git clone https://github.com/MaiconDouglasArrudaDeAlmeida/CalculadoraCMD.git

   
