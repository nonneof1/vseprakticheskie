using System;
using System.Collections.Generic;
using System.Text;

namespace _9prakhosp
{
    public class Hospital
    {
        private int hospitalId;
        private string name;
        private string address;
        private List<int> departments;

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
            departments = new List<int>();
        }

        public Hospital(int id, string name) : this(id)
        {
            this.name = name;
        }

        public Hospital(int id, string name, string address) : this(id, name)
        {
            this.address = address;
        }

        public void AddDepartment(int departmentId)
        {
            departments.Add(departmentId);
        }
    }
}