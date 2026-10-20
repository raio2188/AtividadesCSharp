# Atividades C# - SENAI

Repositório utilizado para armazenar exercícios, atividades práticas e projetos desenvolvidos durante meus estudos de **C# e .NET** no SENAI.

O conteúdo acompanha minha evolução na linguagem, desde os fundamentos de programação e aplicações em console até **Programação Orientada a Objetos (POO)** e desenvolvimento web com **ASP.NET Core MVC**.

Além das atividades propostas em aula, o repositório contém pequenos projetos pessoais utilizados para experimentar e aprofundar os conceitos estudados.

## Tecnologias utilizadas

- **C#**: linguagem principal dos projetos.
- **.NET 10**: plataforma utilizada nos projetos mais recentes.
- **ASP.NET Core MVC**: desenvolvimento de aplicações web.
- **Razor**: integração entre C# e HTML.
- **LINQ**: consulta e filtragem de coleções.
- **Bootstrap**: estilização de interfaces web.
- **HTML e CSS**: construção de páginas e interfaces.
- **Git e GitHub**: versionamento e organização dos projetos.

## Conteúdos praticados

Durante o desenvolvimento das atividades, foram estudados:

| Área | Conteúdos |
|---|---|
| Fundamentos | Variáveis, tipos de dados, operadores e conversões |
| Entrada e saída | `Console.ReadLine()`, `Console.WriteLine()` e interpolação |
| Validação | `Parse`, `TryParse` e tratamento de entradas inválidas |
| Condicionais | `if`, `else`, `switch` e operadores lógicos |
| Repetição | `while` e `foreach` |
| Métodos | Parâmetros, retornos e organização de funções |
| Coleções | `List<T>` e manipulação de objetos |
| POO | Classes, objetos, atributos, propriedades e construtores |
| POO | Encapsulamento, herança e métodos de instância |
| MVC | Models, Views, Controllers, Actions e roteamento |
| Razor | `@model`, `@foreach`, `@if` e dados dinâmicos |
| LINQ | Filtragem com `Where()` e conversão com `ToList()` |
| Web | HTML, CSS, Bootstrap e requisições HTTP |

---

## Estrutura do repositório

```text
AtividadesCSharp/
├── AtividadesClasses/
│   ├── classes/
│   ├── Exercicio01Livros/
│   ├── Exercicio02Ambientes/
│   ├── Exercicio03Alunos/
│   └── Exercicio04Contas/
│
├── ExerciciosVar/
│   ├── Exercicio01Desconto/
│   ├── Exercicio02Temperatura/
│   ├── Exercicio03Emprestimo/
│   ├── Exercicio04ProcessoSeletivo/
│   ├── Exercicio05Viagem/
│   └── Exercicio06Triagem/
│
├── FundamentosCSharp/
├── calculadoraCSharp/
├── RpgMenu/
│
├── mvc/
│   └── techStoreMVC/
│       ├── Controllers/
│       ├── Models/
│       ├── Views/
│       ├── wwwroot/
│       ├── Program.cs
│       ├── README.md
│       └── techStoreMVC.csproj
│
└── README.md
```

As pastas `bin/`, `obj/` e demais arquivos gerados automaticamente foram omitidos para facilitar a visualização.

---

## Fundamentos C#

**Diretório:** [`FundamentosCSharp/`](./FundamentosCSharp/)

Projeto utilizado durante as primeiras aulas da linguagem.

Contém exemplos de declaração de variáveis, utilização dos tipos `string`, `int`, `double` e `bool`, entrada e saída de dados, interpolação de strings, conversões e operações matemáticas.

Também introduz estruturas condicionais e validações básicas.

O projeto funciona principalmente como material de estudo e referência dos conceitos apresentados durante as aulas.

## Calculadora em C#

**Diretório:** [`calculadoraCSharp/`](./calculadoraCSharp/)

Calculadora de terminal desenvolvida para praticar métodos, validação de entradas e estruturas de controle.

O programa permite realizar quatro operações matemáticas:

- Soma
- Subtração
- Multiplicação
- Divisão

Também possui verificações para entradas numéricas inválidas, operadores inexistentes e divisão por zero.

O cálculo é realizado por meio de um método separado, que recebe os números e o operador escolhido.

## RPG Menu

**Diretório:** [`RpgMenu/`](./RpgMenu/)

Pequeno projeto pessoal desenvolvido para aplicar os conhecimentos de C# em um sistema interativo de RPG em console.

O personagem possui atributos como nome, HP, MP, ataque, defesa e ouro.

O menu oferece opções para visualizar atributos, explorar, acessar a loja, descansar e sair.

A exploração utiliza a classe `Random` para gerar acontecimentos aleatórios, incluindo encontrar ouro, cair em armadilhas ou não encontrar nada.

Também existe uma verificação de morte quando o HP chega a zero.

### Funcionalidades planejadas

- Sistema de combate
- Inimigos e criaturas
- Classes para representar personagens
- Loja funcional
- Descanso e recuperação de atributos
- Inventário
- Experiência e níveis

O projeto está em desenvolvimento e poderá incorporar novos conceitos conforme o avanço dos estudos.

---

## Exercícios de lógica e estruturas condicionais

**Diretório:** [`ExerciciosVar/`](./ExerciciosVar/)

Conjunto de seis exercícios voltados à utilização de variáveis, operadores, validações e estruturas condicionais para resolver problemas.

### Exercício 1: Cálculo de desconto

**Diretório:** [`Exercicio01Desconto/`](./ExerciciosVar/Exercicio01Desconto/)

Sistema responsável por calcular o desconto de uma compra com base no valor total e na participação do cliente em um programa de fidelidade.

Regras:

- Compras a partir de R$ 500 recebem 15% de desconto.
- Compras a partir de R$ 200 recebem 10%.
- Compras abaixo de R$ 200 recebem 5%.
- Participantes do programa de fidelidade recebem mais 5% de desconto.
- Valores negativos são considerados inválidos.

Ao final, são apresentados o valor original, o desconto aplicado e o valor final.

### Exercício 2: Classificação de temperatura

**Diretório:** [`Exercicio02Temperatura/`](./ExerciciosVar/Exercicio02Temperatura/)

Programa que recebe uma temperatura em Celsius e apresenta sua classificação.

| Temperatura | Classificação |
|---|---|
| Abaixo de 10°C | Muito frio |
| 10°C a 17°C | Frio |
| 18°C a 25°C | Agradável |
| 26°C a 32°C | Quente |
| Acima de 32°C | Muito quente |

Também apresenta alertas adicionais para temperaturas inferiores a 0°C e superiores a 40°C.

### Exercício 3: Análise de empréstimo

**Diretório:** [`Exercicio03Emprestimo/`](./ExerciciosVar/Exercicio03Emprestimo/)

Sistema simplificado para analisar solicitações de empréstimo.

A decisão considera idade, salário mensal, valor da parcela e existência de restrições financeiras.

Para aprovação, o solicitante deve possuir pelo menos 18 anos, não apresentar restrições e ter uma parcela que não ultrapasse 30% do salário.

Em caso de recusa, o programa apresenta o motivo principal.

### Exercício 4: Processo seletivo

**Diretório:** [`Exercicio04ProcessoSeletivo/`](./ExerciciosVar/Exercicio04ProcessoSeletivo/)

Sistema responsável por avaliar candidatos de acordo com critérios de um processo seletivo.

São considerados idade, experiência profissional, nota técnica, formação e disponibilidade.

O candidato pode receber uma das seguintes classificações:

- Aprovado
- Banco de talentos
- Reprovado

O exercício utiliza validações e operadores lógicos para combinar diferentes condições.

### Exercício 5: Tarifa de viagem

**Diretório:** [`Exercicio05Viagem/`](./ExerciciosVar/Exercicio05Viagem/)

Programa responsável por calcular o valor de uma viagem.

O preço base é calculado utilizando a distância percorrida:

```text
Valor base = distância × R$ 0,80
```

São aplicados acréscimos ou descontos de acordo com horário, idade e utilização de cartão de desconto.

Regras:

- Horário de pico: acréscimo de 20%.
- Cartão de desconto: redução de 10%.
- Crianças menores de 6 anos: gratuito.
- Passageiros de 6 a 17 anos: redução de 50%.
- Pessoas com 60 anos ou mais: redução de 40%.

### Exercício 6: Triagem de atendimento médico

**Diretório:** [`Exercicio06Triagem/`](./ExerciciosVar/Exercicio06Triagem/)

Sistema didático de triagem que classifica a prioridade de atendimento com base em informações fornecidas pelo paciente.

São considerados idade, temperatura, nível de dor, dificuldade respiratória e estado de consciência.

Classificações possíveis:

- Emergência
- Urgente
- Prioritário
- Atendimento comum

As condições são avaliadas da maior para a menor prioridade.

---

## Programação Orientada a Objetos (POO)

**Diretório:** [`AtividadesClasses/`](./AtividadesClasses/)

Conjunto de atividades desenvolvido para compreender a criação e utilização de classes e objetos em C#.

Os exercícios trabalham conceitos como atributos, propriedades, métodos, construtores, parâmetros, retornos e criação de instâncias.

### Introdução às classes

**Diretório:** [`classes/`](./AtividadesClasses/classes/)

Projeto inicial de Programação Orientada a Objetos, contendo exemplos com diferentes classes.

| Classe | Conceitos praticados |
|---|---|
| `Produto` | Atributos, métodos, cálculo do valor em estoque |
| `Personagem` | Métodos com parâmetros e recuperação de energia |
| `Pessoa` | Construtores e inicialização de objetos |

O projeto demonstra como criar instâncias, atribuir informações e executar métodos associados aos objetos.

### Exercício 1: Livros

**Diretório:** [`Exercicio01Livros/`](./AtividadesClasses/Exercicio01Livros/)

Implementação de uma classe `Livro` com os atributos:

- `Titulo`
- `Autor`
- `AnoPublicacao`

O método `ExibirFicha()` apresenta as informações do livro no console.

**Conceitos:** classes, objetos, atributos e métodos sem retorno.

### Exercício 2: Ambientes

**Diretório:** [`Exercicio02Ambientes/`](./AtividadesClasses/Exercicio02Ambientes/)

Implementação de uma classe `Ambiente` para representar as dimensões de um ambiente.

A classe possui nome, largura e comprimento, além dos métodos:

- `ExibirMedidas()`: apresenta as informações.
- `CalcularArea()`: retorna o produto da largura pelo comprimento.

**Conceitos:** métodos com retorno, atributos numéricos e operações matemáticas.

### Exercício 3: Alunos

**Diretório:** [`Exercicio03Alunos/`](./AtividadesClasses/Exercicio03Alunos/)

Implementação de uma classe `Aluno` responsável por armazenar informações de um estudante e suas notas.

A classe possui dois métodos principais:

- `CalcularMedia()`: calcula a média aritmética das duas notas.
- `ExibirResultado()`: apresenta os dados do aluno e informa sua situação.

O aluno é considerado aprovado quando a média é maior ou igual a 6.

**Conceitos:** métodos, retorno de valores, condicionais e reutilização de métodos dentro da própria classe.

### Exercício 4: Contas bancárias

**Diretório:** [`Exercicio04Contas/`](./AtividadesClasses/Exercicio04Contas/)

Implementação de uma classe `Conta` para representar operações bancárias simplificadas.

A classe possui titular, número e saldo.

Métodos implementados:

- `Depositar()`: adiciona um valor positivo ao saldo.
- `Sacar()`: realiza uma retirada mediante validações.
- `ExibirSaldo()`: apresenta as informações da conta.

**Conceitos:** manipulação de estado de objetos, métodos com parâmetros e validação de operações.

---

## Desenvolvimento Web com ASP.NET Core MVC

**Diretório:** [`mvc/techStoreMVC/`](./mvc/techStoreMVC/)

Projeto web desenvolvido para estudar a arquitetura **Model-View-Controller**, utilizando como exemplo uma loja de tecnologia.

Diferentemente dos exercícios anteriores, que utilizam principalmente o console, o TechStore trabalha com requisições HTTP, roteamento e geração de páginas HTML no servidor.

### Arquitetura MVC

A aplicação é dividida em três componentes principais:

| Componente | Responsabilidade |
|---|---|
| Model | Representar os dados utilizados pela aplicação |
| View | Apresentar os dados ao usuário |
| Controller | Processar requisições e encaminhar os dados para as Views |

A estrutura permite separar a lógica de apresentação da representação dos dados e do processamento das requisições.

### Funcionalidades

**Listagem de produtos**

O projeto apresenta uma tabela de produtos contendo código, nome, preço e estoque.

Os produtos são criados no Controller e enviados à View, que utiliza Razor e `foreach` para gerar as linhas da tabela.

**Listagem de categorias**

Uma segunda funcionalidade permite visualizar categorias de produtos com código, nome, descrição e situação.

As categorias podem ser classificadas como ativas ou inativas, com apresentação condicional utilizando `@if`.

**Desafios adicionais**

A atividade de Categorias também trabalha com:

- Contagem dinâmica de registros usando `Model.Count`.
- Destaque visual de categorias inativas com Bootstrap.
- Filtragem de categorias com LINQ e `Where()`.
- Segunda Action para exibir somente categorias ativas.
- Navegação por rotas MVC convencionais.

### Rotas do projeto

| Rota | Funcionalidade |
|---|---|
| `/` | Página inicial |
| `/produtos` | Listagem de produtos |
| `/categorias` | Listagem de categorias |
| `/categorias/ativas` | Listagem somente das categorias ativas |

### Documentação específica

A descrição completa da arquitetura, dos arquivos, das funcionalidades e as respostas às questões da atividade estão disponíveis no:

**[README do TechStore MVC](./mvc/techStoreMVC/README.md)**

---

## Executando os projetos

### Pré-requisitos

É necessário possuir o **.NET SDK** instalado, preferencialmente a versão 10 para executar todos os projetos mais recentes.

Verifique a instalação:

```powershell
dotnet --version
```

Clone o repositório:

```powershell
git clone https://github.com/raio2188/AtividadesCSharp.git
```

Entre na pasta:

```powershell
cd AtividadesCSharp
```

### Executar um projeto de console

Por exemplo, para executar o RPG Menu:

```powershell
dotnet run --project .\RpgMenu\FundamentosCSharp.csproj
```

Para executar o exercício de Alunos:

```powershell
dotnet run --project .\AtividadesClasses\Exercicio03Alunos\Exercicio03Alunos.csproj
```

Também é possível entrar diretamente na pasta do projeto e executar:

```powershell
dotnet run
```

### Executar a aplicação MVC

Entre na pasta da aplicação:

```powershell
cd mvc\techStoreMVC
```

Execute:

```powershell
dotnet run
```

Após a inicialização, o terminal informará o endereço local em que a aplicação está disponível.

Utilize esse endereço para acessar as páginas do TechStore.

---

## Objetivo do repositório

Este repositório serve como registro da minha evolução em **C#, .NET e desenvolvimento back-end**, reunindo atividades realizadas durante as aulas do SENAI e projetos desenvolvidos para aplicar os conteúdos na prática.

Os projetos estão organizados de forma a acompanhar a progressão dos estudos:

**Fundamentos → Lógica de programação → Métodos → Programação Orientada a Objetos → Desenvolvimento Web com MVC**

A proposta é continuar adicionando novos exercícios, funcionalidades e projetos conforme os conhecimentos forem ampliados.