using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalManagementSystem.Models;

namespace HospitalManagementSystem.Repositories
{
    public interface IHospitalRepository
    {
        // Declaring Methods
        IEnumerable<Patient> GetAllPatient();
        void AddNewPatient(Patient patient);
        void UpdatePatient(Patient patient);
        void DeletePatient(Patient patient);
     
        IEnumerable<Doctor> GetAllDoctors();
        void AddNewDoctor(Doctor doctor);
        void UpdateDoctor(Doctor doctor);
        void DeleteDoctor(Doctor doctor);
        
        IEnumerable<Drug> GetAllDrugs();
        void AddNewDrug(Drug drug);
        void UpdateDrug(Drug drug);
        void DeleteDrug(Drug drug);
        
        IEnumerable<Prescribe> GetAllPrescribe();
        void AddNewPrescribe(Prescribe prescribe);
        void UpdatePrescribe(Prescribe prescribe);
        void DeletePrescribe(Prescribe prescribe);

    }
}
