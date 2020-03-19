using First_Project_Stefanini.TestesUI.Interfaces.PageObjects.TelasCadastro;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace First_Project_Stefanini.TestesUI.PageObject.TelasCadastro
{
    public abstract class BaseTelaCadastroPO : IBaseTelaCadastroPO
    {
        protected IWebDriver Driver;
        protected By ByInputBottonCancel;
        protected By ByInputBottonCadastrar;
        protected By BySpanErroMensagem;
        protected string urlGo;
        protected string urlBack;
        public BaseTelaCadastroPO(IWebDriver driver)
        {
            Driver = driver;
        }

        public void visitar()
        {
            Driver.Navigate().GoToUrl(urlGo);
        }
        public void voltar()
        {
            Driver.Navigate().GoToUrl(urlBack);
        }
        public void SubimeteFormulario()
        {
            Driver.FindElement(ByInputBottonCadastrar).Submit();

        }
        public void cancelar()
        {
            Driver.FindElement(ByInputBottonCancel).Submit();
        }
        public string getMensagemErro()
        {
            BySpanErroMensagem = By.ClassName("alert");
            return Driver.FindElement(BySpanErroMensagem).Text;
        }

        public string getUrlCancel()
        {
            return urlBack;
        }
    }
}
