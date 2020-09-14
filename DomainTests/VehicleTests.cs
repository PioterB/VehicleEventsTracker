using Domain;
using NUnit.Framework;

namespace DomainTests
{
    public class VehicleTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Ctor_ValidAgruments_PropertiesAssigned()
        {
            var vehicle = new Vehicle("make", "model", "name");

            Assert.AreEqual("make", vehicle.Make, "value given to ctor is not reflected");
            Assert.AreEqual("model", vehicle.Model);
            Assert.AreEqual("name", vehicle.Name);
        }
    }
}