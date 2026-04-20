using System;
using System.Collections.Generic;
using System.Text;

namespace _11prakreal
{
    public class Hospital : IStorable
    {
        private int hospitalId;
        private string name;
        private string address;
        private List<Department> departments;

        private static int hospitalCount = 0;
        public const int MAX_DEPARTMENTS = 10;

        public int HospitalId
        {
            get { return hospitalId; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public Hospital(int id)
        {
            hospitalId = id;
            departments = new List<Department>();
            hospitalCount++;
        }

        public Hospital(int id, string name) : this(id)
        {
            this.name = name;
        }

        public Hospital(int id, string name, string address) : this(id, name)
        {
            this.address = address;
        }

        public static int GetTotalHospitals()
        {
            return hospitalCount;
        }

        public void AddDepartment(Department department)
        {
            if (departments.Count >= MAX_DEPARTMENTS)
            {
                System.Console.WriteLine("нельзя добавить отделение, достигнут лимит");
                return;
            }
            departments.Add(department);
        }

        public bool RemoveDepartment(int departmentId)
        {
            var dep = departments.FirstOrDefault(d => d.DepartmentId == departmentId);
            if (dep != null)
            {
                departments.Remove(dep);
                return true;
            }
            return false;
        }

        public void SaveToFile(string filePath)
        {
            File.WriteAllText(filePath, $"{hospitalId}|{name}|{address}");
        }

        public void LoadFromFile(string filePath)
        {
            if (!File.Exists(filePath)) return;
            string[] parts = File.ReadAllText(filePath).Split('|');
            if (parts.Length >= 3)
            {
                name = parts[1];
                address = parts[2];
            }
        }
    }
}