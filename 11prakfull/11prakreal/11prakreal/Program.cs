using System.Numerics;

namespace _11prakreal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("система управления больницей");

            Hospital h1 = new Hospital(1, "больница 1", "ул. ленина 1");
            Hospital h2 = new Hospital(2, "больница 2", "ул. мира 5");

            Console.WriteLine($"всего больниц: {Hospital.GetTotalHospitals()}");

            Doctor doc1 = new Cardiologist(1, "иван", "иванов");
            Doctor doc2 = new Surgeon(2, "петр", "петров");
            Doctor doc3 = new Therapist(3, "сидор", "сидоров");

            Cardiology card = new Cardiology(101, "кардиология", doc1, 20);
            Surgery surg = new Surgery(102, "хирургия", doc2, 15);

            h1.AddDepartment(card);
            h1.AddDepartment(surg);

            Patient pat1 = new Patient(1, "мария", "иванова", new DateTime(1990, 5, 15), "аритмия");
            Patient pat2 = new Patient(2, "алексей", "петров", new DateTime(1985, 8, 22), "перелом");

            doc1.AddPatient(pat1);
            doc2.AddPatient(pat2);

            Console.WriteLine();
            doc1.ExaminePatient(pat1);
            doc2.ExaminePatient(pat2);
            doc3.ExaminePatient(pat1);

            Console.WriteLine();
            Console.WriteLine(card.GetDepartmentReport());
            card.SpecializedFunctionality();

            Console.WriteLine();
            Console.WriteLine($"имя: {pat1.FirstName.Capitalize()}");

            h1.SaveToFile("hospital.txt");
            h1.LoadFromFile("hospital.txt");
        }
    }
}