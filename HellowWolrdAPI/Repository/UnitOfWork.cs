using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HellowWolrdAPI.IRepository;

namespace HellowWolrdAPI.Repository
{
    
    public class UnitOfWork :IUnitOfWork
    {
        //Stub in DataContext later. 
        // private readonly ApplicationDatacontext...
        
        public UnitOfWork()
        {
            //Other Repos
            Msgs = new Messages();

        }

        //Other Repo Interfaces 
        public IMessages Msgs { get; set; }
       


    }
}
