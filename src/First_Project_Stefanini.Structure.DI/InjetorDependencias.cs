using First_Project_Stefanini.Application.AppService;
using First_Project_Stefanini.Application.Interface;
using First_Project_Stefanini.Structure.Repository;
using Frist_Project_Stefanini.ApplicarionCore.Interfaces;
using Frist_Project_Stefanini.ApplicarionCore.Interfaces.Services;
using Frist_Project_Stefanini.ApplicarionCore.Service;
using Frist_Project_Stefanini.Domain.Interfaces.Services;
using Frist_Project_Stefanini.Domain.Service;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace First_Project_Stefanini.Structure.DI
{
    public class InjetorDependencias
    {
        public static void Registra(IServiceCollection svcCollection)
        {
            //Application
            svcCollection.AddScoped(typeof(IAppServiceBase<,,>),typeof(AppServiceBase<,,>));
            svcCollection.AddScoped(typeof(IInstituicaoAppService), typeof(InstituicaoAppService));

            //Dominio
            svcCollection.AddScoped(typeof(IService<>), typeof(Service<>));
            svcCollection.AddScoped(typeof(IInstituicaoService), typeof(InstituicaoService));
            
            //Structure
            svcCollection.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            svcCollection.AddScoped(typeof(IInstituicaoRepository), typeof(InstituicaoRepository));
        }
    }
}
