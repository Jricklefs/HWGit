using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HellowWolrdAPI.IRepository;

namespace HellowWolrdAPI.Repository
{
    public class Messages : IMessages
    {
        public string SayHelloWorld()
        {
            return "Hello World";
        }
    }
}
