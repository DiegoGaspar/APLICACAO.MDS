using APLICACAO.MDS.App.Models;
using Microsoft.EntityFrameworkCore;

namespace APLICACAO.MDS.App.Data.Context
{
    public class Contexto: DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }
        public DbSet<Funcionario> Funcionarios { get; set; }
    }
}
