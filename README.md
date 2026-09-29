# Atividade C# Console - SENAI

Este repositório contém seis exercícios desenvolvidos em **C# Console** para prática dos fundamentos da linguagem.

A atividade utiliza somente os conteúdos estudados até o tópico 13, com foco em entrada de dados, conversões, operadores e estruturas condicionais.

## Conteúdos utilizados

- Variáveis
- Tipos de dados
- `Console.ReadLine()`
- Conversões de dados
- Operadores aritméticos
- Operadores relacionais
- Operadores lógicos
- `if`
- `else if`
- `else`
- Condições combinadas
- Condições aninhadas

## Estrutura do projeto

```text
AtividadesFundamentos/
├── Exercicio01Desconto/
├── Exercicio02Temperatura/
├── Exercicio03Emprestimo/
├── Exercicio04ProcessoSeletivo/
├── Exercicio05Viagem/
└── Exercicio06Triagem/
```

---

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

O programa exibe o valor original da compra, o desconto aplicado e o valor final.

---

## Exercício 2 - Classificação de temperatura

Programa que recebe uma temperatura em graus Celsius e informa sua classificação.

### Classificações

- Abaixo de 10°C: Muito frio
- De 10°C até 17°C: Frio
- De 18°C até 25°C: Agradável
- De 26°C até 32°C: Quente
- Acima de 32°C: Muito quente

### Alertas

Além da classificação normal:

- Temperaturas abaixo de 0°C indicam risco de congelamento.
- Temperaturas acima de 40°C geram alerta de calor extremo.

A classificação e os alertas são tratados separadamente.

---

## Exercício 3 - Análise de empréstimo

Sistema simplificado para analisar a aprovação de um empréstimo.

O programa recebe:

- Nome do solicitante
- Idade
- Salário mensal
- Valor da parcela
- Existência de restrição financeira

### Regras para aprovação

O empréstimo será aprovado somente quando:

- O solicitante possuir 18 anos ou mais.
- Não possuir restrição financeira.
- A parcela não ultrapassar 30% do salário.

Caso seja recusado, o programa informa o principal motivo da recusa.

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

### Possíveis resultados

O candidato pode ser classificado como:

- Aprovado
- Banco de talentos
- Reprovado

Para a aprovação são avaliados idade, nota, disponibilidade e experiência ou formação técnica.

O programa também valida dados como nota, idade e tempo de experiência.

---

## Exercício 5 - Tarifa de viagem

Programa que calcula o preço final de uma viagem com base nas características do passageiro e da viagem.

### Valor base

```text
Valor base = distância × R$ 0,80
```

### Regras

- Horário de pico acrescenta 20%.
- Cartão de desconto reduz 10%.
- Crianças menores de 6 anos não pagam.
- Passageiros entre 6 e 17 anos recebem 50% de desconto.
- Pessoas com 60 anos ou mais recebem 40% de desconto.

Os cálculos são realizados seguindo a ordem definida pela atividade:

1. Valor base.
2. Acréscimo do horário de pico.
3. Desconto por idade.
4. Desconto do cartão.

---

## Exercício 6 - Triagem de atendimento médico

Sistema simplificado de triagem que classifica o nível de prioridade de atendimento de um paciente.

O programa recebe:

- Nome
- Idade
- Temperatura
- Nível de dor
- Dificuldade para respirar
- Estado de consciência

### Classificações possíveis

- Emergência
- Urgente
- Prioritário
- Atendimento comum

As condições são verificadas da maior para a menor gravidade, garantindo que situações mais críticas tenham prioridade.

Também são realizadas validações de idade, nível de dor e temperatura antes da classificação.

---

## Objetivo

O objetivo da atividade é desenvolver a lógica de programação utilizando os fundamentos de C#, trabalhando principalmente com:

- Validação de dados
- Tomada de decisões
- Condições compostas
- Operadores lógicos
- Organização de regras de negócio
- Estruturas condicionais

## Execução

Para executar um dos projetos:

```powershell
dotnet run
```

Cada exercício está armazenado em um projeto Console separado.