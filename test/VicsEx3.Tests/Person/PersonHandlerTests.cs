using System.ComponentModel.DataAnnotations;
using System;
using Xunit;

namespace VicsEx3
{
    public class PersonHandlerTests
    {
        private const string F_NAME = "Zaphod";
        private const string L_NAME = "Beeblebrox";
        private const int PRESUMED_AGE = 120;
        private const double HEIGHT = 180;
        private const double WEIGHT = 80;
        
        private PersonHandler ph;
        private Person p1;

        public PersonHandlerTests()
        {
            ph = new PersonHandler();
            p1 = ph.CreatePerson(F_NAME, L_NAME, PRESUMED_AGE, HEIGHT, WEIGHT);
        }
        [Fact]
        public void NormalCreationTest()
        {
            Assert.Equal(F_NAME, p1.FName);
            Assert.Equal(L_NAME, p1.LName);
            Assert.Equal(F_NAME + " " + L_NAME, ph.GetName(p1));
            Assert.Equal(PRESUMED_AGE, ph.GetAge(p1));
            Assert.Equal(HEIGHT, ph.GetHeight(p1), 6);
            Assert.Equal(WEIGHT, ph.GetWeight(p1), 6);
        }

        [Fact]
        public void SetNameTest()
        {
            ph.SetFirstName(p1, "Ford");
            ph.SetLastName(p1, "Prefect");
            Assert.Equal("Ford Prefect", ph.GetName(p1));
        }

        [Fact]
        public void SetAgeTest()
        {
            ph.SetAge(p1, 210);
            Assert.Equal(210, ph.GetAge(p1));
        }

        [Fact]
        public void SetHeightTest()
        {
            ph.SetHeight(p1, 240);
            Assert.Equal(240, ph.GetHeight(p1));
        }

        [Fact]
        public void SetWeightTest()
        {
            ph.SetWeight(p1, 240);
            Assert.Equal(240, ph.GetWeight(p1));
        }
        
    }
}