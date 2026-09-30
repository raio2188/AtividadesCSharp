# Atividades C# - SENAI

Repositório utilizado para armazenar exercícios, testes e pequenos projetos desenvolvidos durante meus estudos de **C# e .NET** no SENAI.

O conteúdo acompanha minha evolução na linguagem, começando pelos fundamentos de programação e avançando gradualmente para métodos, estruturas de repetição, validação de dados e pequenos sistemas em console.

## Conteúdos praticados

Até o momento, o repositório trabalha com:

- Variáveis e tipos de dados
- Entrada e saída com `Console`
- Conversões de dados
- `Parse` e `TryParse`
- Operadores aritméticos
- Operadores relacionais
- Operadores lógicos
- Estruturas condicionais
- `switch`
- Estruturas de repetição
- `while`
- Métodos
- Parâmetros
- Validação de entrada
- `Random`
- Organização de lógica em funções
- Pequenos sistemas em Console

---

## Estrutura do repositório

```text
AtividadesCSharp/
├── FundamentosCSharp/
├── calculadoraCSharp/
├── RpgMenu/
├── Exercicio01Desconto/
├── Exercicio02Temperatura/
├── Exercicio03Emprestimo/
├── Exercicio04ProcessoSeletivo/
├── Exercicio05Viagem/
├── Exercicio06Triagem/
└── README.md
```

---

## Fundamentos C#

Projeto utilizado durante as primeiras aulas da linguagem.

Contém exemplos de:

- Declaração de variáveis
- `string`, `int`, `double` e `bool`
- Interpolação de strings
- Entrada com `Console.ReadLine()`
- Conversões utilizando `TryParse`
- Operadores aritméticos
- Operadores relacionais
- Operadores lógicos
- Estruturas `if` e `else`

Esse projeto funciona principalmente como um arquivo de estudo e referência dos conceitos básicos apresentados durante as aulas.

---

## Calculadora em C#

Calculadora de terminal criada para praticar métodos, validações e estruturas de controle.

O programa permite realizar:

- Soma
- Subtração
- Multiplicação
- Divisão

Também possui tratamento para:

- Entrada inválida de números
- Operadores inválidos
- Divisão por zero

O cálculo é realizado através de um método separado que recebe os dois números e o operador escolhido.

---

## RPG Menu

Pequeno projeto pessoal em desenvolvimento para praticar os conceitos aprendidos em C# de uma forma mais interativa.

Atualmente o personagem possui:

- Nome
- HP
- MP
- Ataque
- Defesa
- Ouro

O jogo possui um menu principal com opções para:

- Visualizar os atributos do personagem
- Explorar
- Acessar a loja
- Descansar
- Sair

A exploração utiliza `Random` para gerar eventos aleatórios.

Eventos implementados atualmente:

- Encontrar ouro
- Cair em uma armadilha e perder HP
- Não encontrar nada

Também existe verificação de morte quando o HP chega a zero.

### Planejado

O projeto ainda está em desenvolvimento. Algumas ideias para as próximas versões incluem:

- Sistema de combate
- Criaturas e inimigos
- Classes e objetos para representar criaturas
- Loja funcional
- Sistema de descanso
- Inventário
- Experiência e níveis

---

# Exercícios

## Exercício 1 - Cálculo de desconto

Sistema responsável por calcular o desconto de uma compra.

O programa recebe:

- Nome do cliente
- Valor total da compra
- Participação no programa de fidelidade

### Regras

- Compras a partir de R$ 500 recebem 15% de desconto.
- Compras a partir de R$ 200 recebem 10% de desconto.
- Compras abaixo de R$ 200 recebem 5% de desconto.
- Clientes participantes do programa de fidelidade recebem mais 5% de desconto.
- Valores negativos são considerados inválidos.

Ao final são exibidos o valor original, o desconto aplicado e o valor final da compra.

---

## Exercício 2 - Classificação de temperatura

Programa que recebe uma temperatura em graus Celsius e informa sua classificação.

### Classificações

- Abaixo de 10°C: Muito frio
- De 10°C até 17°C: Frio
- De 18°C até 25°C: Agradável
- De 26°C até 32°C: Quente
- Acima de 32°C: Muito quente

Também existem alertas adicionais para:

- Temperaturas abaixo de 0°C
- Temperaturas acima de 40°C

---

## Exercício 3 - Análise de empréstimo

Sistema simplificado para analisar a aprovação de um empréstimo.

São considerados:

- Nome
- Idade
- Salário mensal
- Valor da parcela
- Existência de restrição financeira

O empréstimo é aprovado somente quando:

- O solicitante possui 18 anos ou mais
- Não possui restrição financeira
- A parcela não ultrapassa 30% do salário

Caso seja recusado, o programa informa o principal motivo.

---

## Exercício 4 - Processo seletivo

Sistema responsável por analisar candidatos para uma vaga.

São considerados:

- Nome
- Idade
- Experiência profissional
- Nota da prova técnica
- Curso técnico
- Disponibilidade de horário

O candidato pode receber uma das classificações:

- Aprovado
- Banco de talentos
- Reprovado

O exercício também trabalha com validação de dados e condições combinadas.

---

## Exercício 5 - Tarifa de viagem

Programa que calcula o preço final de uma viagem.

O valor base é calculado através da distância:

```text
Valor base = distância × R$ 0,80
```

Depois podem ser aplicados acréscimos ou descontos de acordo com:

- Horário de pico
- Idade do passageiro
- Cartão de desconto

### Regras

- Horário de pico: +20%
- Cartão de desconto: -10%
- Crianças menores de 6 anos: gratuito
- Passageiros entre 6 e 17 anos: -50%
- Pessoas com 60 anos ou mais: -40%

---

## Exercício 6 - Triagem de atendimento médico

Sistema simplificado de triagem que classifica a prioridade de atendimento de um paciente.

O programa recebe:

- Nome
- Idade
- Temperatura
- Nível de dor
- Dificuldade para respirar
- Estado de consciência

As classificações possíveis são:

- Emergência
- Urgente
- Prioritário
- Atendimento comum

As condições são analisadas da maior para a menor prioridade.

---

## Executando os projetos

É necessário possuir o **.NET SDK** instalado.

Entre na pasta do projeto desejado:

```powershell
cd RpgMenu
```

E execute:

```powershell
dotnet run
```

Também é possível executar diretamente um projeto específico:

```powershell
dotnet run --project .\RpgMenu\FundamentosCSharp.csproj
```

---

## Objetivo

Este repositório serve como registro da minha evolução em **C# e desenvolvimento back-end**, reunindo exercícios das aulas e pequenos projetos desenvolvidos para aplicar os conteúdos na prática.

Novos projetos e conceitos serão adicionados conforme o avanço dos estudos.