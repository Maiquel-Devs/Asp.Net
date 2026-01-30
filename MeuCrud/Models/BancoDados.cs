using Microsoft.EntityFrameworkCore;

namespace MeuCrud.Models;

public class BancoDados : DbContext
{
    
    public DbSet<Pessoa> PessoaDB { get; set; }     // Cria uma tabela do tipo Pessoa no banco de dados (Id, Nome, Idade) com  suar respectivas colunas
    
    protected override void OnConfiguring(DbContextOptionsBuilder options)    
    {
        options.UseMySQL("server=localhost;database=Meu_Criud;user=UsuCrud;password=CrudSenha");
    }
}

// Necessario instalar o pacote Pomelo.EntityFrameworkCore.MySql via NuGet Package Manager Console:
// Install-Package Pomelo.EntityFrameworkCore.MySql -Version 6.0.5

// dotnet tool install --global dotnet-ef

// dotnet add package Microsoft.EntityFrameworkCore.Design

// Comandos para criar as migrations e atualizar o banco de dados:

// dotnet ef migrations add InitialCreate

// dotnet ef database update