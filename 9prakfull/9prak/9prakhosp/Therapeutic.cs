using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace _9prakhosp
{
    public class Therapeutic
    {
        private int departmentId;
        private string name;
        private Doctor headOfDepartment;
        private List<Doctor> doctors;
        private bool[] beds;

        public int DepartmentId
        {
            get { return departmentId; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Doctor HeadOfDepartment
        {
            get { return headOfDepartment; }
            set { headOfDepartment = value; }
        }

        public Therapeutic()
        {
            doctors = new List<Doctor>();
        }

        public Therapeutic(int id) : this()
        {
            departmentId = id;
        }

        public Therapeutic(int id, string name) : this(id)
        {
            this.name = name;
        }

        public Therapeutic(int id, string name, Doctor head, int bedCount) : this(id, name)
        {
            headOfDepartment = head;
            beds = new bool[bedCount];
            for (int i = 0; i < bedCount; i++)
                beds[i] = true;
        }

        public void AddDoctor(Doctor doctor)
        {
            doctors.Add(doctor);
        }

        public bool RemoveDoctor(int doctorId)
        {
            var doc = doctors.FirstOrDefault(d => d.DoctorId == doctorId);
            if (doc != null)
            {
                doctors.Remove(doc);
                return true;
            }
            return false;
        }

        public Doctor FindDoctor(int doctorId)
        {
            return doctors.FirstOrDefault(d => d.DoctorId == doctorId);
        }

        public int GetAvailableBeds()
        {
            int count = 0;
            foreach (bool bed in beds)
                if (bed) count++;
            return count;
        }
    }
}