using System;
using Xunit;

namespace VicsEx3.Tests
{
    public class PersonTests
    {
        [Fact]
        public void TestNormalCreation3ArgConstructor()
        {
            var p1 = new Person("Arthur", "Dent", 36);
            
            Assert.Equal("Arthur", p1.FName);
            Assert.Equal("Dent", p1.LName);
            Assert.Equal(36, p1.Age);
            Assert.Equal(0.0, p1.Height);
            Assert.Equal(0.0, p1.Weight);
        }

        [Fact]
        public void TestNormalCreation5ArgConstructor()
        {
            var p1 = new Person("Arthur", "Dent", 36, 175, 70);
            
            Assert.Equal("Arthur", p1.FName);
            Assert.Equal("Dent", p1.LName);
            Assert.Equal(36, p1.Age);
            Assert.Equal(175.0, p1.Height, 6);
            Assert.Equal(70.0, p1.Weight, 6);
        }

        [Fact]
        public void TestTooShortFNameConstructor()
        {
            var ex = Assert.Throws<ArgumentException>(() => new Person("a", "Dent", 36));
            Assert.Contains("must be between 2 and 10 characters long", ex.Message);
        }

        [Fact]
        public void TestTooLongFNameConstructor()
        {
            var ex = Assert.Throws<ArgumentException>(() => new Person("ABcDefghijK", "Dent", 36));
            Assert.Contains("must be between 2 and 10 characters long", ex.Message);
        }

        [Fact]
        public void TestTooShortLNameConstructor()
        {
            var ex = Assert.Throws<ArgumentException>(() => new Person("Zaphod", "Bb", 36));
            Assert.Contains("must be between 3 and 15 characters long", ex.Message);
        }

        [Fact]
        public void TestTooLongLNameConstructor()
        {
            var ex = Assert.Throws<ArgumentException>(() => new Person("Zaphod", "Beeblebrox123456", 36));
            Assert.Contains("must be between 3 and 15 characters long", ex.Message);
        }

        [Fact]
        public void TestZeroAgeConstructor()
        {
            var ex = Assert.Throws<ArgumentException>(() => new Person("Zaphod", "Beeblebrox", 0));
            Assert.Contains("must be greater than 0", ex.Message);
        }

        [Fact]
        public void TestNegativeAgeConstructor()
        {
            var ex = Assert.Throws<ArgumentException>(() => new Person("Ford", "Prefect", -100));
            Assert.Contains("must be greater than 0", ex.Message);
        }
    }
}
