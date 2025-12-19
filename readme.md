# 📘 Projetos de Fundamentos em C#

Este repositório reúne **projetos desenvolvidos para o bootcamp de C# da DIO**, com foco em lógica de programação, boas práticas iniciais e organização de código.

Os projetos são simples, porém intencionais: cada um trabalha conceitos essenciais que servem de base para aplicações maiores, como APIs, sistemas web e aplicações desktop.

> 🚧 **Observação:** este repositório será atualizado com novos projetos do bootcamp.

---

## 🗂️ Índice de Projetos

* [Projeto 01 — Sistema de Estacionamento (Console)](#-projeto-01--sistema-de-estacionamento-console)
* [Projeto 02 — Sistema de Hospedagem (Console)](#-projeto-02--sistema-de-hospedagem-console)
* [Projeto 03 — Sistema de Smartphones (POO / Console)](#-projeto-03--sistema-de-smartphones-poo--console)

---

# 🧱 ─────────────────────────────────────────────

# 📌 Projeto 01 — Sistema de Estacionamento (Console)

# 🧱 ─────────────────────────────────────────────

> 🔹 Projeto independente
> 🔹 Aplicação Console
> 🔹 Foco em lógica, coleções e validações

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

### ✅ Encerramento do Projeto 01

Este projeto consolida os fundamentos de entrada de dados, estruturas de repetição e manipulação de listas em C#.

🔝 [Voltar ao índice](#️-índice-de-projetos)

---

# 🧱 ─────────────────────────────────────────────

# 📌 Projeto 02 — Sistema de Hospedagem (Console)

# 🧱 ─────────────────────────────────────────────

> 🔹 Projeto independente
> 🔹 Aplicação Console
> 🔹 Foco em orientação a objetos e regras de negócio

### 🎯 Objetivo

Criar um sistema de **hospedagem em aplicação console**, simulando o processo de reserva de um hotel, permitindo:

* Cadastro de hóspedes
* Cadastro de suítes
* Criação de reservas
* Validação da capacidade da suíte
* Cálculo do valor total da diária com regras de desconto

O projeto reforça conceitos de **orientação a objetos**, relacionamento entre classes e regras de negócio simples, muito comuns em sistemas reais.

---

### 🧠 Conceitos aplicados

* Classes, propriedades e construtores
* Encapsulamento e responsabilidade de classes
* Relacionamento entre objetos (Pessoa ↔ Reserva ↔ Suíte)
* Listas (`List<T>`)
* Expressões de propriedade (`=>`)
* Regras de negócio com validações
* Lançamento de exceções (`InvalidOperationException`)
* Cálculo de valores com `decimal`

---

### 🧩 Funcionalidades

#### 👤 Cadastro de hóspedes

* Criação de hóspedes através da classe `Pessoa`
* Suporte a nome e sobrenome
* Exibição do nome completo em letras maiúsculas

#### 🏨 Cadastro de suíte

* Definição do tipo da suíte
* Capacidade máxima de hóspedes
* Valor da diária

#### 📅 Criação de reserva

* Associação de hóspedes a uma reserva
* Associação de uma suíte à reserva
* Definição da quantidade de dias reservados

#### ✅ Validação de capacidade

* Impede reservas onde o número de hóspedes ultrapassa a capacidade da suíte
* Lança uma exceção em caso de regra violada

#### 💰 Cálculo do valor da diária

O valor total da reserva é calculado da seguinte forma:

```
valor total = dias reservados × valor da diária
```

**Regra de desconto:**

* Reservas com **10 dias ou mais** recebem **10% de desconto** sobre o valor total

---

### 🛠️ Tecnologias utilizadas

* C#
* .NET (Console Application)

---

### 📁 Estrutura do projeto

```
DesafioProjetoHospedagem
│
├── Program.cs
└── Models
    ├── Pessoa.cs
    ├── Suite.cs
    └── Reserva.cs
```

* **Program.cs**: responsável pela execução do fluxo principal e exibição das informações no console
* **Pessoa.cs**: representa os hóspedes
* **Suite.cs**: representa a suíte do hotel
* **Reserva.cs**: contém as regras de negócio da reserva

---

### ▶️ Como executar

1. Clone o repositório
2. Abra o projeto em uma IDE compatível (Visual Studio ou VS Code)
3. Execute o projeto como aplicação console
4. Observe no terminal a quantidade de hóspedes e o valor calculado da diária

---

### ✅ Encerramento do Projeto 02

Este projeto consolida os fundamentos de orientação a objetos, validações e aplicação de regras de negócio em C#.

🔝 [Voltar ao índice](#️-índice-de-projetos)

---

# 🧱 ─────────────────────────────────────────────

# 📌 Projeto 03 — Sistema de Smartphones (POO / Console)

# 🧱 ─────────────────────────────────────────────

> 🔹 Projeto independente
> 🔹 Aplicação Console
> 🔹 Foco em herança, abstração e polimorfismo

### 🎯 Objetivo

Criar um sistema simples em **aplicação console** para simular o funcionamento de smartphones, utilizando **Programação Orientada a Objetos**, com foco em:

* Herança entre classes
* Classes abstratas
* Sobrescrita de métodos
* Polimorfismo em tempo de execução

O projeto utiliza uma classe base abstrata (`Smartphone`) e classes concretas (`Nokia` e `Iphone`) para demonstrar comportamentos específicos de cada modelo.

---

### 🧠 Conceitos aplicados

* Programação Orientada a Objetos (POO)
* Classe abstrata (`abstract`)
* Herança (`:`)
* Métodos abstratos
* Sobrescrita de métodos (`override`)
* Polimorfismo
* Encapsulamento (`private set`)

---

### 🧩 Funcionalidades

#### 📱 Classe base Smartphone

* Armazena informações comuns a todos os smartphones:

  * Número
  * Modelo
  * IMEI
  * Memória
* Possui métodos comuns:

  * `Ligar()`
  * `ReceberLigacao()`
* Define o método abstrato:

  * `InstalarAplicativo(string nomeApp)`

#### 📲 Classes derivadas (Nokia e Iphone)

* Herdam da classe `Smartphone`
* Implementam o método `InstalarAplicativo` de forma específica para cada marca

Exemplo de comportamento:

```
Instalando o aplicativo WhatsApp no Nokia...
Instalando o aplicativo WhatsApp no Iphone...
```

---

### 🛠️ Tecnologias utilizadas

* C#
* .NET (Console Application)

---

### 📁 Estrutura do projeto

```
DesafioPOO
│
├── Program.cs
└── Models
    ├── Smartphone.cs
    ├── Nokia.cs
    └── Iphone.cs
```

* **Program.cs**: responsável por instanciar os objetos e testar os comportamentos
* **Smartphone.cs**: classe abstrata base com atributos e métodos comuns
* **Nokia.cs** e **Iphone.cs**: implementações concretas do smartphone

---

### ▶️ Como executar

1. Clone o repositório
2. Abra o projeto em uma IDE compatível (Visual Studio ou VS Code)
3. Execute o projeto como aplicação console
4. Observe no terminal os testes de ligação e instalação de aplicativos

---

### ✅ Encerramento do Projeto 03

Este projeto consolida os fundamentos de **herança, abstração e polimorfismo** em C#, servindo como base para arquiteturas mais complexas e extensíveis no futuro.

🔝 [Voltar ao índice](#️-índice-de-projetos)
