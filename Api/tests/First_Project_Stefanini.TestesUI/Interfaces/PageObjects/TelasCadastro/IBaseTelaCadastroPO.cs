using System;
using System.Collections.Generic;
using System.Text;

namespace First_Project_Stefanini.TestesUI.Interfaces.PageObjects.TelasCadastro
{
    public interface IBaseTelaCadastroPO
    {
        public void visitar();
        public void voltar();
        public void SubimeteFormulario();
        public void cancelar();
        public string getUrlCancel();
        public string getMensagemErro();


    }
}
