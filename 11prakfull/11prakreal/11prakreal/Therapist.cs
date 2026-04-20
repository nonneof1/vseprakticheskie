using System;
using System.Collections.Generic;
using System.Text;

namespace _11prakreal
{
    public class Therapist : Doctor
    {
        public Therapist(int id, string firstName, string lastName) : base(id, firstName, lastName, "терапия")
        {
        }

        public override void ExaminePatient(Patient patient)
        {
            Console.WriteLine($"{LastName} (терапевт) осматривает {patient.LastName}: общий осмотр, назначьте анализы");
        }
    }
}