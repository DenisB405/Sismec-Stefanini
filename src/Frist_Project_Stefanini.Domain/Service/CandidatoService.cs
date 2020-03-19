using Frist_Project_Stefanini.Domain.Entity;
using Frist_Project_Stefanini.Domain.Interfaces.Repository;
using Frist_Project_Stefanini.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Frist_Project_Stefanini.Domain.Service
{
    public class CandidatoService : Service<Candidato>, ICandidatoService
    {
        private readonly ICandidatoRepository candidatoRepository;
        public CandidatoService(ICandidatoRepository iRepository) : base(iRepository)
        {
            candidatoRepository = iRepository;
        }
    }
}
