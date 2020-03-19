using AutoMapper;
using First_Project_Stefanini.Application.DTO.Instituicao;
using Frist_Project_Stefanini.ApplicarionCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace First_Project_Stefanini.Application.Mapper
{
    public class MappingEntidade : Profile
    {
        public MappingEntidade()
        {
            CreateMap<InstituicaoRequest, Instituicao>();
            CreateMap<Instituicao, InstituicaoResponse>();
        }
    }
}
