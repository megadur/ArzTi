using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ArzTiServer.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ArzTiServer.DataAccess.Tests
{
    [TestClass()]
    public class HospitalAccessProviderTests
    {
        [TestMethod()]
        public void Add_Patients_Test()
        {
            var options = new DbContextOptionsBuilder<HospitalDbContext>()
                .UseInMemoryDatabase(databaseName: "PatientsDatabase")
                .Options;

            // Use a clean instance of the context to run the test
            using (var context = new HospitalDbContext(options))
            {
                HospitalAccessProvider dap = new HospitalAccessProvider(context);
                dap.AddPatientRecord(new Patient { Id = "1", Name = "Patient 1", Address = "Address 1", City = "City  1", Age = 11, Gender = "m" });
            }


            // Insert seed data into the database using one instance of the context
            using (var context = new HospitalDbContext(options))
            {
                var item = context.Set<Patient>().Single(e => e.Name == "Patient 1");

                Assert.AreEqual("Patient 1", item.Name);
            }

        }

        [TestMethod()]
        public void GetAll_Patients_Test()
        {
            var options = new DbContextOptionsBuilder<HospitalDbContext>()
                .UseInMemoryDatabase(databaseName: "PatientsDatabase")
                .Options;

            // Insert seed data into the database using one instance of the context
            using (var context = new HospitalDbContext(options))
            {
                context.Patients.Add(new Patient { Id = "1", Name = "Patient 1", Address = "Address 1", City = "City  1", Age = 11, Gender = "m" });
                context.Patients.Add(new Patient { Id = "2", Name = "Patient 2", Address = "Address 2", City = "City  2", Age = 12, Gender = "m" });
                context.Patients.Add(new Patient { Id = "3", Name = "Patient 3", Address = "Address 3", City = "City  3", Age = 13, Gender = "m" });
                context.SaveChanges();
            }

            // Use a clean instance of the context to run the test
            using (var context = new HospitalDbContext(options))
            {
                HospitalAccessProvider dap = new HospitalAccessProvider(context);
                List<Patient> patients = dap.GetPatientRecords();

                Assert.AreEqual(3, patients.Count);
            }
        }
    }
}