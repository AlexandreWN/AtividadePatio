using System;
using Microsoft.EntityFrameworkCore;

namespace Model;

public class Context : DbContext
{
    public DbSet<Concessionaria> Concessionaria { get; set; }
    public DbSet<Automoveis> Automoveis { get; set; }
    public DbSet<Alocacao> Alocacao { get; set; }
    public DbSet<Cliente> Cliente { get; set; }
    public DbSet<Vendas> Vendas { get; set; }
    

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=" + Environment.MachineName + ";Initial Catalog=AtividadePatio; Integrated Security=SSPI;TrustServerCertificate=True");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Concessionaria>(entity =>{
            entity.HasKey(co => co.id);
            entity.Property(co => co.nome);
        });
        modelBuilder.Entity<Automoveis>(entity =>{
            entity.HasKey(au => au.id);
            entity.Property(au => au.valor);
            entity.Property(au => au.modelo);
        });
        modelBuilder.Entity<Alocacao>(entity =>{
            entity.HasKey(al => al.id);
            entity.Property(al => al.quantidade);
            entity.Property(al => al.area);
            entity.HasOne(al => al.automoveis);
            entity.HasOne(al => al.concessionaria);
        });
        modelBuilder.Entity<Cliente>(entity =>{
            entity.HasKey(cl => cl.id);
            entity.Property(cl => cl.nome);
        });
        modelBuilder.Entity<Vendas>(entity =>{
            entity.HasKey(v => v.id);
            entity.Property(v => v.data);
            entity.HasOne(v => v.alocacao);
            entity.HasOne(v => v.cliente);
        });
    }
}