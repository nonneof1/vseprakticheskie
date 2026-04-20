using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace _10praknasled
{
    public class Therapeutic : Department
    {
        public Therapeutic() : base() { }

        public Therapeutic(int id) : base(id) { }

        public Therapeutic(int id, string name) : base(id, name) { }

        public Therapeutic(int id, string name, Doctor head, int bedCount) : base(id, name, head, bedCount) { }

        public override void NotifyEmergency(string message)
        {
            NotifyDoctors($"терапевтическая помощь! {message}");
        }

        public override void NotifyNewEquipment(string equipment)
        {
            NotifyDoctors($"новое оборудование для терапии: {equipment}");
        }
    }
}