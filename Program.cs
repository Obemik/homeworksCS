using ClassApp.Entities;
using System.Text;

namespace ClassApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            try
            {
                Employee employee = new Employee();

                employee.EnterData();

                employee.DisplayData();

                Console.WriteLine($"ПІБ: {employee.GetFullName()}");
                Console.WriteLine($"Дата народження: {employee.GetDateOfBirth():dd.MM.yyyy}");
                Console.WriteLine($"Телефон: {employee.GetPhoneNumber()}");
                Console.WriteLine($"Email: {employee.GetEmail()}");
                Console.WriteLine($"Посада: {employee.GetPosition()}");
                Console.WriteLine($"Обов'язки: {employee.GetDuties()}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }
        }
    }
}