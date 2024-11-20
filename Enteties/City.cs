using System;
using System.Collections.Generic;

namespace ClassApp.Entities
{
    public class City
    {
        private string cityName;
        private string countryName;
        private int population;
        private string phoneCode;
        private List<string> districts;

        public City()
        {
            cityName = "Невідоме місто";
            countryName = "Невідома країна";
            population = 0;
            phoneCode = "Невідомий код";
            districts = new List<string>();
        }

        public void EnterData()
        {
            Console.WriteLine("Введіть назву міста:");
            cityName = Console.ReadLine();

            Console.WriteLine("Введіть назву країни:");
            countryName = Console.ReadLine();

            Console.WriteLine("Введіть кількість жителів:");
            population = int.Parse(Console.ReadLine());

            Console.WriteLine("Введіть телефонний код міста:");
            phoneCode = Console.ReadLine();

            Console.WriteLine("Введіть назви районів міста (введіть 'стоп' для завершення):");
            districts.Clear();
            string district;
            while ((district = Console.ReadLine()) != "стоп")
            {
                districts.Add(district);
            }
        }

        public void DisplayData()
        {
            Console.WriteLine($"Місто: {cityName}");
            Console.WriteLine($"Країна: {countryName}");
            Console.WriteLine($"Кількість жителів: {population}");
            Console.WriteLine($"Телефонний код: {phoneCode}");
            Console.WriteLine("Райони міста:");
            foreach (var district in districts)
            {
                Console.WriteLine(district);
            }
        }

        public string GetCityName() => cityName;
        public string GetCountryName() => countryName;
        public int GetPopulation() => population;
        public string GetPhoneCode() => phoneCode;
        public string GetDistricts() => string.Join(", ", districts);
    }
}