using System;
using System.Collections.Generic;
using System.Text;

namespace _9prakhosp
{
    public class Doctor
    {
        private int doctorId;
        private string firstName;
        private string lastName;
        private string specialization;
        private List<Patient> patients;

        public int DoctorId
        {
            get { return doctorId; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Specialization
        {
            get { return specialization; }
            set { specialization = value; }
        }

        public Doctor()
        {
            patients = new List<Patient>();
        }

        public Doctor(int id) : this()
        {
            doctorId = id;
        }

        public Doctor(int id, string firstName) : this(id)
        {
            this.firstName = firstName;
        }

        public Doctor(int id, string firstName, string lastName) : this(id, firstName)
        {
            this.lastName = lastName;
        }

        public Doctor(int id, string firstName, string lastName, string spec) : this(id, firstName, lastName)
        {
            specialization = spec;
        }

        public void AddPatient(Patient patient)
        {
            patients.Add(patient);
        }

        public bool RemovePatient(int patientId)
        {
            var pat = patients.FirstOrDefault(p => p.PatientId == patientId);
            if (pat != null)
            {
                patients.Remove(pat);
                return true;
            }
            return false;
        }

        public Patient FindPatient(int patientId)
        {
            return patients.FirstOrDefault(p => p.PatientId == patientId);
        }

        public int GetPatientCount()
        {
            return patients.Count;
        }
    }
}