using First_Project_Stefanini.Structure.Repository;
using Frist_Project_Stefanini.Domain.Entity;
using Frist_Project_Stefanini.Domain.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace First_Project_Stefanini.Structure.Data.Repository
{
    public class CandidatoRepository :Repository<Candidato>,ICandidatoRepository
    {
        InstituicaoContext dbcontext;

        public CandidatoRepository(InstituicaoContext dbContext): base(dbContext)
        {
            this.dbcontext = dbContext;
        }
    }
}
