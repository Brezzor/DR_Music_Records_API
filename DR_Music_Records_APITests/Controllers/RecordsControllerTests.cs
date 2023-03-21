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
        public void GetAll()
        {
            List<Record>? records = _recordRepository!.GetAll();
            Assert.IsNotNull(records);
            Assert.IsInstanceOfType(records, typeof(List<Record>));
            Assert.AreEqual(6, records!.Count);
        }

        [TestMethod()]
        public void GetTest1()
        {

        }

        [TestMethod()]
        public void PostTest()
        {

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