# GestaoInvestimentos
Sistema de Gestão de Portfólio de Investimentos

## Features
- API com endpoints que possibilitam criação, alteração, obtenção e deleção de Clientes
- API com endpoints que possibilitam criação, alteração, obtenção e deleção de Produtos
- Entity Framework Core e SQLCommands que são usados para consultas e persistências em banco de dados
- Implementação de Injeção de Dependência;
- Testes Unitários para métodos de autenticação e clientes.
- Documentação da API disponibilizada também via swagger;

## Tecnologias Utilizadas
- .NET 8.0
- Entity Framework Core
- xUnit for unit testing
- Swagger for API documentation
- Docker for windows
- SQLServer dor DataBase

## Camadas do Sistema:
- 00-Documentation:
    - Armazena os arquivo relacionados a integração
    - Especificação funcional Ágil;
    - Fluxogramas;
    - Scripts de obejtos usados pelo sistema;
- 01-Domain:
  - Responsável pelo mapeamento de entidades
  - Getters and Setters;
- 02-Infrastructure
  - Responsável pela camada de Data
      - Contextos de banco de dados
      - Configurações de entidades e Repositórios
  - Responsável pela camada de Injeção de Depêndencia  
- 03-Services
  - Responsável pelo desenvolvimento de métodos para gerenciamento de regras de negócios atrelados a Domain;
- 04-Presentation
    - API
        - Controllers
        - Documentação Swagger;
        - Configurações de StartUp;
    - WorkerService
        - Serviço de monitoramento de produtos;
- 05-UnitTests
  - Testes de unidade para camadas da API;
  
## Database:
- Cofigurações:
    - Servidor: LocalHost (.)
    - Nome: InvestimentosDataBase
- Scripts:
    - Tabela de Clientes: CREATE_Clientes.sql
    - Tabela de Produtos: CREATE_Produtos.sql
    - Carga de produtos: ProductsRows.sql

1. Clone the repository:
- git clone https://github.com/jeftermp/GestaoInvestimentos.git

2. Set up the database connection in appsettings.json:
{
  "ConnectionStrings": {
    "SQLServer": "InvestimentosDataBase"
  }
}
