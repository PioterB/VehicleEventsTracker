using Domain;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using WebApi.Controllers;

namespace WebApiTests
{
    public class VehiclesControllerTests
    {
        private Mock<IVehicleRepository> _repository;
        VehiclesController _unitUnderTest;

        [SetUp]
        public void Setup()
        {
            _repository = new Mock<IVehicleRepository>();
            _unitUnderTest = new VehiclesController(_repository.Object);
        }

        [Test]
        [TestCase(5, true)]
        [TestCase(6, false)]
        [TestCase(7, false)]
        [TestCase(8, false)]
        [TestCase(9, false)]
        public void Get_ExisingId_OkRespose(int idOfVehicle, bool isThere)
        {
            _repository.Setup(r => r.Get(5)).Returns(new Vehicle("x", "x", "x"));

            var result = _unitUnderTest.Get(5);
            
            Assert.AreEqual(isThere, typeof(OkObjectResult).IsInstanceOfType(result));
        }


        [Test]
        public void Get_NonExisingId_NotFoundRespose()
        {
            var result = _unitUnderTest.Get(5);

            Assert.IsInstanceOf(typeof(NotFoundResult), result);
        }
    }
}