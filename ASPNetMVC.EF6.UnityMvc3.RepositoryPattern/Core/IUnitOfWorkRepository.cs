using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNetMVC.EF6.UnityMvc3.RepositoryPattern.Core
{
    public interface IUnitOfWorkRepository
    {
        void Complete();
    }
}
