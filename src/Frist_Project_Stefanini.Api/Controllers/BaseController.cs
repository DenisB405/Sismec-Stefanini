using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using First_Project_Stefanini.Application.DTO;
using First_Project_Stefanini.Application.Interface;
using Frist_Project_Stefanini.ApplicarionCore.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Frist_Project_Stefanini.Api.Controllers
{
    [ApiController]
    [Route("{controller}/{action}")]
    public class BaseController<TEntity, TEntityRequest, TEntityResponse> : ControllerBase
        where TEntity : EntityBase
        where TEntityRequest : EntidadeRequestBase
        where TEntityResponse : EntidadeResponseBase
    {
        readonly protected IAppServiceBase<TEntity, 
            TEntityRequest, TEntityResponse> app;

        public BaseController(IAppServiceBase<TEntity, TEntityRequest, TEntityResponse> app)
        {
            this.app = app;
        }

        [HttpPost]
        public ActionResult add([FromBody] TEntityRequest dado)
        {
            var response = app.Add(dado);
            if (response != null)
                return Ok();
            else
                return BadRequest(400);
        }
    }
}