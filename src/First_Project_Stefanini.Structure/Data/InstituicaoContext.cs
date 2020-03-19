using Frist_Project_Stefanini.ApplicarionCore.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace First_Project_Stefanini.Structure.Data
{
    public class InstituicaoContext : DbContext
    {
        public InstituicaoContext(DbContextOptions<InstituicaoContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Instituicao> Instituicoes { get; set; }
    }
}
