using First_Project_Stefanini.Structure.Data;
using First_Project_Stefanini.Structure.Repository;
using Frist_Project_Stefanini.Api.Helper;
using Frist_Project_Stefanini.ApplicarionCore.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace First_Project_Stefanini.tests.repositoryTests.InstituicaoRepositoryTeste
{
    public class CreateInstituicaoRepositoryTeste
    {
        [Fact]
        public void DadoCadastroInstituicaoValidoRepositorioDeveAdicionarNoBancoDeDados()
        {
            //Arrange
            Instituicao instituicao = new Instituicao()
            {
                Codigo = 5,
                Descricao = "Universidade"
            };

            var connection = ConnectionString.GetConnectionString();
            var options = new DbContextOptionsBuilder<InstituicaoContext>().UseInMemoryDatabase("DadoCadastroInstituicaoNoRepositorioValidoDeveAdicionarNoBancoDeDados").Options;
            var contexto = new InstituicaoContext(options);
            var repo = new InstituicaoRepository(contexto);

            //act
            repo.Add(instituicao);

            //assert
            var busca = contexto.Set<Instituicao>().Find(instituicao.Id);

            Assert.NotNull(busca);

            contexto.Remove<Instituicao>(instituicao);
            contexto.SaveChanges();
        }
    }
}
