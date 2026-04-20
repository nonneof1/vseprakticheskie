using System;
using System.Collections.Generic;
using System.Text;

namespace _11prakreal
{
    public class Doctor : IStorable
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

        public virtual void ExaminePatient(Patient patient)
        {
            Console.WriteLine($"{lastName} осматривает {patient.LastName}: общие рекомендации");
        }

        public void AddPatient(Patient patient)
        {
            patients.Add(patient);
        }

        public void AddPatient(int patientId, string firstName, string lastName, DateTime dateOfBirth, string diagnosis)
        {
            Patient patient = new Patient(patientId, firstName, lastName, dateOfBirth, diagnosis);
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

        public void SaveToFile(string filePath)
        {
            File.WriteAllText(filePath, $"{doctorId}|{firstName}|{lastName}|{specialization}");
        }

        public void LoadFromFile(string filePath)
        {
            if (!File.Exists(filePath)) return;
            string[] parts = File.ReadAllText(filePath).Split('|');
            if (parts.Length >= 4)
            {
                firstName = parts[1];
                lastName = parts[2];
                specialization = parts[3];
            }
        }
    }
}