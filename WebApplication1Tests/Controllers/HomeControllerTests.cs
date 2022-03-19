using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication1.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers.Tests
{
    [TestClass()]
    public class HomeControllerTests
    {
        private readonly HomeController _controller;
        public HomeControllerTests()
        {
            _controller = new HomeController(null);
        }
        [TestMethod()]
        public void IndexTest()
        {
            var result = _controller.Index();
            Assert.IsInstanceOfType(result, typeof(ViewResult));
        }

        [TestMethod()]
        public void WaitTest()
        {
            var result = _controller.Wait();
            Assert.IsInstanceOfType(result, typeof(ViewResult));
        }

        [TestMethod()]
        public void PrivacyTest()
        {
            var result = _controller.Privacy();
            Assert.IsInstanceOfType(result, typeof(ViewResult));
        }

        [TestMethod()]
        public void ErrorTest()
        {
            var result = _controller.Error();
            Assert.Fail();
        }
    }
}