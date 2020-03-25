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
        public InstituicaoContext _context;
        public InstituicaoRepository repo;
        
        public InstituicaoCrudTest()
        {
            var connection = ConnectionString.GetConnectionString();
            var options = new DbContextOptionsBuilder<InstituicaoContext>().UseInMemoryDatabase("DadoCadastroInstituicaoNoRepositorioValidoDeveAdicionarNoBancoDeDados").Options;
            _context = new InstituicaoContext(options);
            repo = new InstituicaoRepository(_context);
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


            //act
            repo.Add(instituicao);

            //assert
            Assert.Equal(instituicao, repo.SearchById(instituicao.Id));
        }
        [Fact]
        public void buscaByCodigo()
        {
            //Arrange
            Instituicao instituicao = new Instituicao()
            {
                Codigo = 5,
                Descricao = "Universidade"
            };


            //act
            repo.Add(instituicao);
            var all = repo.GetAll();
            //assert
            Assert.Equal(instituicao, repo.SearchByCodigo(instituicao.Codigo));
        }
        [Fact]
        public void getAll()
        {
            //arrange

            List<Instituicao> instituicoes = new List<Instituicao>();
            Instituicao instituicao = new Instituicao()
            {
                Codigo = 1,
                Descricao = "Universidade"
            };
            Instituicao instituicao2 = new Instituicao()
            {
                Codigo = 2,
                Descricao = "Universidade"
            };
            Instituicao instituicao3 = new Instituicao()
            {
                Codigo = 3,
                Descricao = "Universidade"
            };
            repo.Add(instituicao);
            repo.Add(instituicao2);
            repo.Add(instituicao3);
            instituicoes.Add(instituicao);
            instituicoes.Add(instituicao2);
            instituicoes.Add(instituicao3);
            //action
            var lista = repo.GetAll();

            //assert 
            Assert.Equal(instituicoes, lista);

        }
        [Fact]
        public void UpateByCodigo()
        {
            //Arrange
            Instituicao instituicao = new Instituicao()
            {
                Codigo = 5,
                Descricao = "Universidade"
            };
            repo.Add(instituicao);
            instituicao.Descricao = "Universidade modificada";

            //act
            repo.UpdateByCodigo(instituicao);

            //assert
            var s = repo.SearchById(instituicao.Id);
            Assert.Equal(instituicao, repo.SearchById(instituicao.Id));
        }

        [Fact]
        public void DeleteByCodigo()
        {
            //Arrange
            Instituicao instituicao = new Instituicao()
            {
                Codigo = 5,
                Descricao = "Universidade"
            };
            repo.Add(instituicao);

            //act
            var c = repo.SearchByCodigo(instituicao.Codigo);
            repo.DeleteByCodigo(instituicao.Codigo);

            //assert
            Assert.Null(repo.SearchByCodigo(instituicao.Codigo));
        }
    }
}
