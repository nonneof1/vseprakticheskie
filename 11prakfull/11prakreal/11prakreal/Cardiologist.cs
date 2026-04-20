using System;
using System.Collections.Generic;
using System.Text;

namespace _11prakreal
{
    public class Cardiologist : Doctor
    {
        public Cardiologist(int id, string firstName, string lastName) : base(id, firstName, lastName, "кардиология")
        {
        }

        public override void ExaminePatient(Patient patient)
        {
            Console.WriteLine($"{LastName} (кардиолог) осматривает {patient.LastName}: проверьте сердце, сделайте экг");
        }
    }
}