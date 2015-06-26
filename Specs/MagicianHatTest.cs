using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Security.Authentication;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using gta;

namespace tric
{
    [TestClass]
    public class AMagiciaHat
    {
        public HatBase _simpleHat { get; set; }

        private void AssertCanTakeManyRabbits()
        {
            for (int i = 0; i < 20; i++)
            {
                Assert.IsNotNull(_simpleHat.Shazaam());
                Assert.IsNotNull(_simpleHat.Shazaam());
                Assert.IsNotNull(_simpleHat.Shazaam());
                Assert.IsNotNull(_simpleHat.Shazaam());
                Assert.IsNotNull(_simpleHat.Shazaam());
                Assert.IsNotNull(_simpleHat.Shazaam());
                Assert.IsNotNull(_simpleHat.Shazaam());
            }
        }

        private void CanTakeTheSameMagicalFromHat(IMagical aCard)
        {
            Assert.AreSame(aCard, _simpleHat.Shazaam());
        }

        [TestInitialize]
        public void SetUp()
        {
             _simpleHat = new SimpleHat();
        }


        [TestMethod]
        public void CanSaveARabbitInIt_AndRetriveIt()
        {
            IMagical aRabbit = new Rabbit("Mr. Jumps");
            _simpleHat.PutIn(aRabbit);
            Assert.AreSame(aRabbit, _simpleHat.Shazaam());
        }

        [TestMethod][ExpectedExceptionAttribute(typeof(NullReferenceException))]
        public void CannotPutANullReferenceInIt()
        {
            _simpleHat.PutIn(null);
            Assert.IsNotNull(_simpleHat.Shazaam());
        }

        [TestMethod]
        public void CanSaveMoreThanOneRabbitAndRetrieveThem()
        {
            new List<int> { 1, 1, 3 }.ForEach(n => _simpleHat.PutIn(new Rabbit("Mr. Jumps "+n)));
            Assert.AreEqual(3, _simpleHat.RabbitsInHat());

            new List<int> { 1, 1, 3 }.ForEach(n => _simpleHat.PutIn(new Rabbit("Mr. Jumps "+ n)));
            Assert.AreEqual(6, _simpleHat.RabbitsInHat() );
        }

        [TestMethod]
        public void CanSaveCards_ThenRetrieveThem()
        {
            IMagical aCard = new Card("Joker");
            _simpleHat.PutIn(aCard);
            CanTakeTheSameMagicalFromHat(aCard);
        }

        [TestMethod]
        public void CanPutACardAndARabbit_ThenCanGetTheTwo()
        {
            IMagical aCard = new Card("Joker");
            IMagical aRabbit = new Rabbit("Mr. Jumps");
            
            _simpleHat.PutIn(aCard);
            _simpleHat.PutIn(aRabbit);

            List<IMagical> magicals = new List<IMagical>();
            magicals.Add(_simpleHat.Shazaam());
            magicals.Add(_simpleHat.Shazaam());
            
            if (!(magicals.Contains(aCard) && magicals.Contains(aRabbit)))
                Assert.Fail();

        }

        [TestMethod]
        public void WhenTheHatIsTouchedByAMagicStick_TheHatCanGiveYouRabbits()
        {
            MagicStick magicStick = new MagicStick();
            _simpleHat  = magicStick.TurnMagical(_simpleHat);
            AssertCanTakeManyRabbits();
        }
    }

}