using System.Numerics;

namespace _10praknasled
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("система управления больницей");

            Hospital hospital = new Hospital(1, "городская больница", "ул. ленина 1");

            Doctor doc1 = new Doctor(1, "иван", "иванов", "кардиология");
            Doctor doc2 = new Doctor(2, "петр", "петров", "хирургия");

            Cardiology card = new Cardiology(101, "кардиология", doc1, 20);
            Surgery surg = new Surgery(102, "хирургия", doc2, 15);
            Therapeutic ther = new Therapeutic(103, "терапия", null, 30);

            hospital.AddDepartment(card);
            hospital.AddDepartment(surg);
            hospital.AddDepartment(ther);

            doc1.AddPatient(10, "сидор", "сидоров", new DateTime(1990, 5, 15), "аритмия");
            doc2.AddPatient(11, "мария", "марьина", new DateTime(1985, 8, 22), "перелом");

            card.AddDoctor(doc1);
            surg.AddDoctor(doc2);

            card.NotifyEmergency("требуется срочная операция");
            surg.NotifyNewEquipment("новый скальпель");

            Console.WriteLine($"\nбольница: {hospital.Name}");
            Console.WriteLine($"отделений: {hospital.GetDepartmentCount()}");
            Console.WriteLine($"врачей в кардиологии: {card.GetDoctorsCount()}");
            Console.WriteLine($"свободных коек в хирургии: {surg.GetAvailableBeds()}");
        }
    }
}