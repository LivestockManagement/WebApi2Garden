using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApi2Garden.Controllers;
using WebApi2Garden.Services;
using WebApi2Garden.Models;

namespace WebApiTestGarden.Tests.Controllers
{
    [TestClass]
    public class ErpControllerTest
    {
        private ErpService _ErpService;
        private ErpController _ErpController;
        [TestInitialize]
        public void Init()
        {
            _ErpService = new ErpService();
            _ErpController = new ErpController(_ErpService);
        }

        [TestMethod]
        public void Get()
        {
            // Arrange

            // Act
            IEnumerable<ErpModel> result = _ErpController.Get();

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GetById()
        {
            // Arrange

            // Act
            ErpModel result = _ErpController.Get(1);

            // Assert
            Assert.AreEqual("Erp Description 1", result.Description);
        }

        [TestMethod]
        public void Post()
        {
            // Arrange

            // Act
            _ErpController.Post("value");

            // Assert
        }

        [TestMethod]
        public void Put()
        {
            // Arrange

            // Act
            _ErpController.Put(5, "value");

            // Assert
        }

        [TestMethod]
        public void Delete()
        {
            // Arrange
            

            // Act
            _ErpController.Delete(5);

            // Assert
        }
    }
}
