using ArzTiServer.Models;
using System.Collections.Generic;

namespace ArzTiServer.DataAccess
{
    public interface IHospitalAccessProvider
    {
        void AddPatientRecord(Patient patient);
        void UpdatePatientRecord(Patient patient);
        void DeletePatientRecord(string id);
        Patient GetPatientSingleRecord(string id);
        List<Patient> GetPatientRecords();
    }
}
