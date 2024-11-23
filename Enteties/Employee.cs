using System;

namespace ClassApp.Entities
{
    public class Employee
    {
        private string fullName;
        private DateTime dateOfBirth;
        private string phoneNumber;
        private string email;
        private string position;
        private string duties;

        public Employee()
        {
            fullName = "Невідомий";
            dateOfBirth = DateTime.MinValue;
            phoneNumber = "Невідомий";
            email = "Невідомий";
            position = "Невідомий";
            duties = "Невідомий";
        }

        public void EnterData()
        {
            Console.WriteLine("Введіть ПІБ:");
            fullName = Console.ReadLine();

            Console.WriteLine("Введіть дату народження (у форматі рррр-мм-дд):");
            dateOfBirth = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Введіть контактний телефон:");
            phoneNumber = Console.ReadLine();

            Console.WriteLine("Введіть робочий email:");
            email = Console.ReadLine();

            Console.WriteLine("Введіть посаду:");
            position = Console.ReadLine();

            Console.WriteLine("Введіть опис службових обов'язків:");
            duties = Console.ReadLine();
        }

        public void DisplayData()
        {
            Console.WriteLine("Дані про співробітника:");
            Console.WriteLine($"ПІБ: {fullName}");
            Console.WriteLine($"Дата народження: {dateOfBirth:dd.MM.yyyy}");
            Console.WriteLine($"Контактний телефон: {phoneNumber}");
            Console.WriteLine($"Робочий email: {email}");
            Console.WriteLine($"Посада: {position}");
            Console.WriteLine($"Опис службових обов'язків: {duties}");
        }

        public string GetFullName() => fullName;
        public DateTime GetDateOfBirth() => dateOfBirth;
        public string GetPhoneNumber() => phoneNumber;
        public string GetEmail() => email;
        public string GetPosition() => position;
        public string GetDuties() => duties;

        public void SetFullName(string value) => fullName = value;
        public void SetDateOfBirth(DateTime value) => dateOfBirth = value;
        public void SetPhoneNumber(string value) => phoneNumber = value;
        public void SetEmail(string value) => email = value;
        public void SetPosition(string value) => position = value;
        public void SetDuties(string value) => duties = value;
    }
}