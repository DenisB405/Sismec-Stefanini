using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using First_Project_Stefanini.Application.AppService;
using First_Project_Stefanini.Application.DTO.Instituicao;
using First_Project_Stefanini.Application.Interface;
using Frist_Project_Stefanini.ApplicarionCore.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Frist_Project_Stefanini.Api.Controllers
{
    public class InstituicaoController : BaseController<Instituicao,
        InstituicaoRequest, InstituicaoResponse>
    {
        readonly protected IInstituicaoAppService appInstituicao;
        public InstituicaoController(IInstituicaoAppService app) : base(app)
        {
            appInstituicao = app;
        }
    }
}