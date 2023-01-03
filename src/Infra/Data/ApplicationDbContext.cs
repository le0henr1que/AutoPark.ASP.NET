namespace AutoPark.src.Infra.Data;

using AutoPark.src.Domain.Cars;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext {
    

    public DbSet<Cars>? Car {get; set;} 

    // ApplicationDbContext Variaveis de ambiente
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){
        
    }

    // Escreve e define propriedades dos campos de uma tabela no banco de dadoss
    protected override void OnModelCreating(ModelBuilder builder){
        builder.Entity<Cars>()
            .Property(p => p.Name).IsRequired();


    }

    // Criar convenlçoes no banco de dados
    protected override void ConfigureConventions(ModelConfigurationBuilder configuration){
        // configuration.Properties<string>()
        //     .HaveMaxLength(100);
    }
   
}