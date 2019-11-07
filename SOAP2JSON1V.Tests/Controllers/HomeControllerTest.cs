using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SOAP2JSON1V;
using SOAP2JSON1V.Controllers;

namespace SOAP2JSON1V.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Home Page", result.ViewBag.Title);
        }
    }
}
