using ArzTiServer.Models;
using System.Collections.Generic;
using System.Linq;

namespace ArzTiServer.DataAccess
{
    public class HospitalAccessProvider: IHospitalAccessProvider
    {
        private readonly HospitalDbContext _context;

        public HospitalAccessProvider(HospitalDbContext context)
        {
            _context = context;
        }

        public void AddPatientRecord(Patient patient)
        {
            _context.Patients.Add(patient);
            _context.SaveChanges();
        }

        public void UpdatePatientRecord(Patient patient)
        {
            _context.Patients.Update(patient);
            _context.SaveChanges();
        }

        public void DeletePatientRecord(string id)
        {
            var entity = _context.Patients.FirstOrDefault(t => t.Id == id);
            _context.Patients.Remove(entity);
            _context.SaveChanges();
        }

        public Patient GetPatientSingleRecord(string id)
        {
            return _context.Patients.FirstOrDefault(t => t.Id == id);
        }

        public List<Patient> GetPatientRecords()
        {
            return _context.Patients.ToList();
        }
    }
}
