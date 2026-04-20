using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace _11prakreal
{
    public class Surgery : Department
    {
        public Surgery() : base() { }

        public Surgery(int id) : base(id) { }

        public Surgery(int id, string name) : base(id, name) { }

        public Surgery(int id, string name, Doctor head, int bedCount) : base(id, name, head, bedCount) { }

        public override string GetDepartmentReport()
        {
            return $"хирургия: врачей {GetDoctorsCount()}, коек {GetAvailableBeds()}";
        }

        public override void SpecializedFunctionality()
        {
            Console.WriteLine("рекомендации: стерильность превыше всего");
        }

        public override void NotifyEmergency(string message)
        {
            NotifyDoctors($"операция! {message}");
        }

        public override void NotifyNewEquipment(string equipment)
        {
            NotifyDoctors($"новый инструмент: {equipment}");
        }
    }
}