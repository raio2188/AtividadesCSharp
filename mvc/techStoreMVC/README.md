# TechStore MVC

Projeto desenvolvido durante as aulas de Desenvolvimento de Sistemas do SENAI, utilizando **C#**, **ASP.NET Core MVC**, **Razor** e **Bootstrap**.

O objetivo é compreender o funcionamento da arquitetura MVC (*Model-View-Controller*) por meio de uma aplicação web de uma loja de tecnologia, implementando listagens de produtos e categorias.

## Tecnologias utilizadas

- **C#**: linguagem de programação.
- **.NET 10**: plataforma utilizada no desenvolvimento.
- **ASP.NET Core MVC**: framework para construção da aplicação web.
- **Razor**: integração entre código C# e HTML.
- **Bootstrap**: estilização das páginas e tabelas.
- **HTML e CSS**: estrutura e apresentação da interface.
- **LINQ**: filtragem de coleções de objetos.

## Estrutura do projeto

O projeto está localizado em `mvc/techStoreMVC` dentro do repositório `AtividadesCSharp`.

```text
AtividadesCSharp/
└── mvc/
    └── techStoreMVC/
        ├── Controllers/
        │   ├── CategoriasController.cs
        │   ├── HomeController.cs
        │   └── ProdutosController.cs
        ├── Models/
        │   ├── Categorias.cs
        │   ├── ErrorViewModel.cs
        │   └── Produtos.cs
        ├── Views/
        │   ├── Categorias/
        │   │   ├── index.cshtml
        │   │   └── Ativas.cshtml
        │   ├── Home/
        │   │   ├── Index.cshtml
        │   │   └── Privacy.cshtml
        │   ├── Produtos/
        │   │   └── index.cshtml
        │   ├── Shared/
        │   │   ├── _Layout.cshtml
        │   │   ├── _Layout.cshtml.css
        │   │   ├── _ValidationScriptsPartial.cshtml
        │   │   └── Error.cshtml
        │   ├── _ViewImports.cshtml
        │   └── _ViewStart.cshtml
        ├── wwwroot/
        │   ├── css/
        │   │   └── site.css
        │   ├── js/
        │   │   └── site.js
        │   └── lib/
        │       ├── bootstrap/
        │       ├── jquery/
        │       ├── jquery-validation/
        │       └── jquery-validation-unobtrusive/
        ├── Properties/
        │   └── launchSettings.json
        ├── appsettings.json
        ├── appsettings.Development.json
        ├── Program.cs
        ├── README.md
        └── techStoreMVC.csproj
```

**Observação:** a estrutura representa o projeto com a inclusão da atividade de Categorias e dos desafios propostos. As pastas `bin/` e `obj/`, geradas durante a compilação, foram omitidas.

## Funcionalidades

### Listagem de Produtos

A aplicação possui uma página responsável por apresentar os produtos armazenados em uma lista criada no Controller.

Cada produto possui quatro propriedades:

| Propriedade | Tipo | Descrição |
|---|---|---|
| Id | int | Identificador do produto |
| Nome | string | Nome do produto |
| Preco | double | Preço do produto |
| Estoque | int | Quantidade disponível |

A View utiliza `@foreach` para percorrer os produtos e exibi-los em uma tabela HTML estilizada com Bootstrap.

**Rota:** `/produtos`

### Listagem de Categorias

A atividade de Categorias adiciona uma página para apresentar diferentes categorias de produtos da loja.

Cada categoria possui quatro propriedades:

| Propriedade | Tipo | Descrição |
|---|---|---|
| Id | int | Identificador da categoria |
| Nome | string | Nome da categoria |
| Descricao | string | Descrição da categoria |
| Ativa | bool | Indica se a categoria está ativa |

A lista possui cinco categorias:

| Código | Categoria | Descrição | Situação |
|---|---|---|---|
| 1 | Informática | Computadores e componentes | Ativa |
| 2 | Periféricos | Mouse, teclado e acessórios | Ativa |
| 3 | Áudio | Fones, caixas e microfones | Ativa |
| 4 | Monitores | Telas e monitores | Ativa |
| 5 | Descontinuados | Categorias fora de uso | Inativa |

A situação de cada categoria é determinada por uma estrutura condicional Razor:

```cshtml
@if (categorias.Ativa)
{
    <td class="text-success">Ativa</td>
}
else
{
    <td class="text-danger fw-bold">Inativa</td>
}
```

A página apresenta **Ativa** em verde quando a propriedade possui valor `true` e **Inativa** em vermelho e negrito quando possui valor `false`.

Também existem botões de Detalhes na tabela, ainda sem funcionalidade implementada.

**Rota:** `/categorias`

### Listagem de Categorias Ativas

Foi implementada uma segunda Action chamada `Ativas`, responsável por filtrar e apresentar somente as categorias que possuem a propriedade `Ativa` com valor `true`.

A filtragem utiliza o método `Where()` do LINQ:

```csharp
public IActionResult Ativas()
{
    var categoriasAtivas = categorias
        .Where(categoria => categoria.Ativa)
        .ToList();

    return View(categoriasAtivas);
}
```

O método `Where()` seleciona somente os objetos que satisfazem a condição informada.

O resultado é convertido em uma lista utilizando `ToList()` e enviado para a View `Ativas.cshtml`.

A página apresenta quatro categorias ativas, excluindo a categoria Descontinuados.

**Rota:** `/categorias/ativas`

---

## Desafios adicionais

### Desafio 1: Contagem de categorias

**Objetivo:** mostrar a quantidade total de categorias acima da tabela.

Foi utilizada a propriedade `Count` da lista recebida pela View:

```cshtml
<p>Total de categorias: @Model.Count</p>
```

**Resultado:**

```text
Total de categorias: 5
```

A contagem é dinâmica, ou seja, o número apresentado é atualizado automaticamente caso a quantidade de objetos enviados para a View seja alterada.

### Desafio 2: Destaque visual

**Objetivo:** apresentar categorias inativas com uma cor ou texto diferente.

Foi utilizada uma estrutura condicional `@if` para verificar a propriedade `Ativa`.

```cshtml
@if (categorias.Ativa)
{
    <td class="text-success">Ativa</td>
}
else
{
    <td class="text-danger fw-bold">Inativa</td>
}
```

As classes do Bootstrap utilizadas foram:

- `text-success`: aplica a cor verde.
- `text-danger`: aplica a cor vermelha.
- `fw-bold`: deixa o texto em negrito.

Dessa forma, o usuário consegue identificar visualmente as categorias inativas.

### Desafio 3: Segunda rota

**Objetivo:** criar uma Action chamada `Ativas`, acessível pela rota `/categorias/ativas`, que envie somente as categorias ativas para uma View.

A implementação foi dividida em duas etapas:

**1. Criação da Action no Controller**

```csharp
public IActionResult Ativas()
{
    var categoriasAtivas = categorias
        .Where(categoria => categoria.Ativa)
        .ToList();

    return View(categoriasAtivas);
}
```

A variável `categoriasAtivas` armazena o resultado da filtragem.

O comando `return View(categoriasAtivas)` envia os dados para a View correspondente ao nome da Action, `Ativas.cshtml`.

**2. Criação da View**

Foi criada a View `Views/Categorias/Ativas.cshtml`, responsável por receber a lista filtrada e apresentar somente as categorias ativas.

```cshtml
@model List<techStoreMVC.Models.Categorias>

@{
    ViewData["Title"] = "Categorias Ativas";
}

<h1>Categorias Ativas</h1>

<p>Total de categorias ativas: @Model.Count</p>

<table class="table table-striped">
    <thead>
        <tr>
            <th>Código</th>
            <th>Nome</th>
            <th>Descrição</th>
            <th>Situação</th>
        </tr>
    </thead>
    <tbody>
        @foreach (var categoria in Model)
        {
            <tr>
                <td>@categoria.Id</td>
                <td>@categoria.Nome</td>
                <td>@categoria.Descricao</td>
                <td class="text-success">Ativa</td>
            </tr>
        }
    </tbody>
</table>
```

**Resultado:** são apresentadas somente as quatro categorias ativas.

Não foi necessário criar uma nova classe Model, pois as duas Views utilizam objetos do mesmo tipo `Categorias`.

---

## Questões da atividade: Categorias

### 1. Qual é a responsabilidade da classe `Categoria`?

No projeto, a classe utilizada se chama `Categorias`.

Ela representa o **Model** da aplicação e é responsável por definir a estrutura dos dados de uma categoria.

Possui as propriedades `Id`, `Nome`, `Descricao` e `Ativa`, além de um construtor que recebe os valores necessários para inicializar cada objeto.

Sua função é representar as informações, não controlar requisições ou construir a interface.

### 2. Qual é a responsabilidade do `CategoriasController`?

O `CategoriasController` é responsável por receber e processar as requisições relacionadas às categorias.

Na aplicação, possui duas Actions principais:

- `Index()`: envia todas as categorias para a View.
- `Ativas()`: filtra e envia somente as categorias ativas.

O Controller faz a ligação entre os dados do Model e a interface apresentada pela View.

### 3. Por que a View utiliza uma lista em `@model`?

Porque a View precisa receber e exibir várias categorias ao mesmo tempo.

A declaração:

```cshtml
@model List<techStoreMVC.Models.Categorias>
```

define que o Model recebido será uma lista contendo objetos do tipo `Categorias`.

Se fosse utilizado apenas `@model techStoreMVC.Models.Categorias`, a View esperaria receber uma única categoria, e não uma coleção.

### 4. Para que serve o `foreach`?

O `foreach` é uma estrutura de repetição que percorre os elementos de uma coleção.

No projeto, ele percorre todas as categorias presentes no Model e gera uma linha da tabela para cada uma.

```cshtml
@foreach (var categorias in Model)
{
    <tr>
        <td>@categorias.Id</td>
        <td>@categorias.Nome</td>
        <td>@categorias.Descricao</td>
    </tr>
}
```

Isso evita escrever uma linha HTML manualmente para cada categoria.

Caso outras categorias sejam adicionadas à lista do Controller, elas também serão exibidas automaticamente.

### 5. O que aconteceria se a pasta fosse criada como `Views/Categoria`, no singular?

Por convenção, o ASP.NET Core MVC procura as Views em uma pasta com o mesmo nome do Controller, removendo o sufixo `Controller`.

Como a classe se chama `CategoriasController`, o caminho esperado é:

```text
Views/Categorias/index.cshtml
```

Se a pasta fosse criada como `Views/Categoria`, a aplicação não encontraria a View pelo caminho convencional e apresentaria um erro de View não encontrada, a menos que o caminho fosse especificado manualmente ou houvesse uma configuração personalizada.

### 6. Qual caminho a aplicação percorre quando acessamos `/categorias`?

Ao acessar a rota `/categorias`, a requisição segue o fluxo da arquitetura MVC:

1. **Roteamento:** o ASP.NET Core identifica a rota `/categorias`.
2. **Controller:** a requisição é direcionada ao `CategoriasController`.
3. **Action:** o método `Index()` é executado por ser a ação padrão.
4. **Model:** o Controller utiliza uma lista contendo os objetos de `Categorias`.
5. **View:** a lista é enviada para `Views/Categorias/index.cshtml`.
6. **Razor:** o `foreach` percorre os objetos e o `@if` verifica quais categorias estão ativas.
7. **Resposta:** o servidor gera o HTML e o envia ao navegador, que apresenta a tabela estilizada com Bootstrap.

**Representação do fluxo:**

```text
GET /categorias
       |
       v
CategoriasController
       |
       v
     Index()
       |
       v
 List<Categorias>
       |
       v
return View(categorias)
       |
       v
Views/Categorias/index.cshtml
       |
       v
   Razor + HTML
       |
       v
 Página no navegador
```

Já ao acessar `/categorias/ativas`, o fluxo é semelhante, mas executa a Action `Ativas()`, que filtra os objetos antes de enviá-los à View.

---

## Executando o projeto

É necessário possuir o **.NET 10 SDK** instalado.

Clone o repositório:

```bash
git clone https://github.com/raio2188/AtividadesCSharp.git
```

Acesse o diretório da aplicação:

```bash
cd AtividadesCSharp/mvc/techStoreMVC
```

Execute:

```bash
dotnet run
```

Após a inicialização, acesse o endereço local informado pelo terminal.

### Rotas disponíveis

| Rota | Descrição |
|---|---|
| `/` | Página inicial da aplicação |
| `/produtos` | Lista de produtos |
| `/categorias` | Lista de todas as categorias |
| `/categorias/ativas` | Lista somente das categorias ativas |

## Conclusão

O desenvolvimento do TechStore MVC permitiu colocar em prática os conceitos de programação orientada a objetos e arquitetura MVC.

A atividade de Produtos introduziu a criação de Models, Controllers, listas de objetos e Views dinâmicas utilizando Razor.

A atividade de Categorias expandiu esses conceitos ao adicionar uma nova entidade, seu respectivo Controller e uma View com estruturas condicionais para representar o estado de cada categoria.

Os desafios adicionais permitiram aprofundar o uso do Razor e do ASP.NET Core MVC, implementando contagens dinâmicas, diferenciação visual com Bootstrap, filtragem de coleções utilizando LINQ e uma segunda rota para apresentação de dados específicos.

Com isso, foi possível compreender melhor a separação de responsabilidades entre as camadas da aplicação e o fluxo de informações desde uma requisição HTTP até a apresentação dos dados no navegador.