using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;
using Microsoft.AspNetCore.Mvc.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestMusicRecords.Controllers;
using RestMusicRecords.Model;

namespace UnitTestMusicRecord
{
    [TestClass]
    public class UnitTest1
    {
        public MusicRecordsController cntr = new MusicRecordsController();

        [TestInitialize]

        [TestMethod]
        public void TestGetMethod()
        {
            // Arrange
            // BeforeEachTest

            List<Record> rList = new List<Record>(cntr.Get());

            Assert.AreEqual(4, rList.Count);
        }

        [TestMethod]
        public void TestMethod1Task2()
        {
            // Arrange
            // BeforeEachTest

            Assert.AreEqual(cntr.GetFromSubstring("I'm still standing").Count(),1);

        }

        [TestMethod]
        public void TestMethod2Task2()
        {
            // Arrange
            // BeforeEachTest

            List<Record> rList = new List<Record>(cntr.Get());

            Assert.AreEqual(4, rList.Count);
        }
    }
}
