using Frist_Project_Stefanini.ApplicarionCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Frist_Project_Stefanini.ApplicarionCore.Interfaces
{
    public interface IInstituicaoRepository : IRepository<Instituicao>
    {
        Instituicao SearchByCodigo(int codigo);
        Instituicao UpdateByCodigo(Instituicao instituicao);
        Instituicao DeleteByCodigo(int Codigo);
    }


}
