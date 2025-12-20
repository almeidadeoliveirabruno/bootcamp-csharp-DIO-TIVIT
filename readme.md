# 📘 Projetos de Fundamentos em C#

Este repositório reúne **projetos desenvolvidos para o bootcamp de C# da DIO**, com foco em lógica de programação, boas práticas iniciais e organização de código.

Os projetos são simples, porém intencionais: cada um trabalha conceitos essenciais que servem de base para aplicações maiores, como APIs, sistemas web e aplicações desktop.

> 🚧 **Observação:** este repositório será atualizado com novos projetos do bootcamp.

---

## 🗂️ Índice de Projetos

* [Projeto 01 — Sistema de Estacionamento (Console)](#projeto-01--sistema-de-estacionamento-console)
* [Projeto 02 — Sistema de Hospedagem (Console)](#projeto-02--sistema-de-hospedagem-console)
* [Projeto 03 — Sistema de Smartphones (POO / Console)](#projeto-03--sistema-de-smartphones-poo--console)
* [Projeto 04 — Consultas SQL com Banco de Dados de Filmes](#projeto-04--consultas-sql-com-banco-de-dados-de-filmes)

---

## Projeto 01 — Sistema de Estacionamento (Console)

**Tipo:** Aplicação Console
**Foco:** Lógica, coleções e validações

### 🎯 Objetivo

Criar um sistema de estacionamento em **aplicação console**, permitindo cadastro, remoção e listagem de veículos, além do cálculo do valor a pagar com base no tempo estacionado.

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

* **Cadastrar veículo:** valida o formato da placa e armazena na lista
* **Remover veículo:** calcula o valor com base no tempo estacionado
* **Listar veículos:** exibe todos os veículos cadastrados

---

### 📁 Estrutura do projeto

```
DesafioFundamentos
├── Program.cs
└── Models
    └── Estacionamento.cs
```

---

### ▶️ Execução

1. Clone o repositório
2. Abra o projeto em uma IDE compatível
3. Execute como aplicação console

---

🔝 [Voltar ao índice](#️-índice-de-projetos)

---

## Projeto 02 — Sistema de Hospedagem (Console)

**Tipo:** Aplicação Console
**Foco:** Orientação a objetos e regras de negócio

### 🎯 Objetivo

Simular o processo de reserva de um hotel, permitindo cadastro de hóspedes, suítes e reservas, com validações de capacidade e cálculo de valores.

---

### 🧠 Conceitos aplicados

* Classes, propriedades e construtores
* Relacionamento entre objetos
* Listas (`List<T>`)
* Regras de negócio com validações
* Lançamento de exceções
* Cálculo de valores com `decimal`

---

### 🧩 Funcionalidades

* Cadastro de hóspedes
* Cadastro de suítes
* Criação de reservas
* Validação da capacidade da suíte
* Cálculo de diária com desconto

---

### 📁 Estrutura do projeto

```
DesafioProjetoHospedagem
├── Program.cs
└── Models
    ├── Pessoa.cs
    ├── Suite.cs
    └── Reserva.cs
```

---

### ▶️ Execução

1. Clone o repositório
2. Abra o projeto em uma IDE compatível
3. Execute como aplicação console

---

🔝 [Voltar ao índice](#️-índice-de-projetos)

---

## Projeto 03 — Sistema de Smartphones (POO / Console)

**Tipo:** Aplicação Console
**Foco:** Herança, abstração e polimorfismo

### 🎯 Objetivo

Demonstrar conceitos de **Programação Orientada a Objetos** por meio de um sistema simples que simula o comportamento de smartphones.

---

### 🧠 Conceitos aplicados

* Classe abstrata
* Herança
* Métodos abstratos
* Sobrescrita de métodos
* Polimorfismo
* Encapsulamento

---

### 🧩 Funcionalidades

* Classe base `Smartphone` com métodos comuns
* Classes `Nokia` e `Iphone` com comportamentos específicos
* Simulação de ligações e instalação de aplicativos

---

### 📁 Estrutura do projeto

```
DesafioPOO
├── Program.cs
└── Models
    ├── Smartphone.cs
    ├── Nokia.cs
    └── Iphone.cs
```

---

### ▶️ Execução

1. Clone o repositório
2. Abra o projeto em uma IDE compatível
3. Execute como aplicação console

---

🔝 [Voltar ao índice](#️-índice-de-projetos)

---

## Projeto 04 — Consultas SQL com Banco de Dados de Filmes

**Tipo:** Banco de Dados Relacional
**Foco:** Consultas SQL e relacionamentos entre tabelas

### 🎯 Objetivo

Aplicar consultas SQL sobre um banco de dados relacional de filmes, explorando filtros, ordenações, agregações e **JOINs**.

---

### 🧠 Conceitos aplicados

* `SELECT`, `WHERE`, `ORDER BY`
* `GROUP BY` e funções de agregação
* Relacionamentos entre tabelas
* `INNER JOIN`

---

### 🗄️ Estrutura do banco

* Filmes
* Atores
* Gêneros
* FilmesGenero
* ElencoFilme

---

### 🧩 Consultas realizadas

* Filmes por ano e duração
* Filmes lançados após determinado ano
* Contagem de filmes por ano
* Atores por gênero
* Filmes com seus gêneros
* Filmes com atores e papéis

---

### ▶️ Execução

1. Execute o script de criação do banco de dados
2. Crie as tabelas
3. Execute as consultas SQL

---

🔝 [Voltar ao índice](#️-índice-de-projetos)
