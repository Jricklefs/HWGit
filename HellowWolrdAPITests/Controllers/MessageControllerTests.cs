using Microsoft.VisualStudio.TestTools.UnitTesting;
using HellowWolrdAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Text;
using HellowWolrdAPI.IRepository;
using HellowWolrdAPI.Repository;
using HellowWolrdAPITests.Fake_Object;

namespace HellowWolrdAPI.Controllers.Tests
{
    [TestClass()]
    public class MessageControllerTests
    {
        



        [TestMethod()]
        public void SayHelloWorldTest()
        {
            //Kinda hard to 
            IUnitOfWork uow = new UnitOfWork();
            IMessages msg = new fkMessageObject();
            

            Assert.AreEqual(msg.SayHelloWorld() , "Hello World");
            
        }
    }
}