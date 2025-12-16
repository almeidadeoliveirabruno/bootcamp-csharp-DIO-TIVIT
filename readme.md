# 📘 Projetos de Fundamentos em C#

Este repositório reúne **projetos desenvolvidos para o bootcamp de C# da DIO**, com foco em lógica de programação, boas práticas iniciais e organização de código.

Os projetos são simples, porém intencionais: cada um trabalha conceitos essenciais que servem de base para aplicações maiores, como APIs, sistemas web e aplicações desktop.

> 🚧 **Observação:** este repositório será atualizado com novos projetos do bootcamp.

---

## 📌 Projeto 01 — Sistema de Estacionamento (Console)

### 🎯 Objetivo

Criar um sistema de estacionamento em **aplicação console**, permitindo:

* Cadastro de veículos
* Remoção de veículos
* Cálculo do valor a pagar com base no tempo estacionado
* Listagem dos veículos estacionados

O projeto trabalha validações de entrada, estruturas de repetição, coleções e organização em classes.

---

### 🧠 Conceitos aplicados

* Estrutura de classes e métodos
* Encapsulamento
* Listas (`List<string>`)
* Validação de dados com `Regex`
* Conversão segura de tipos (`TryParse`)
* Laços (`while`, `do/while`)
* Menu interativo no console

---

### 🧩 Funcionalidades

#### ➕ Cadastrar veículo

* Solicita a placa do veículo
* Valida o formato da placa (`AAA-0000`)
* Armazena a placa na lista de veículos

#### ➖ Remover veículo

* Solicita a placa
* Verifica se o veículo está estacionado
* Solicita a quantidade de horas
* Calcula o valor total:

```
preço total = preço inicial + (preço por hora × horas)
```

#### 📋 Listar veículos

* Exibe todos os veículos atualmente estacionados

---

### 🛠️ Tecnologias utilizadas

* C#
* .NET (Console Application)
* Namespace `System.Text.RegularExpressions`

---

### 📁 Estrutura do projeto

```
DesafioFundamentos
│
├── Program.cs
└── Models
    └── Estacionamento.cs
```

* **Program.cs**: responsável pelo menu e interação com o usuário
* **Estacionamento.cs**: contém as regras de negócio do estacionamento

---

### ▶️ Como executar

1. Clone o repositório
2. Abra o projeto em uma IDE compatível (Visual Studio ou VS Code)
3. Execute o projeto como aplicação console
4. Siga as instruções exibidas no terminal

---

## 📌 Observações finais

Este projeto faz parte do processo de aprendizado e consolidação dos fundamentos da linguagem C#. Melhorias e refatorações poderão ser aplicadas ao longo do tempo conforme a evolução dos estudos.

