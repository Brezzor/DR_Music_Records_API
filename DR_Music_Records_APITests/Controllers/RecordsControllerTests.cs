using Microsoft.VisualStudio.TestTools.UnitTesting;
using DR_Music_Records_API.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DR_Music_Records_API.Repositories;
using DR_Music_Records_API.Models;

namespace DR_Music_Records_API.Controllers.Tests
{
    [TestClass()]
    public class RecordsControllerTests
    {
        private RecordRepository? _recordRepository;

        [TestInitialize()]
        public void Init()
        {
            _recordRepository = new RecordRepository();
        }

        [TestMethod()]
        public void GetAllTest()
        {
            List<Record>? records = _recordRepository!.GetAll(null, null, null, null);
            Assert.IsNotNull(records);
            Assert.IsInstanceOfType(records, typeof(List<Record>));
            Assert.AreEqual(6, records!.Count);
        }

        [TestMethod()]
        public void GetAllWithFilterDuration()
        {
            //GetAll(Title, Artist, Duration, PublicationYear)
            List<Record>? records = _recordRepository!.GetAll(null, null, 42, null);
            Assert.IsNotNull(records);
            Assert.IsInstanceOfType(records, typeof(List<Record>));
            Assert.AreEqual(3, records!.Count);
        }

        [TestMethod()]
        public void GetAllWithFilterTitle()
        {
            //GetAll(Title, Artist, Duration, PublicationYear)
            string result = "21";
            List<Record>? records = _recordRepository!.GetAll("21", null, null, null);
            Assert.IsNotNull(records);
            Assert.IsInstanceOfType(records, typeof(List<Record>));
            Assert.AreEqual(1, records!.Count);
            Assert.AreEqual(result, records[0].title);
        }

        [TestMethod()]
        public void GetAllWithFilterArtist()
        {
            //GetAll(Title, Artist, Duration, PublicationYear)
            string result = "AC/DC";
            List<Record>? records = _recordRepository!.GetAll(null, "AC/DC", null, null);
            Assert.IsNotNull(records);
            Assert.IsInstanceOfType(records, typeof(List<Record>));
            Assert.AreEqual(1, records!.Count);
            Assert.AreEqual(result, records[0].artist);
        }

        [TestMethod()]
        public void GetAllWithFilterPublicationYear()
        {
            //GetAll(Title, Artist, Duration, PublicationYear)
            List<Record>? records = _recordRepository!.GetAll(null, null, null, 1973);
            Assert.IsNotNull(records);
            Assert.IsInstanceOfType(records, typeof(List<Record>));
            Assert.AreEqual(1, records!.Count);
        }

        [TestMethod()]
        public void PutTest()
        {

        }

        [TestMethod()]
        public void DeleteTest()
        {

        }

        [TestCleanup()]
        public void Cleanup() 
        {
            _recordRepository = null;
        }
    }
}