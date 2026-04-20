using System;
using System.Collections.Generic;
using System.Text;

namespace _10praknasled
{
    public class Hospital
    {
        private int hospitalId;
        private string name;
        private string address;
        private List<Department> departments;

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
        }

        public Hospital(int id, string name) : this(id)
        {
            this.name = name;
        }

        public Hospital(int id, string name, string address) : this(id, name)
        {
            this.address = address;
        }

        public void AddDepartment(Department department)
        {
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

        public int GetDepartmentCount()
        {
            return departments.Count;
        }
    }
}