# 🚀 API REST Gerenciadora de produtos e clientes.

## 📋 Descrição

**ProductClientHub** é uma API REST desenvolvida em C# com .NET 8, que gerencia produtos e clientes de forma eficiente. O projeto segue uma arquitetura limpa e modular, implementando padrões de design como Clean Architecture e Use Cases.

## 🏗️ Arquitetura do Projeto

O projeto está organizado em uma solução com múltiplos projetos, seguindo princípios de separação de responsabilidades:

```
ProductClientHub/
├── ProductClientHub.API/           # Camada de apresentação (Controllers, Use Cases)
├── ProductClientHub.Communication/ # DTOs e modelos de comunicação
├── ProductClientHub.Exceptions/    # Tratamento de exceções customizadas
└── ProductClientHub.sln            # Arquivo de solução
```

## 🛠️ Tecnologias e Frameworks

### **.NET 8**
- Framework de desenvolvimento Microsoft mais recente
- Suporte a C# 12 com recursos modernos
- Performance otimizada e melhorias de segurança

### **ASP.NET Core Web API**
- Framework para construção de APIs REST
- Suporte a Swagger/OpenAPI para documentação
- Middleware configurável e extensível

### **Entity Framework Core 9.0.8**
- ORM (Object-Relational Mapping) para .NET
- Suporte a SQLite como banco de dados
- Migrations para controle de esquema do banco

### **FluentValidation 12.0.0**
- Biblioteca para validação de dados
- Sintaxe fluente e legível
- Validações customizáveis e extensíveis

### **Swashbuckle.AspNetCore 6.6.2**
- Geração automática de documentação Swagger
- Interface interativa para testar a API
- Documentação OpenAPI 3.0

## 📦 Dependências Principais

| Pacote | Versão | Descrição |
|--------|--------|-----------|
| Microsoft.EntityFrameworkCore | 9.0.8 | Core do Entity Framework |
| Microsoft.EntityFrameworkCore.Sqlite | 9.0.8 | Provider SQLite para EF Core |
| FluentValidation | 12.0.0 | Validação de dados |
| Swashbuckle.AspNetCore | 6.6.2 | Documentação Swagger |

## 🔧 Pré-requisitos

Antes de executar o projeto, certifique-se de ter instalado:

- **.NET 8 SDK** ou superior
- **Visual Studio 2022** (recomendado) ou **Visual Studio Code**
- **Git** para clonar o repositório

### Instalação do .NET 8 SDK

1. Acesse [dotnet.microsoft.com](https://dotnet.microsoft.com/download/dotnet/8.0)
2. Baixe e instale o SDK para Windows
3. Verifique a instalação executando:
   ```bash
   dotnet --version
   ```

## 🚀 Como Executar o Projeto

### 1. Clone o Repositório

```bash
git clone <URL_DO_REPOSITORIO>
cd CSharp-dotNet/ProductClientHub
```

### 2. Restaure as Dependências

```bash
dotnet restore
```

### 3. Execute o Projeto

```bash
dotnet run --project ProductClientHub.API
```

### 4. Acesse a API

- **API Base URL**: `https://localhost:7000` ou `http://localhost:5000`
- **Swagger UI**: `https://localhost:7000/swagger` ou `http://localhost:5000/swagger`

## 📚 Estrutura da API

### Endpoints Disponíveis

#### **Products Controller**
- `POST /api/products/{clientId}` - Cadastrar novo produto
- `DELETE /api/products/{id}` - Excluir produto

#### **Clients Controller**
- Endpoints para gerenciamento de clientes

### Modelos de Dados

#### **Product**
```json
{
  "name": "string",
  "brand": "string", 
  "price": "decimal"
}
```

#### **Client**
```json
{
  "name": "string",
  "email": "string"
}
```

## 🗄️ Banco de Dados

O projeto utiliza **SQLite** como banco de dados, que é:
- Leve e sem necessidade de instalação
- Perfeito para desenvolvimento e testes
- Armazenado em arquivo local

## 🔍 Funcionalidades

- ✅ Cadastro de produtos associados a clientes
- ✅ Exclusão de produtos
- ✅ Gerenciamento de clientes
- ✅ Validação de dados com FluentValidation
- ✅ Tratamento de exceções customizado
- ✅ Documentação automática com Swagger
- ✅ Arquitetura limpa e modular

## 🏛️ Padrões de Design

- **Clean Architecture**: Separação clara de responsabilidades
- **Use Cases**: Lógica de negócio isolada
- **Repository Pattern**: Abstração do acesso a dados
- **DTO Pattern**: Transferência de dados entre camadas
- **Exception Filter**: Tratamento centralizado de erros

## 🧪 Testando a API

### Com Swagger UI
1. Acesse `/swagger` na URL da API
2. Use a interface interativa para testar os endpoints
3. Visualize os modelos de request/response

### Com HTTP Client
O projeto inclui um arquivo `ProductClientHub.API.http` para testes via HTTP Client.

## 📁 Estrutura de Pastas Detalhada

```
ProductClientHub.API/
├── Controllers/          # Controladores da API
├── Entities/            # Entidades do domínio
├── UseCases/            # Casos de uso da aplicação
├── Infrastructure/      # Configurações de infraestrutura
├── Filters/             # Filtros customizados
└── Properties/          # Configurações do projeto

ProductClientHub.Communication/
├── Requests/            # DTOs de entrada
└── Responses/           # DTOs de saída

ProductClientHub.Exceptions/
└── Classes para tratamento de exceções
```

## 🔧 Configurações

### Arquivos de Configuração
- `appsettings.json` - Configurações gerais
- `appsettings.Development.json` - Configurações de desenvolvimento
- `.editorconfig` - Padrões de código

### Variáveis de Ambiente
- `UserSecretsId` - Configurado para desenvolvimento local

## 🚀 Deploy

### Desenvolvimento
```bash
dotnet run --project ProductClientHub.API
```

### Produção
```bash
dotnet publish -c Release
dotnet ProductClientHub.API.dll
```

## 🤝 Contribuição

1. Faça um fork do projeto
2. Crie uma branch para sua feature (`git checkout -b feature/AmazingFeature`)
3. Commit suas mudanças (`git commit -m 'Add some AmazingFeature'`)
4. Push para a branch (`git push origin feature/AmazingFeature`)
5. Abra um Pull Request

## 📝 Licença

Este projeto está sob a licença [MIT](LICENSE).

## 👨‍💻 Desenvolvedor

- **Nome**: Diogo
- **Tecnologias**: C#, .NET, ASP.NET Core, Entity Framework

## 📞 Suporte

Para dúvidas ou suporte, entre em contato através de:
- Issues do GitHub
- Email: [seu-email@exemplo.com]

---

⭐ **Se este projeto foi útil, considere dar uma estrela!**
