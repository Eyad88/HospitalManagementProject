using Microsoft.VisualStudio.TestTools.UnitTesting;
using HospitalManagementSystem.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalManagementSystem.Models;

namespace HospitalManagementSystem.Repositories.Tests
{
    [TestClass()]
    public class HospitalRepositoryTests
    {
        [TestMethod()]
        public void GetPatinetFromDatabaseTest()
        {
            HospitalRepository db = new HospitalRepository();
            string testPatinetsFirstName = "Apple";
            IEnumerable<Patient> patient = db.GetPatinetFromDatabase(testPatinetsFirstName);

           // Assert.AreEqual(2, patient.Count());
            Assert.AreEqual("Apple", patient.First().FirstName);

        }
    }
}