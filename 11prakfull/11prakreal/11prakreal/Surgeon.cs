using System;
using System.Collections.Generic;
using System.Text;

namespace _11prakreal
{
    public class Surgeon : Doctor
    {
        public Surgeon(int id, string firstName, string lastName) : base(id, firstName, lastName, "хирургия")
        {
        }

        public override void ExaminePatient(Patient patient)
        {
            Console.WriteLine($"{LastName} (хирург) осматривает {patient.LastName}: оцените необходимость операции");
        }
    }
}