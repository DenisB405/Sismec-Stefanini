using Frist_Project_Stefanini.ApplicarionCore.Entity;
using Frist_Project_Stefanini.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Frist_Project_Stefanini.ApplicarionCore.Interfaces.Services
{
    public interface IInstituicaoService : IService<Instituicao>
    {
        Instituicao SearchByCodigo(int codigo);
        Instituicao UpdateByCodigo(Instituicao instituicao);
        Instituicao DeleteByCodigo(int Codigo);
    }
}
