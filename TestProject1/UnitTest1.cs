using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonDataManagement;
using System.Collections.Generic;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        List<Person> list = new List<Person>();
        [TestMethod]
        public void TestMethodForRetrieveTopTwoLessThan60()
        {
            ///AAA Method
            bool expected = true;
            var actual= PersonData.RetrieveTopTwoLessThan60(list);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethodForRetrieveTeenageRecords()
        {
            ///AAA Method
            bool expected = true;
            var actual = PersonData.RetrieveTeenageRecords(list);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethodForCalculateAverageAge()
        {
            ///AAA Method
            bool expected = true;
            var actual = PersonData.CalculateAverageAge(list);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethodForSearchingSpecificName()
        {
            ///AAA Method
            bool expected = true;
            var actual = PersonData.SearchingSpecificName(list,"Arun");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethodForSkipRecordLessThan60()
        {
            ///AAA Method
            bool expected = true;
            var actual = PersonData.SkipRecordLessThan60(list);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethodForRemoveSpecificName()
        {
            ///AAA Method
            bool expected = true;
            var actual = PersonData.RemoveSpecificName(list,"Radhika");
            Assert.AreEqual(expected, actual);
        }
    }
}
