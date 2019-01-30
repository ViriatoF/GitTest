using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestOnGit;

namespace UnitTestOnGit
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCreationPerson_Ok()
        {
            Person PersonTest = new Person(425, "Pork", "Floyd", 25, "12 rue de la gare");
            const string V = "Pork";
            Assert.AreEqual(PersonTest, PersonTest.Nom == V);
        }
    }
}
