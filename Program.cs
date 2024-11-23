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
                Console.WriteLine("Введіть назву літака:");
                string name = Console.ReadLine();

                Console.WriteLine("Введіть назву виробника:");
                string manufacturer = Console.ReadLine();

                Console.WriteLine("Введіть рік випуску:");
                int year = int.Parse(Console.ReadLine());

                Console.WriteLine("Введіть тип літака:");
                string airplaneType = Console.ReadLine();

                Airplane airplane = new Airplane(name, manufacturer, year, airplaneType);

                Console.WriteLine("\nІнформація про літак:");
                airplane.DisplayData();

                Console.WriteLine("\nСкорочена інформація про літак:");
                airplane.DisplayData(true);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }
        }
    }
}