using System;
using System.Collections.Generic;
using System.Text;

namespace _11prakreal
{
    public class Patient : IStorable
    {
        private int patientId;
        private string firstName;
        private string lastName;
        private DateTime dateOfBirth;
        private string diagnosis;

        public int PatientId
        {
            get { return patientId; }
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

        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }

        public string Diagnosis
        {
            get { return diagnosis; }
            set { diagnosis = value; }
        }

        public Patient(int id)
        {
            patientId = id;
        }

        public Patient(int id, string firstName) : this(id)
        {
            this.firstName = firstName;
        }

        public Patient(int id, string firstName, string lastName) : this(id, firstName)
        {
            this.lastName = lastName;
        }

        public Patient(int id, string firstName, string lastName, DateTime dob) : this(id, firstName, lastName)
        {
            dateOfBirth = dob;
        }

        public Patient(int id, string firstName, string lastName, DateTime dob, string diag) : this(id, firstName, lastName, dob)
        {
            diagnosis = diag;
        }

        public void UpdateDiagnosis(string newDiagnosis)
        {
            diagnosis = newDiagnosis;
        }

        public int GetAge()
        {
            DateTime today = DateTime.Today;
            int age = today.Year - dateOfBirth.Year;
            if (dateOfBirth > today.AddYears(-age)) age--;
            return age;
        }

        public override string ToString()
        {
            return $"{firstName} {lastName}, {GetAge()} лет, диагноз: {diagnosis}";
        }

        public void SaveToFile(string filePath)
        {
            File.WriteAllText(filePath, $"{patientId}|{firstName}|{lastName}|{dateOfBirth}|{diagnosis}");
        }

        public void LoadFromFile(string filePath)
        {
            if (!File.Exists(filePath)) return;
            string[] parts = File.ReadAllText(filePath).Split('|');
            if (parts.Length >= 5)
            {
                firstName = parts[1];
                lastName = parts[2];
                dateOfBirth = DateTime.Parse(parts[3]);
                diagnosis = parts[4];
            }
        }
    }
}