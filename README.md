# CRUD de Clientes

Boas-vindas ao repositório do exercício `CRUD de Clientes`

Para realizar o exercício, atente-se a cada passo descrito a seguir e se tiver **qualquer dúvida**, nos envie no _Slack_ da turma! #vqv 🚀

Aqui, você vai encontrar os detalhes de como estruturar o desenvolvimento do seu exercício a partir desse repositório, utilizando uma branch específica e um _Pull Request_ para colocar seus códigos.

## Termos e acordos

Ao iniciar este exercício, você concorda com as diretrizes do [Código de Conduta e do Manual da Pessoa Estudante da Trybe](https://app.betrybe.com/learn/student-manual/codigo-de-conduta-da-pessoa-estudante).

## Entregáveis

<details>
<summary><strong>🤷🏽‍♀️ Como entregar</strong></summary>

Para entregar o seu exercício, você deverá criar um _Pull Request_ neste repositório.

Lembre-se que você pode consultar nosso conteúdo sobre [Git & GitHub](https://app.betrybe.com/learn/course/5e938f69-6e32-43b3-9685-c936530fd326/module/fc998c60-386e-46bc-83ca-4269beb17e17/section/fe827a71-3222-4b4d-a66f-ed98e09961af/day/1a530297-e176-4c79-8ed9-291ae2950540/lesson/2b2edce7-9c49-4907-92a2-aa571f823b79) e nosso [Blog - Git & GitHub](https://blog.betrybe.com/tecnologia/git-e-github/) sempre que precisar!

</details>
  
<details>
<summary><strong>🧑‍💻 O que deverá ser desenvolvido</strong></summary>

Agora que você já sabe como criar uma API básica, com controllers funcionais que implementam um CRUD, que tal testarmos isso na prática?

Vamos imaginar que você precisa construir uma API para uma plataforma financeira que registre um banco de dados de clientes e suas transações. Seu desafio será implementar os métodos do controller `CustomerController` e os testes necessários para validar o seu funcionamento.

</details>
  
<details>
  <summary><strong>:memo: Habilidades a serem trabalhadas</strong></summary>

Neste exercício, verificamos se você é capaz de:

- Recordar a sintaxe básica do C# para declaração de variáveis, estruturas de controle e definição de classes.
- Identificar as operações de CRUD (Create, Read, Update, Delete) e sua finalidade.
- Compreender o uso de classes, métodos e propriedades no contexto do CRUD.
- Implementar classes e métodos para representar entidades e suas operações no CRUD.
- Desenvolver as funcionalidades de criação, leitura, atualização e exclusão de dados.

</details>

## Orientações
  
<details>

   <summary><strong>‼ Antes de começar a desenvolver </strong></summary>

<!-- 🤔 [HS] Aqui, deve-se adicionar os comandos mais utilizados e orientações de como preparar o repositório. Atualize o nome do repositório do exercício nas instruções a seguir -->

1. Clone o repositório

- Use o comando: `git@github.com:betrybe/csharp-001-exercicio-crud-de-clientes.git`
- Entre na pasta do repositório que você acabou de clonar:
    - `cd csharp-001-exercicio-crud-de-clientes`

2. Instale as dependências

    - npm install

3. Crie uma branch a partir da branch `main`

- Verifique que você está na branch `main`
    - Exemplo: `git branch`
- Se você não estiver, mude para a branch `main`
    - Exemplo: `git checkout main`
- Agora, crie uma branch à qual você vai submeter os `commits` do seu exercício:
    - Você deve criar uma branch no seguinte formato: `nome-sobrenome-nome-do-exercício`;
    - Exemplo: `git checkout -b maria-soares-csharp-001-exercicio-crud-de-clientes`

4. Crie na raiz do exercício os arquivos que você precisará desenvolver:

- Verifique que você está na raiz do exercício:
    - Exemplo: `pwd` -> o retorno vai ser algo tipo _/Users/maria/code/**csharp-001-exercicio-crud-de-clientes**_
- Crie os arquivos index.html e style.css:
    - Exemplo: `touch index.html style.css`

5. Adicione as mudanças ao _stage_ do Git e faça um `commit`

- Verifique que as mudanças ainda não estão no _stage_:
    - Exemplo: `git status` (devem aparecer listados os novos arquivos em vermelho)
- Adicione o novo arquivo ao _stage_ do Git:
    - Exemplo:
        - `git add .` (adicionando todas as mudanças - _que estavam em vermelho_ - ao stage do Git)
        - `git status` (devem aparecer listados os arquivos em verde)
- Faça o `commit` inicial:
    - Exemplo:
        - `git commit -m 'iniciando o exercício. VAMOS COM TUDO :rocket:'` (fazendo o primeiro commit)
        - `git status` (deve aparecer uma mensagem tipo _nothing to commit_ )

6. Adicione a sua branch com o novo `commit` ao repositório remoto

- Usando o exemplo anterior: `git push -u origin maria-soares-csharp-001-exercicio-crud-de-clientes`

7. Crie um novo `Pull Request` _(PR)_

- Vá até a página de _Pull Requests_ do [repositório no GitHub](https://github.com/tryber/csharp-001-exercicio-crud-de-clientes/pulls)
    - Clique no botão verde _"New pull request"_
    - Clique na caixa de seleção _"Compare"_ e escolha a sua branch **com atenção**
- Coloque um título para o seu _Pull Request_
    - Exemplo: _"Cria tela de busca"_
- Clique no botão verde _"Create pull request"_

- Adicione uma descrição para o _Pull Request_, um título nítido que o identifique, e clique no botão verde _"Create pull request"_

 <img width="1335" alt="Exemplo de pull request" src="https://user-images.githubusercontent.com/42356399/166255109-b95e6eb4-2503-45e5-8fb3-cf7caa0436e5.png">

- Volte até a [página de _Pull Requests_ do repositório](https://github.com/tryber/csharp-001-exercicio-crud-de-clientes/pulls) e confira que o seu _Pull Request_ está criado

</details>

<details>

<summary><strong>⌨️ Durante o desenvolvimento</strong></summary>

Faça `commits` das alterações que você fizer no código regularmente, pois assim você garante visibilidade para o time da Trybe e treina essa prática para o mercado de trabalho :) ;

- Lembre-se de sempre após um (ou alguns) `commits` atualizar o repositório remoto;
- Os comandos que você utilizará com mais frequência são:
    - `git status` _(para verificar o que está em vermelho - fora do stage - e o que está em verde - no stage)_;
    - `git add` _(para adicionar arquivos ao stage do Git)_;
    - `git commit` _(para criar um commit com os arquivos que estão no stage do Git)_;
    - `git push -u origin nome-da-branch` _(para enviar o commit para o repositório remoto na primeira vez que fizer o `push` de uma nova branch)_;
    - `git push` _(para enviar o commit para o repositório remoto após o passo anterior)_.

</details>

<details>
<summary><strong>🎛 Linter</strong></summary>

  Usaremos o [NetAnalyzer](https://docs.microsoft.com/pt-br/dotnet/fundamentals/code-analysis/overview) para fazer a análise estática do seu código.

  Este projeto já vem com as dependências relacionadas ao _linter_ configuradas no arquivo `.csproj`.

  O analisador já é instalado pelo plugin da `Microsoft C#` no `VSCode`. Para isso, basta fazer o download do [plugin](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp) e instalá-lo.

⚠️ **PULL REQUESTS COM ISSUES NO LINTER NÃO SERÃO AVALIADAS. ATENTE-SE PARA RESOLVÊ-LAS ANTES DE FINALIZAR O DESENVOLVIMENTO!** ⚠️

</details>
  
<details>
<summary><strong>🛠 Testes</strong></summary>

O .NET já possui sua própria plataforma de testes.

  Este projeto já vem configurado e com suas dependências.

  ### Executando todos os testes

  Para executar os testes com o .NET, execute o comando dentro do diretório do seu projeto `src/<project>` ou de seus testes `src/<project>.Test`!

  ```
  dotnet test
  ```

  ### Executando um teste específico

  Para executar um teste específico, basta executar o comando `dotnet test --filter Name~TestMethod1`.

  :warning: **Importante:** o comando irá executar testes cujo nome contém `TestMethod1`.

  :warning: **O avaliador automático não necessariamente avalia seu projeto na ordem em que os requisitos aparecem no readme. Isso acontece para deixar o processo de avaliação mais rápido. Então, não se assuste se isso acontecer, ok?**

  ### Outras opções para testes
  - Algumas opções que podem lhe ajudar são:
    -  `-?|-h|--help`: exibe a descrição completa de como utilizar o comando.
    -  `-t|--list-tests`: lista todos os testes, ao invés de executá-los.
    -  `-v|--verbosity <LEVEL>`: define o nível de detalhe na resposta dos testes.
      - `q | quiet`
      - `m | minimal`
      - `n | normal`
      - `d | detailed`
      - `diag | diagnostic`
      - Exemplo de uso:
         ```
           dotnet test -v diag
         ```
         ou
         ```
           dotnet test --verbosity=diagnostic
         ```

</details>

# Requisitos

Parte da aplicação já está configurada, especialmente:
- um banco de dados local em JSON, utilizando a biblioteca [`JsonFlatFileDataStore`](https://github.com/ttu/json-flatfile-datastore)
- Uma classe `CustomerRepository` e uma interface `ICustomerRepository`, que implementam o padrão de projeto _repository_ e que servem para facilitar o acesso à camada de acesso ao banco
- a classe `Program`, que já integra os serviços referentes ao banco e ao _repository_ na aplicação, tornando-os acessíveis no controller por meio da **injeção de dependência**

Como temos um repository já implementado, você pode utilizar os métodos da interface `ICustomerRepository` dentro do controller para fazer operações no banco de dados em JSON sem se preocupar com os detalhes de implementação!

<details>
  <summary> **Antes de tudo, vamos configurar o projeto:**</summary>
  
  ### Configurando o `CustomerController`
  <details>
    <summary>A classe <code>CustomerController</code> deve ser decorada com o atributo <code>ApiController</code></summary><br />

  Esse atributo irá permitir que o controller seja detectado como tal pela aplicação.

  </details>

  <details>
    <summary>A classe <code>CustomerController</code> deve utilizar o atributo <code>Route</code> para determinar uma rota base <code>"/controller"</code></summary><br />

  A rota definida no atributo Route será usada como base por todos os métodos do controller.

  </details>

  <details>
    <summary>A classe <code>CustomerController</code> deve herdar da classe <code>ControllerBase</code></summary><br />

  Essa classe define métodos úteis que retornarão objetos derivados de ActionResult e poderão ser usados nos métodos do controller para retornar respostas HTTP completas de forma simples.

  </details>

  <details>
    <summary>A classe <code>CustomerController</code> deve possuir um campo privado e somente leitura do tipo <code>ICustomerRepository</code></summary><br />

  Esse campo, que armazenará uma referência ao singleton do repositório, poderá ser utilizada para invocar os seus métodos e, através deles, ler e modificar informações armazenadas no banco.

  </details>

  <details>
    <summary>A classe <code>CustomerController</code> deve possuir um controller que receba um <code>ICustomerRepository</code> e o atribua ao campo criado anteriormente</summary><br />

  O serviço <code>CustomerRepository</code> será passado para o controller automaticamente, por injeção de dependência, pois trata-se de um dos serviços preconfigurados na classe <code>Program</code>.

  </details>
</details>

---

## 1. Crie o método `GetAll`

<details>

<summary> Mais informações
</summary>

Cria sua lógica em src/CustomerCrud/Controllers/CustomerController.cs

Ao acessar a rota <code>"GET /controller"</code> devemos receber em resposta um array JSON contendo todos os objetos do tipo <code>Customer</code> salvos no banco.

Crie também os testes para a rota GetAll em src/CustomerCrud.Test/CustomerControllerTest.cs

Dica: O método <code>Ok()</code> do <code>ControllerBase</code> pode ser utilizado para facilitar esse retorno.

**O que será testado:**

 - O método <code>GetAll</code> deve ser acessível por uma requisição <code>GET</code> na rota <code>"/controller"</code>
   - Como a rota usada é a mesma que a rota base, apenas é necessário utilizar neste método o atributo que represente o verbo HTTP correto, sem nenhum parâmetro a mais.

 - O método <code>GetAll</code> deve responder com um <code>ActionResult</code> (ou derivado) contendo o status <code>200 (Ok)</code>, caso a leitura ocorra corretamente

 - A resposta do método <code>GetAll</code> deve retornar em seu corpo todas as entradas do banco

 - O método <code>GetAllTest</code> deve conter os testes para o método <code>GetAll</code>:
  - Uma chamada <code>GET</code> para a rota <code>"/customers"</code> utilizando o <code>_client</code>
  - Um mock do método <code>GetAll()</code> do repositório, configurado usando o <code>_repositoryMock</code>
  - Uma verificação de que a resposta retornada pela chamada ao cliente é do tipo <code>200 (Ok)</code>
  - Uma verificação de que o conteúdo da resposta é equivalente ao objeto retornado pelo mock
  - Uma verificação de que o método mockado foi chamado uma única vez

</details>

## 2. Crie o método `GetById`

<details>

<summary> Mais informações
</summary>

Cria sua lógica em src/CustomerCrud/Controllers/CustomerController.cs

O método <code>GetById</code> deve retornar em seu corpo apenas a entrada com o <code>Id</code> indicado, caso a leitura ocorra corretamente
  - Ao usar essa rota devemos receber um objeto único em JSON, cujo <code>Id</code> corresponda ao valor passado na URL.

Crie também os testes para a rota GetById em src/CustomerCrud.Test/CustomerControllerTest.cs

Dica: O método <code>Ok()</code> e <code>NotFound()</code> do <code>ControllerBase</code> pode ser utilizado para facilitar esse retorno.

**O que será testado:**

  - O método <code>GetById</code> deve ser acessível por uma requisição <code>GET</code> na rota <code>"/controller/{id}"</code>
    - Como a rota usada possui um <code>query parameter</code>, além do atributo que represente o verbo HTTP correto, é necessário indicar também o parâmetro recebido.

  - O método <code>GetById</code> deve responder com um <code>ActionResult</code> (ou derivado) contendo o status <code>200 (Ok)</code>, caso a leitura ocorra corretamente

  - O método <code>GetById</code> deve responder com um <code>ActionResult</code> (ou derivado) contendo o status <code>404 (Not Found)</code>, caso não haja um objeto com o <code>Id</code> passado

  - O método <code>GetById</code> deve retornar em seu corpo a mensagem <code>"Customer not found"</code>, caso não haja um objeto com o <code>Id</code> passado
    - Ao usar essa rota devemos receber apenas uma <code>string</code> indicando que não há nenhum objeto que possua o <code>Id</code> correspondente.

  - O método <code>GetByIdTest</code> deve conter os testes para o método <code>GetById</code>:
    - Uma chamada <code>GET</code> para a rota <code>G"/customers/1"</code> utilizando o <code>_client</code>
    - Um mock do método <code>GetById()</code> do repositório, configurado usando o <code>_repositoryMock</code>
    - O método mockado deve retornar o objeto correto apenas se receber o id `1`
    - Uma verificação de que a resposta retornada pela chamada ao cliente é do tipo <code>200 (Ok)</code>
    - Uma verificação de que o conteúdo da resposta é equivalente ao objeto retornado pelo mock
    - Uma verificação de que o método mockado foi chamado uma única vez

</details>

## 3. Crie o método `Create`

<details>

<summary> Mais informações
</summary>

Cria sua lógica em src/CustomerCrud/Controllers/CustomerController.cs

O método <code>Create</code> deve retornar em seu corpo o objeto criado, contendo o <code>Id</code> e os timestamps de criação e update atribuídos
  - Ao usar essa rota, devemos receber um objeto único em JSON, cujo <code>Id</code> seja único e corretamente atribuído e cujos <code>CreatedAt</code> e <code>UpdatedAt</code> sejam criados praticamente no mesmo instante (é tolerável uma diferença de até 100 ms).

Crie também os testes para a rota Create em src/CustomerCrud.Test/CustomerControllerTest.cs

Dica: O método <code>CreatedAtAction()</code> do <code>ControllerBase</code> pode ser utilizado para facilitar esse retorno.

**O que será testado:**

  - O método <code>Create</code> deve ser acessível por uma requisição <code>POST</code> na rota <code>"/controller"</code>

  - O método <code>Create</code> deve responder com um <code>ActionResult</code> (ou derivado) contendo o status <code>201 (Created)</code>, caso a criação ocorra corretamente

  - O método <code>Create</code> deve ter um atributo <code>location</code> no header da resposta com a rota do <code>GetById</code> que pode acessar o objeto criado

  - O método <code>CreateTest</code> deve conter os testes para o método <code>Create</code>:
    - Uma chamada <code>POST</code> para a rota `"/customers"</code> utilizando o <code>_client</code>
    - Um mock do método <code>GetNextIdValue()</code> do repositório, configurado usando o <code>_repositoryMock</code>
    - Um mock do método <code>Create()</code> do repositório, configurado usando o <code>_repositoryMock</code>
    - O método mockado deve retornar o objeto correto apenas se receber um objeto com o mesmo id retornado pelo mock de <code>GetNextIdValue()</code>
    - Uma verificação de que a resposta retornada pela chamada ao cliente é do tipo <code>201 (Created)</code>
    - Verificações de que os campos do objeto retornado possuem os valores esperados
    - Verificações de que os métodos mockados foram chamados uma única vez cada

</details>

## 4. Crie o método `Update`

<details>

<summary> Mais informações
</summary>

Cria sua lógica em src/CustomerCrud/Controllers/CustomerController.cs

O método <code>Update</code> deve retornar em seu corpo apenas uma mensagem <code>"Customer {id} updated"</code> caso a atualização seja bem-sucedida
  - Ao usar essa rota, devemos receber um objeto único em JSON, cujo <code>Id</code> corresponda ao valor passado na URL.

Crie também os testes para a rota Update em src/CustomerCrud.Test/CustomerControllerTest.cs

Dica: O método <code>Ok()</code> e <code>NotFound()</code> do <code>ControllerBase</code> pode ser utilizado para facilitar esse retorno.

**O que será testado:**

  - O método <code>Update</code> deve ser acessível por uma requisição <code>PUT</code> na rota <code>"/  controller/{id}"</code>
    - Como a rota usada possui um query parameter, além do atributo que represente o verbo HTTP correto, é necessário indicar também o parâmetro recebido.

  - O método <code>Update</code> deve responder com um <code>ActionResult</code> (ou derivado) contendo o status <code>200 (Ok)</code>, caso a atualização ocorra corretamente

  - O método <code>Update</code> deve responder com um <code>ActionResult</code> (ou derivado) contendo o status <code>404 (Not Found)</code>, caso não haja um objeto com o <code>Id</code> passado

  - O método <code>Update</code> deve retornar em seu corpo a mensagem <code>"Customer not found"</code>, caso não haja um objeto com o <code>Id</code> passado

  - O método <code>UpdateTest</code> deve conter os testes para o método <code>Update</code>
    - Uma chamada <code>PUT</code> para a rota <code>"/customers/1"</code> utilizando o <code>_client</code>
    - Um mock do método <code>Update()</code> do repositório, configurado usando o <code>_repositoryMock</code>
      - O método mockado deve retornar <code>true`</code> apenas se receber o id <code>1</code>
    - Uma verificação de que a resposta retornada pela chamada ao cliente é do tipo <code>200 (Ok)</code>
    - Uma verificação de que o corpo da resposta é a mensagem <code>"Customer 1 updated"</code>
    - Uma verificação de que o método mockado foi chamado uma única vez

</details>

## 5. Crie o método `Delete`

<details>

<summary> Mais informações
</summary>

Cria sua lógica em src/CustomerCrud/Controllers/CustomerController.cs

O método <code>Delete</code> deve retornar em seu corpo a mensagem <code>"Customer not found"</code>, caso não haja um objeto com o <code>Id</code> passado

Crie também os testes para a rota Delete em src/CustomerCrud.Test/CustomerControllerTest.cs

Dica: O método <code>NoContent()</code> do <code>ControllerBase</code> pode ser utilizado para facilitar esse retorno.

**O que será testado:**

  - O método <code>Delete</code> deve ser acessível por uma requisição <code>DELETE</code> na rota <code>"/controller/{id}"</code>
    - Como a rota usada possui um query parameter, além do atributo que represente o verbo HTTP correto, é necessário indicar também o parâmetro recebido.

  - O método <code>Delete</code> deve responder com um <code>ActionResult</code> (ou derivado) contendo o status <code>204 (No Content)</code>, caso a deleção ocorra corretamente

  - O método <code>Delete</code> deve responder com um <code>ActionResult</code> (ou derivado) contendo o status <code>404 (Not Found)</code>, caso não haja um objeto com o <code>Id</code> passado

  - O método <code>Delete</code> deve retornar em seu corpo a mensagem <code>"Customer not found"</code>, caso não haja um objeto com o <code>Id</code> passado

  - O método <code>DeleteTest</code> deve conter os testes para o método <code>Delete</code>
    - Uma chamada <code>DELETE</code> para a rota <code>"/customers/1"</code> utilizando o <code>_client</code>
    - Um mock do método <code>Delete()</code> do repositório, configurado usando o <code>_repositoryMock</code>
      - O método mockado deve retornar <code>true</code> apenas se receber o id <code>1</code>
    - Uma verificação de que a resposta retornada pela chamada ao cliente é do tipo <code>204 (No Content)</code>
    - Uma verificação de que o método mockado foi chamado uma única vez

</details>

<details>
<summary><strong> 🗣 Nos dê feedbacks sobre o exercício!</strong></summary>

Ao finalizar e submeter o exercício, não se esqueça de avaliar sua experiência preenchendo o [formulário](https://be-trybe.typeform.com/to/ZTeR4IbH#cohort_hidden=CH1&template=betrybe/csharp-0x-exercicio-crud-de-clientes).
**Leva menos de 3 minutos!**

</details>

---

<!-- mdi versão 1.0 exercício como projeto ⚠️ não exclua esse comentário -->
