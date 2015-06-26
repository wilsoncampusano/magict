using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gta;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace tric
{
    [TestClass]
    class CardTest
    {
        [TestMethod]
        public void CanCreateOne()
        {
            IMagical card = new Card("Joker");
            Assert.IsNotNull(card);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void WhenPassingNull_CardtFailFast()
        {
            IMagical card = new Card(null);

        }

        [TestMethod]
        public void ItNeedsAName_AndSouldBeObligatory()
        {
            var name = "Joker";
            IMagical card = new Card(name);

            Assert.AreEqual(name, card.Name);
        }

        [TestMethod]
        public void WhenTwoCardHasTheSameNames_TheyShouldBeEquals()
        {
            string name = "Joker";
            Card card = new Card(name);
            Card anotherCard = new Card(name );

            Assert.AreEqual(card, anotherCard);
        }

        [TestMethod]
        public void WhenTwoCardsHasDifferentNames_TheyShouldBeNotEquals()
        {
            string name = "Mr. Jumps";
            Rabbit rabbit = new Rabbit(name);
            Rabbit anotheRabbit = new Rabbit(name + " 2");

            Assert.AreNotEqual(rabbit, anotheRabbit);
        }
    }
}
