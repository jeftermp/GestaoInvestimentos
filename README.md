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
    -> Armazena os arquivo relacionados a integração
    -> Especificação funcional Ágil;
    -> Fluxogramas;
- 01-Domain:
  -> Responsável pelo mapeamento de entidades
  -> Getters and Setters;
- 02-Infrastructure

## Database:
- 


1. Clone the repository:
- git clone https://github.com/jeftermp/GestaoInvestimentos.git

2. Set up the database connection in appsettings.json:
{
  "ConnectionStrings": {
    "SQLServer": "InvestimentosDataBase"
  }
}
