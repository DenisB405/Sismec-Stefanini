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
    public class InstituicaoCrudTest
    {
        public static InstituicaoRepository getRepo()
        {
            var connection = ConnectionString.GetConnectionString();
            var options = new DbContextOptionsBuilder<InstituicaoContext>().UseInMemoryDatabase("DadoCadastroInstituicaoNoRepositorioValidoDeveAdicionarNoBancoDeDados").Options;
            var contexto = new InstituicaoContext(options);
            return new InstituicaoRepository(contexto);
        }
        [Fact]
        public void add()
        {
            //Arrange
            Instituicao instituicao = new Instituicao()
            {
                Codigo = 5,
                Descricao = "Universidade"
            };

            var repo = getRepo();

            //act
            repo.Add(instituicao);

            //assert

        }
    }
}
