using System.Collections.Generic;
using System.Xml.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestMusicRecords.Controllers;
using RestMusicRecords.Model;

namespace UnitTestMusicRecord
{
    [TestClass]
    public class UnitTest1
    {
        private MusicRecordsController cntr = null;

        [TestInitialize]
        public void BeforeEachTest()
        {
            cntr = new MusicRecordsController();
        }

        [TestMethod]
        public void TestGetMethod()
        {
            // Arrange
            // BeforeEachTest

            List<Record> rList = new List<Record>(cntr.Get());

            Assert.AreEqual(4, rList.Count);
        }
    }
}
