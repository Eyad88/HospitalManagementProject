using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalManagementSystem.Models;

namespace HospitalManagementSystem.Repositories
{
    public class HospitalRepository : IHospitalRepository
    {
        HospitalDBEntities _context = new HospitalDBEntities();
        /// <summary>
        /// Get all the patients form database
        /// </summary>
        /// <returns>List of Patiners </returns>
        public IEnumerable<Patient> GetAllPatient()
        {
            var results = _context.Patients
                .Where(p => p.FirstName != null)
                .Where(p => p.LastName != null);
            return results;
        }

        /// <summary>
        /// Get all the Doctors form database
        /// </summary>
        /// <returns>List of Doctors </returns>
        public IEnumerable<Doctor> GetAllDoctors()
        {
            var results = _context.Doctors
                .Where(p => p.FirstName != null)
                .Where(p => p.LastName != null);
            return results;
        }

        /// <summary>
        /// Get all the Drugs form database
        /// </summary>
        /// <returns>List of Drug </returns>
        public IEnumerable<Drug> GetAllDrugs()
        {
            var results = _context.Drugs;
            return results;
        }

        public IEnumerable<Prescribe> GetAllPrescribe()
        {
            var results = _context.Prescribes;
            return results;
        }

        public void AddNewPatient(Patient patient)
        {
            _context.Patients.Add(patient);
            _context.SaveChanges();
        }

        public void UpdatePatient(Patient patient)
        {
            Models.Patient p = _context.Patients.SingleOrDefault(dr => dr.PatientId == patient.PatientId);
            if (p != null)
            {
                p.PatientId = patient.PatientId;
                p.FirstName = patient.FirstName;
                p.LastName = patient.LastName;
                p.Gender = patient.Gender;
                p.DateOfBirth = Convert.ToDateTime(patient.DateOfBirth);
                p.PhoneNo = patient.PhoneNo;
                p.EmailAddress = patient.EmailAddress;
                p.HouseNo = patient.HouseNo;
                p.AddressLine1 = patient.AddressLine1;
                p.AddressLine2 = patient.AddressLine2;
                p.City = patient.City;
                p.Country = patient.Country;
                p.PostCode = patient.PostCode;
                p.NINumber = patient.NINumber;
                p.MaritalStatusStr = patient.MaritalStatusStr;
                p.DescriptionOfHealth = patient.DescriptionOfHealth;               
            }
            _context.SaveChanges();

        }

        public void DeletePatient(Patient patient)
        {
            Models.Patient p = _context.Patients.SingleOrDefault(dr => dr.PatientId == patient.PatientId);

            if (p != null)
            {
                _context.Patients.Remove(p);
                _context.SaveChanges();

            }
        }


        public void AddNewDoctor(Doctor doctor)
        {
            _context.Doctors.Add(doctor);
            _context.SaveChanges();

        }
        public void UpdateDoctor(Doctor doctor)
        {
            Models.Doctor p = _context.Doctors.SingleOrDefault(dr => dr.DoctorID == doctor.DoctorID);
            if (p != null)
            {
                p.DoctorID = doctor.DoctorID;
                p.FirstName = doctor.FirstName;
                p.LastName = doctor.LastName;
                p.PhoneNo = doctor.PhoneNo;
                p.EmailAddress = doctor.EmailAddress;
                p.Speciallity = doctor.Speciallity;
            }
            _context.SaveChanges();

        }
        public void DeleteDoctor(Doctor doctor)
        {
            Models.Doctor p = _context.Doctors.SingleOrDefault(dr => dr.DoctorID == doctor.DoctorID);

            if (p != null)
            {
                _context.Doctors.Remove(p);
                _context.SaveChanges();

            }

        }

        public void AddNewDrug(Drug drug)
        {
            _context.Drugs.Add(drug);
            _context.SaveChanges();

        }
        public void UpdateDrug(Drug drug)
        {
            Models.Drug p = _context.Drugs.SingleOrDefault(dr => dr.DrugId == drug.DrugId);
            if (p != null)
            {
                p.DrugId = drug.DrugId;
                p.DrugName = drug.DrugName;
                p.Maximum_Dose = drug.Maximum_Dose;
                p.Minimum_Dose = drug.Minimum_Dose;
            }
            _context.SaveChanges();

        }
        public void DeleteDrug(Drug drug)
        {
            Models.Drug p = _context.Drugs.SingleOrDefault(dr => dr.DrugId == drug.DrugId);

            if (p != null)
            {
                _context.Drugs.Remove(p);
                _context.SaveChanges();
            }
        }

        public void AddNewPrescribe(Prescribe prescribe)
        {
            _context.Prescribes.Add(prescribe);
            _context.SaveChanges();
        }
        public void UpdatePrescribe(Prescribe prescribe)
        {
            Models.Prescribe p = _context.Prescribes.SingleOrDefault(dr => dr.PrescribedId == prescribe.PrescribedId);
            if (p != null)
            {
                p.PrescribedId = prescribe.PrescribedId;
                p.PatientId = prescribe.PatientId;
                p.DoctorId = prescribe.DoctorId;
                p.UnitCost = prescribe.UnitCost;
                p.TotalCost = prescribe.TotalCost;
                p.Quantity = prescribe.Quantity;
                p.PrescribedTime = prescribe.PrescribedTime;
            }
            _context.SaveChanges();
        }
        /// <summary>
        /// Delete Exsisting Prescribe from database 
        /// </summary>
        /// <param name="prescribe"></param>
        public void DeletePrescribe(Prescribe prescribe)
        {
            Models.Prescribe p = _context.Prescribes.SingleOrDefault(dr => dr.PrescribedId == prescribe.PrescribedId);

            if (p != null)
            {
                _context.Prescribes.Remove(p);
                _context.SaveChanges();

            }

        }
    }
}
