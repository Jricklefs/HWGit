using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HellowWolrdAPI.IRepository
{
 public   interface IUnitOfWork 
    {
        IMessages Msgs{ get ; set; }

    }
}
