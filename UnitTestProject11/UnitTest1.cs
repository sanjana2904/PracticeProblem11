
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
    }
}
