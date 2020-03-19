using First_Project_Stefanini.Structure.Data;
using Frist_Project_Stefanini.ApplicarionCore.Entity;
using Frist_Project_Stefanini.ApplicarionCore.Interfaces;
using System.Linq;

namespace First_Project_Stefanini.Structure.Repository
{
    public class InstituicaoRepository : Repository<Instituicao>, IInstituicaoRepository
    {
        InstituicaoContext dbContext;
        public InstituicaoRepository(InstituicaoContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }

        public Instituicao SearchByCodigo(int codigo)
        {
            var lista = base.GetAll();
            foreach(var instituicao in lista){
                if (instituicao.Codigo == codigo)
                    return instituicao;
            }
            return null;
        }
    }
}
