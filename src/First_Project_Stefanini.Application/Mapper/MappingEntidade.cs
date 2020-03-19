using AutoMapper;
using First_Project_Stefanini.Application.DTO.Candidato;
using First_Project_Stefanini.Application.DTO.Instituicao;
using Frist_Project_Stefanini.ApplicarionCore.Entity;
using Frist_Project_Stefanini.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace First_Project_Stefanini.Application.Mapper
{
    public class MappingEntidade : Profile
    {
        public MappingEntidade()
        {
            //Instituicao
            CreateMap<InstituicaoRequest, Instituicao>();
            CreateMap<Instituicao, InstituicaoResponse>();

            //Candidato
            CreateMap<CandidatoRequest, Candidato>();
            CreateMap<Candidato, CandidatoResponse>();
        }
    }
}
