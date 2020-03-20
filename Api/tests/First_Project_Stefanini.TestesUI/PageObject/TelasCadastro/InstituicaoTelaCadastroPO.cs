using First_Project_Stefanini.TestesUI.Interfaces.PageObjects.TelasCadastro;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace First_Project_Stefanini.TestesUI.PageObject.TelasCadastro
{
    public class InstituicaoTelaCadastroPO : BaseTelaCadastroPO, IInstituicaoTelaCadastroPO
    {
        private By ByInputCodigo;
        private By ByInputDescricao;

        public InstituicaoTelaCadastroPO(IWebDriver driver) : base(driver)
        {
            urlGo = "http://localhost:4200/Instituicao";
            urlBack = "http://localhost:4200/Home";
            ByInputBottonCadastrar = By.Id("button-cadastro");
            ByInputBottonCancel = By.Id("button-cancelar");
            BySpanErroMensagem = By.Id("#");
            ByInputCodigo = By.Id("idInstituicao");
            ByInputDescricao = By.Id("nomeInstituicao");
        }

        public void PreencheFormulario(string codigo, string descricao)
        {
            Driver.FindElement(ByInputCodigo).SendKeys(codigo);
            Driver.FindElement(ByInputDescricao).SendKeys(descricao);
        }
    }
}
