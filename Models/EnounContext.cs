using System;
using Microsoft.EntityFrameworkCore;

namespace EnounSenac.Models
{
    public class EnounContext : DbContext
    {
    public DbSet<Produto>? Produtos { get; set; }
    public DbSet<Contato>? Contatos { get; set; }
    public DbSet<Curriculo>? Curriculos { get; set; }

    public string DbPath { get; }
    public EnounContext()
    {
        DbPath =( "enounSenac.db");
        
    }
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
    }
}

