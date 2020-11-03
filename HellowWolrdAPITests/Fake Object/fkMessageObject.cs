using System;
using System.Collections.Generic;
using System.Text;
using HellowWolrdAPI.IRepository;


namespace HellowWolrdAPITests.Fake_Object
{
   public  class fkMessageObject : IMessages
   {
       public string SayHelloWorld() => "Hello World";


   }
}
