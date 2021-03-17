
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
        }
}
