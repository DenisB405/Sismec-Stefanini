using AutoMapper;
using First_Project_Stefanini.Application.DTO.Candidato;
using First_Project_Stefanini.Application.Interface;
using Frist_Project_Stefanini.Domain.Entity;
using Frist_Project_Stefanini.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace First_Project_Stefanini.Application.AppService
{
    public class CandidatoAppService : AppServiceBase<Candidato, CandidatoRequest, CandidatoResponse>, ICandidatoAppService
    {
        public CandidatoAppService(IService<Candidato> servico, IMapper iMapper) : base(servico, iMapper)
        {
        }
    }
}
