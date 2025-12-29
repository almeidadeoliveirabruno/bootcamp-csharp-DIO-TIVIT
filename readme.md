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
* [Projeto 05 — API de Tarefas (Web API)](#projeto-05--api-de-tarefas-web-api)
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
<br> <br>

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
<br> <br>

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
<br> <br>

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

---
<br> <br>

## Projeto 05 — API de Tarefas (Web API)

**Tipo:** Web API (ASP.NET Core)
**Foco:** APIs REST, Entity Framework Core e persistência de dados

### 🎯 Objetivo

Criar uma API para gerenciar tarefas (ToDo), permitindo operações de CRUD e consultas por título, data e status, com documentação via Swagger.

---

### ⚙️ Contexto

Uma aplicação simples de gerenciador de tarefas serve como base para aprender padrões de desenvolvimento de APIs, lidar com persistência usando EF Core, aplicar migrations e expor endpoints REST seguindo boas práticas.

---

### 📌 Proposta

Implementar o modelo `Tarefa` com propriedades como `Id`, `Titulo`, `Descricao`, `Data` e `Status`. Expor endpoints para criar, atualizar, remover e consultar tarefas individualmente ou por filtros (titulo, data, status). Integrar com o `OrganizadorContext` do EF Core e disponibilizar documentação automática com Swagger.

---

### 🔎 Métodos esperados / Endpoints

Seguindo o padrão do desafio, implemente os endpoints (exemplos):

* `GET /Tarefa/{id}` — obter por id
* `PUT /Tarefa/{id}` — atualizar
* `DELETE /Tarefa/{id}` — deletar
* `GET /Tarefa/ObterTodos` — listar todas
* `GET /Tarefa/ObterPorTitulo?titulo=` — buscar por título
* `GET /Tarefa/ObterPorData?data=` — buscar por data
* `GET /Tarefa/ObterPorStatus?status=` — buscar por status
* `POST /Tarefa` — criar nova tarefa

É recomendado expor o Swagger UI para testar os endpoints durante o desenvolvimento.

---

### 🧩 Funcionalidades e validações

* Validação básica de entrada (título não vazio, data válida)
* Tratamento de erros com respostas HTTP adequadas (404, 400, 500)
* Uso de migrations para versionamento do esquema do banco
* Serialização JSON e mapeamento de DTOs quando necessário

---

### 📁 Estrutura do projeto (resumo)

```
TrilhaApiDesafio
├── Program.cs
├── Controllers
│   └── TarefaController.cs
├── Context
│   └── OrganizadorContext.cs
├── Models
│   ├── Tarefa.cs
│   └── EnumStatusTarefa.cs
└── Migrations
```

---

### ▶️ Execução

1. Abra a solução em uma IDE compatível (Visual Studio, VS Code).
2. Ajuste a `connection string` em `appsettings.json` se necessário.
3. Atualize o banco com as migrations:

```powershell
dotnet ef database update
```

4. Execute a aplicação (`dotnet run` ou via IDE) e acesse `/swagger` para testar os endpoints.

---

🔝 [Voltar ao índice](#️-índice-de-projetos)

````
