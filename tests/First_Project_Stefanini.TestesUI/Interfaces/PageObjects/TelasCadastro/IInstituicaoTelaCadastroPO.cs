using System;
using System.Collections.Generic;
using System.Text;

namespace First_Project_Stefanini.TestesUI.Interfaces.PageObjects.TelasCadastro
{
    public interface IInstituicaoTelaCadastroPO : IBaseTelaCadastroPO
    {
        public void PreencheFormulario(string codigo, string descricao);
    }
}
