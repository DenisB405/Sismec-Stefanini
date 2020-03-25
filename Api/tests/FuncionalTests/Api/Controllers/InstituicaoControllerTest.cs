using AutoMapper;
using First_Project_Stefanini.Application.AppService;
using First_Project_Stefanini.Application.DTO.Instituicao;
using First_Project_Stefanini.Application.Interface;
using First_Project_Stefanini.Application.Mapper;
using First_Project_Stefanini.Structure.Data;
using First_Project_Stefanini.Structure.DI;
using First_Project_Stefanini.Structure.Repository;
using Frist_Project_Stefanini.Api;
using Frist_Project_Stefanini.Api.Controllers;
using Frist_Project_Stefanini.Api.Helper;
using Frist_Project_Stefanini.ApplicarionCore.Interfaces.Services;
using Frist_Project_Stefanini.ApplicarionCore.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using Xunit;

namespace FuncionalTests.Api.Controllers
{
    public class InstituicaoControllerTest
    {
        public InstituicaoController getController()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingEntidade());
            });
            var mapper = config.CreateMapper();

            var connection = ConnectionString.GetConnectionString();
            var options = new DbContextOptionsBuilder<InstituicaoContext>().UseInMemoryDatabase("DadoCadastroInstituicaoValidoDeveAdicionarNoBancoDeDados").Options;
            var contexto = new InstituicaoContext(options);
            var repo = new InstituicaoRepository(contexto);

            var service = new InstituicaoService(repo);

            var appService = new InstituicaoAppService(service, mapper);

            return new InstituicaoController(appService);
        }

        [Fact]
        public void DadoCadastroInstituicaoValidoDeveRetornarOkResult()
        {
            //arrange
            var instituicaoRequest = new InstituicaoRequest() { codigo = 100, descricao = "Universidade" };
            var controller = getController();
            //act
            var retorno = controller.add(instituicaoRequest);

            //assert
            Assert.IsType<OkResult>(retorno);

        }

        [Fact]
        public void DadoCadastroInstituicaoValidoComCodigoDuplicadoDeveRetornarBadRequest()
        {
            //arrange
            var instituicaoRequest = new InstituicaoRequest() { codigo = 100, descricao = "Universidade" };
            var instituicaoRequestDuplicado = new InstituicaoRequest() { codigo = 100, descricao = "Universidade" };
            var controller = getController();
            controller.add(instituicaoRequest);
            //act
            var retorno = controller.add(instituicaoRequestDuplicado);

            //assert
            Assert.IsType<BadRequestObjectResult>(retorno);
        }
        [Fact]
        public void DadoCadastroInstituicaoCodigoIgualMenosUmDeveRetornarBadRequest()
        {
            //arrange
            var instituicaoRequest = new InstituicaoRequest() { codigo = -1, descricao = "Universidade" };
            var controller = getController();
            //act
            var retorno = controller.add(instituicaoRequest);

            //assert
            Assert.IsType<BadRequestObjectResult>(retorno);
        }
        [Fact]
        public void DadoCadastroInstituicaoCodigoIgualZeroDeveRetornarBadRequest()
        {
            //arrange
            var instituicaoRequest = new InstituicaoRequest() { codigo = 0, descricao = "Universidade" };
            var controller = getController();
            //act
            var retorno = controller.add(instituicaoRequest);

            //assert
            Assert.IsType<BadRequestObjectResult>(retorno);
        }
        [Fact]
        public void DadoCadastroInstituicaoCodigoIgualSemMilDeveRetornarBadRequest()
        {
            //arrange
            var instituicaoRequest = new InstituicaoRequest() { codigo = 100000, descricao = "Universidade" };
            var controller = getController();
            //act
            var retorno = controller.add(instituicaoRequest);

            //assert
            Assert.IsType<BadRequestObjectResult>(retorno);
        }
        [Fact]
        public void DadoCadastroInstituicaoNullRetornarBadRequest()
        {
            //arrange
            InstituicaoRequest instituicaoRequest = null;
            var controller = getController();
            //act
            var retorno = controller.add(instituicaoRequest);

            //assert
            Assert.IsType<BadRequestObjectResult>(retorno);
        }
    }
}



