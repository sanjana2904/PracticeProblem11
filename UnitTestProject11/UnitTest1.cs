
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PracticeProblem11;

namespace UnitTestProject11
{
    [TestClass]
    public class UnitTest1
    {
            [TestMethod]
            public void TestFirstName()
            {
                Program program = new Program();
                bool result = program.validateName("Sanjana");
                Assert.AreEqual(true, result);
            }
            public void TestInvalidFirstName()
            {
                Program program = new Program();
                bool result = program.validateName("sanjana");
                Assert.AreEqual(false, result);
            }
        [TestMethod]
        public void TestEmailName()
        {
            Program program = new Program();
            bool result = program.validateEmail("sanju@gmail.com");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestInValidEmailName()
        {
            Program program = new Program();
            bool result = program.validateEmail("sanjugmail.com");
            Assert.AreEqual(false, result);
        }
        [TestMethod]
        public void TestValidPhoneNumber()
        {
            Program program = new Program();
            bool result = program.validatePhoneNumber("91 7708796223");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestInValidPhoneNumber()
        {
            Program program = new Program();
            bool result = program.validatePhoneNumber("917708796223");
            Assert.AreEqual(false, result);
        }
        [TestMethod]
        public void TestValidPassword()
        {
            Program program = new Program();
            bool result = program.validatePassword("sanjanaks");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestInValidPassword()
        {
            Program program = new Program();
            bool result = program.validatePassword("sanjana");
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void TestValidUppercase()
        {
            Program program = new Program();
            bool result = program.validateUppercase("saNjanaks");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestInValidUppercase()
        {
            Program program = new Program();
            bool result = program.validateUppercase("sanjana");
            Assert.AreEqual(false, result);
        }
        [TestMethod]
        public void TestValidNumericcase()
        {
            Program program = new Program();
            bool result = program.validateNumericcase("sanjana5Ks");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestInValidNumericcase()
        {
            Program program = new Program();
            bool result = program.validateNumericcase("sanjana5ks");
            Assert.AreEqual(false, result);
        }
        [TestMethod]
        public void TestValidSpecialCharactercase()
        {
            Program program = new Program();
            bool result = program.validateSpecialCharactercase("sanJana5*ks");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestInValidSpecialCharactercase()
        {
            Program program = new Program();
            bool result = program.validateSpecialCharactercase("sanJana5Ks");
            Assert.AreEqual(false, result);
        }
    }
}
