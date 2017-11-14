using ASPNetMVC.EF6.UnityMvc3.RepositoryPattern.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;

namespace ASPNetMVC.EF6.UnityMvc3.RepositoryPattern.Presistance
{
    public class UnitOfWorkRepository : IUnitOfWorkRepository
    {
        private readonly ApplicationDbContext context;

        public UnitOfWorkRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public void Complete()
        {
            context.SaveChanges();
        }
    }
}