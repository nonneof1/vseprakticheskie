using System.Numerics;

namespace _9prakhosp
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

            hospital.AddDepartment(101);
            hospital.AddDepartment(102);

            Patient pat1 = new Patient(1, "сидор", "сидоров", new DateTime(1990, 5, 15), "аритмия");
            Patient pat2 = new Patient(2, "мария", "марьина", new DateTime(1985, 8, 22), "перелом");

            doc1.AddPatient(pat1);
            doc2.AddPatient(pat2);

            card.AddDoctor(doc1);
            surg.AddDoctor(doc2);

            Console.WriteLine($"\nбольница: {hospital.Name}");
            Console.WriteLine($"адрес: {hospital.Address}");
            Console.WriteLine($"врачей в кардиологии: {card.GetDoctorsCount()}");
            Console.WriteLine($"свободных коек в хирургии: {surg.GetAvailableBeds()}");
            Console.WriteLine($"возраст пациента {pat1.FirstName}: {pat1.GetAge()}");
        }
    }
}