namespace ClassApp.Entities
{
    internal class Airplane
    {
        private string name;
        private string manufacturer;
        private int year;
        private string airplaneType;

        public Airplane(string name, string manufacturer, int year, string airplaneType)
        {
            this.name = name;
            this.manufacturer = manufacturer;
            this.year = year;
            this.airplaneType = airplaneType;
        }

        public void DisplayData()
        {
            Console.WriteLine($"Назва літака: {name}");
            Console.WriteLine($"Виробник: {manufacturer}");
            Console.WriteLine($"Рік випуску: {year}");
            Console.WriteLine($"Тип літака: {airplaneType}");
        }

        public void DisplayData(bool shortVersion)
        {
            if (shortVersion)
            {
                Console.WriteLine($"Назва літака: {name}");
                Console.WriteLine($"Тип літака: {airplaneType}"); 
            }
            else
            {
                DisplayData(); 
            }
        }
    }
}
