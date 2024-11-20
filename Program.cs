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
                City city = new City();

                city.EnterData();

                city.DisplayData();

                Console.WriteLine($"Назва міста: {city.GetCityName()}");
                Console.WriteLine($"Назва країни: {city.GetCountryName()}");
                Console.WriteLine($"Кількість жителів: {city.GetPopulation()}");
                Console.WriteLine($"Телефонний код: {city.GetPhoneCode()}");
                Console.WriteLine($"Райони міста: {city.GetDistricts()}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Виникла помилка: {ex.Message}");
            }
        }
    }
}