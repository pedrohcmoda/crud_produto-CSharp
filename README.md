## Pré-requisitos

Certifique-se de que você tenha o seguinte software instalado:

- Visual Studio ou Visual Studio Code (ou qualquer IDE de sua preferência).
- .NET SDK (https://dotnet.microsoft.com/download).

## Executando o Aplicativo

1. Abra o projeto em seu ambiente de desenvolvimento ou a pasta em um terminal.

2. Na linha de comando compile a aplicação com
    dotnet build

3. Na linha de comando execute a aplicação com
    dotnet run

4. Após isso o terminal disponibilizara o 

## Funcionalidades

- **Listar Produtos:** Visualizar uma lista de produtos cadastrados.

- **Adicionar Produto:** Adicionar um novo produto ao banco de dados.

- **Editar Produto:** Editar informações de um produto existente.

- **Excluir Produto:** Excluir um produto do banco de dados.

## Estrutura do Projeto

- **Controllers:** Contém controladores para gerenciar as ações CRUD.

- **Models:** Contém as classes de modelo, como `Produto.cs`.

- **Views:** Contém as visualizações Razor para renderizar as páginas da web.

- **wwwroot:** Contém arquivos estáticos, como CSS.

- **appsettings.json:** Arquivo de configuração para configurações de aplicativo, incluindo a string de conexão do banco de dados.

## Tecnologias Utilizadas

- ASP.NET Core
- C#
- MySQL
- Entity Framework Core
- Razor Pages

## Contribuindo

Sinta-se à vontade para contribuir para este projeto ou criar problemas caso encontre algum bug ou tenha melhorias a sugerir.
