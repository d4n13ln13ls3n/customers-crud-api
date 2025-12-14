# Customers CRUD API

API RESTful desenvolvida em **ASP.NET Core** para gerenciamento de clientes, implementando operações básicas de **CRUD (Create, Read, Update, Delete)**.  
O projeto utiliza **JsonFlatFileDataStore** como mecanismo de persistência e foi desenvolvido com foco em **boas práticas**, **testes automatizados** e **clareza arquitetural**.

---

## 🚀 Tecnologias utilizadas

- **.NET 6**
- **ASP.NET Core Web API**
- **JsonFlatFileDataStore**
- **xUnit**
- **Moq**
- **Swagger / OpenAPI**
- **C#**

---

## 📁 Estrutura do projeto

```text
src/
 └── CustomerCrud/
     ├── Controllers/
     │   └── CustomerController.cs
     ├── Core/
     │   └── Customer.cs
     ├── Repositories/
     │   ├── ICustomerRepository.cs
     │   └── CustomerRepository.cs
     ├── Data/
     │   └── Database.json
     ├── Program.cs
     └── CustomerCrud.csproj

tests/
 └── CustomerCrud.Test/
     └── CustomersControllerTest.cs

## 📝 Nota sobre a origem do projeto

Este projeto foi desenvolvido **a partir de um repositório educacional fornecido pela Trybe**, que continha a estrutura inicial e o contexto do desafio.

A partir dessa base, **foram implementadas por mim**:

- Toda a lógica dos endpoints da API (CRUD completo de clientes)
- Implementação dos controllers e integração com o repositório
- Definição correta das rotas e códigos de status HTTP
- Tratamento de cenários de sucesso e erro (404, 400, 201, etc.)
- Implementação e ajuste dos testes automatizados
- Correções de comportamento da API em tempo de execução
- Validação prática das rotas via ferramentas de API (Insomnia / curl)

O objetivo principal do projeto foi consolidar conhecimentos práticos em **ASP.NET Core**, **APIs REST**, **testes automatizados** e **boas práticas de desenvolvimento backend**, a partir de um cenário realista de desafio técnico.
