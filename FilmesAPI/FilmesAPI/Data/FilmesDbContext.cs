using FilmesAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FilmesAPI.Data
{
    public class FilmesDbContext : DbContext
    {
        public FilmesDbContext(DbContextOptions<FilmesDbContext> opt) : base(opt) 
        {

        }

        public DbSet<Filme> Filmes { get; set; } //Conjunto de dados do banco, onde conseguimos fazer o acesso aos dados
    }
}
