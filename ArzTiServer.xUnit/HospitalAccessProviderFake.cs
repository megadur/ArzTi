using ArzTiServer.DataAccess;
using ArzTiServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace ArzTiServer.xUnit
{
    public class HospitalAccessProviderFake : IHospitalAccessProvider
    {
        private readonly List<Patient> _patients;

        public HospitalAccessProviderFake()
        {
            _patients = new List<Patient>()
            {
            new Patient("id1", "PatientOne", "address1", "city1", 11, "gender1"),
            new Patient("id2", "PatientTwo", "address2", "city2", 12, "gender2"),
            new Patient("id3", "PatientTree", "address3", "city3", 13, "gender3")
            };
        }


        public void AddPatientRecord(Patient patient)
        {
            patient.Id = Guid.NewGuid().ToString();
            _patients.Add(patient);
         }

        public void DeletePatientRecord(string id)
        {
            var existing = _patients.First(a => a.Id == id);
            _patients.Remove(existing);

        }

        public List<Patient> GetPatientRecords()
        {
            return _patients;
        }

        public Patient GetPatientSingleRecord(string id)
        {
            return _patients.Where(a => a.Id == id).FirstOrDefault();

        }


        public void UpdatePatientRecord(Patient patient)
        {
            Patient p=_patients.Where(a => a.Id == patient.Id).FirstOrDefault();
            p.Address = patient.Address;
            p.Age = patient.Age;
            p.City = patient.Gender;
            p.Name = patient.Name;
        }
    }
}
