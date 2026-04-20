using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace _10praknasled
{
    public class Cardiology : Department
    {
        public Cardiology() : base() { }

        public Cardiology(int id) : base(id) { }

        public Cardiology(int id, string name) : base(id, name) { }

        public Cardiology(int id, string name, Doctor head, int bedCount) : base(id, name, head, bedCount) { }

        public override void NotifyEmergency(string message)
        {
            NotifyDoctors($"срочно! {message}");
        }

        public override void NotifyNewEquipment(string equipment)
        {
            NotifyDoctors($"новое оборудование для кардиологии: {equipment}");
        }
    }
}