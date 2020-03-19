using First_Project_Stefanini.TestesUI.Fixture;
using First_Project_Stefanini.TestesUI.PageObject.TelasCadastro;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace First_Project_Stefanini.TestesUI.TestesUI.TelasCadastro
{
    public class InstituicaoTelaCadastroTesteUI : IClassFixture<TestFixture>
    {
        private IWebDriver driver;

        public InstituicaoTelaCadastroTesteUI(TestFixture fixture)
        {
            driver = fixture.Driver;
        }
        [Fact]
        public void UM_DadoCamposSemDadosDeveExebirMensagemDeErro()
        {
            //Arrange
            var instituicaoTelaCadastroPO = new InstituicaoTelaCadastroPO(driver);
            instituicaoTelaCadastroPO.visitar();
            instituicaoTelaCadastroPO.PreencheFormulario(null,null);
            //Action
            instituicaoTelaCadastroPO.SubimeteFormulario();
            //Assert
            Assert.Equal("#", instituicaoTelaCadastroPO.getMensagemErro());
        }

        [Fact]
        public void DOIS_DadoCodigoSemValorEDescricaoValidaDeveExibirMensagemDeErro()
        {
            //Arrange
            var instituicaoTelaCadastroPO = new InstituicaoTelaCadastroPO(driver);
            instituicaoTelaCadastroPO.visitar();
            instituicaoTelaCadastroPO.PreencheFormulario(null, "Descricao Simples Válida");
            //Action
            instituicaoTelaCadastroPO.SubimeteFormulario();
            //Assert
            Assert.Equal("#", instituicaoTelaCadastroPO.getMensagemErro());
        }
        [Fact]
        public void TRES_DadoDescricaoSemValorECodigoValidoDeveExibirMensagemDeErro()
        {
            //Arrange
            var instituicaoTelaCadastroPO = new InstituicaoTelaCadastroPO(driver);
            instituicaoTelaCadastroPO.visitar();
            instituicaoTelaCadastroPO.PreencheFormulario("1", null);
            //Action
            instituicaoTelaCadastroPO.SubimeteFormulario();
            //Assert
            Assert.Equal("#", instituicaoTelaCadastroPO.getMensagemErro());
        }
        [Theory]
        [InlineData(256,"#")]// Mensagem de erro
        [InlineData(255, "#")]// Mensagem de sucesso
        [InlineData(254, "#")]// Mensagem de sucesso
        [InlineData(1, "#")]// Mensagem de erro
        [InlineData(0, "#")]// Mensagem de erro
        public void QUATRO_DadoDescricaoContStringDeveExibirMensagem(int quantidadeDePalavras, string menssagem)
        {
            //Arrange
            string descricao = "";
            for (int i = 1; i <= quantidadeDePalavras; i++)
            {
                descricao = descricao + "a";
            }
            var instituicaoTelaCadastroPO = new InstituicaoTelaCadastroPO(driver);
            instituicaoTelaCadastroPO.visitar();
            instituicaoTelaCadastroPO.PreencheFormulario("1", descricao);
            //Action
            instituicaoTelaCadastroPO.SubimeteFormulario();
            //Assert
            Assert.Equal(menssagem, instituicaoTelaCadastroPO.getMensagemErro());
        }
        [Fact]
        public void Sete_DadoInsercaoDeStringNoCodigoDeveExibirMensagemDeErro()
        {
            //Arrange
            var instituicaoTelaCadastroPO = new InstituicaoTelaCadastroPO(driver);
            instituicaoTelaCadastroPO.visitar();
            instituicaoTelaCadastroPO.PreencheFormulario("1a5", "Descrição Válida");
            //Action
            instituicaoTelaCadastroPO.SubimeteFormulario();
            //Assert
            Assert.Equal("#", instituicaoTelaCadastroPO.getMensagemErro());
        }
        [Fact]
        public void Oito_DadoInsercaoDeCaracteresInvalidosDeveExibirMensagemDeErro()
        {
            //Arrange
            var instituicaoTelaCadastroPO = new InstituicaoTelaCadastroPO(driver);
            instituicaoTelaCadastroPO.visitar();
            instituicaoTelaCadastroPO.PreencheFormulario("!@#$%", "Descrição Válida");
            //Action
            instituicaoTelaCadastroPO.SubimeteFormulario();
            //Assert
            Assert.Equal("#", instituicaoTelaCadastroPO.getMensagemErro());
        }
        [Theory]
        [InlineData("100000", "#")]// Mensagem de erro
        [InlineData("99999", "#")]// Mensagem de sucesso
        [InlineData("99998", "#")]// Mensagem de sucesso
        [InlineData("1", "#")]// Mensagem de sucesso
        [InlineData("0", "#")]// Mensagem de erro
        [InlineData("-1", "#")]// Mensagem de erro
        public void Nove_DadoDescricaoContStringDeveExibirMensagem(string codigo,string menssagem)
        {
            //Arrange
            string descricao = "Descricao Valida";
            var instituicaoTelaCadastroPO = new InstituicaoTelaCadastroPO(driver);
            instituicaoTelaCadastroPO.visitar();
            instituicaoTelaCadastroPO.PreencheFormulario(codigo, descricao);
            //Action
            instituicaoTelaCadastroPO.SubimeteFormulario();
            //Assert
            Assert.Equal(menssagem, instituicaoTelaCadastroPO.getMensagemErro());
        }
        public void Onze_DadoInsercaoDeCaracteresInvalidosDeveExibirMensagemDeErro()
        {
            //Arrange
            var instituicaoTelaCadastroPO = new InstituicaoTelaCadastroPO(driver);
            instituicaoTelaCadastroPO.visitar();
            instituicaoTelaCadastroPO.PreencheFormulario("1", "Descrição Válida");
            //Action
            instituicaoTelaCadastroPO.SubimeteFormulario();
            //Assert
            Assert.Equal("#", instituicaoTelaCadastroPO.getMensagemErro());
        }
        [Fact]
        public void Doze_DadoInsercaoDeCaracteresInvalidosDeveExibirMensagemDeErro()
        {
            //Arrange
            var instituicaoTelaCadastroPO = new InstituicaoTelaCadastroPO(driver);
            //Action
            instituicaoTelaCadastroPO.cancelar();
            //Assert
            Assert.Equal(instituicaoTelaCadastroPO.getUrlCancel(), driver.Url.ToString());
        }
    }

}
