using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using First_Project_Stefanini.Application.DTO.Candidato;
using First_Project_Stefanini.Application.DTO.Paginacao;
using First_Project_Stefanini.Application.Interface;
using Frist_Project_Stefanini.Domain.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Frist_Project_Stefanini.Api.Controllers
{
    public class CandidatoController : BaseController<Candidato,
                                                      CandidatoRequest,
                                                      CandidatoResponse>
    {
        readonly protected ICandidatoAppService appCandidato;
        public CandidatoController(ICandidatoAppService app) : base(app)
        {
            appCandidato = app;
            appCandidato.Add(new CandidatoRequest() { 
                Nome = "thiado",
            });
        }
    }
}