using System;
using gta;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace tric
{
    [TestClass]
    public class GivenARabbit
    {
    
        [TestMethod][ExpectedException(typeof(NullReferenceException))]
        public void WhenPassingNull_RabbitFailFast()
        {
            IMagical rabbit = new Rabbit(null);
            
        }

        [TestMethod]
        public void ItNeedsAName_AndSouldBeObligatory()
        {
            var name = "Mr. Jumps";
            IMagical rabbit = new Rabbit(name);
            
            Assert.AreEqual(name, rabbit.Name);
        }

        [TestMethod]
        public void WhenTwoRabbitsHasTheSameNames_TheyShouldBeEquals()
        {
            string name = "Joker";
            IMagical rabbit = new Rabbit(name);
            IMagical anotherRabbit = new Rabbit(name);

            Assert.AreEqual(rabbit, anotherRabbit);
        }

        [TestMethod]
        public void WhenTwoRabbitsHasDifferentNames_TheyShouldBeNotEquals()
        {
            string name = "Mr. Jumps";
            Rabbit rabbit = new Rabbit(name);
            Rabbit anotheRabbit = new Rabbit(name+" 2");

            Assert.AreNotEqual(rabbit, anotheRabbit);
        }
    }
}
