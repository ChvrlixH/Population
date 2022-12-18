namespace Population
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Country country1 = new Country("Norway", 27000000);
            City city1 = new City("Oslo",3000000);
            City city2 = new City("Bergen",1000000);
            City city3 = new City("Korgen",70000);
            City city4 = new City("Drammen",400000);
            City city5 = new City("Eidjord",600000);

            Country country2 = new Country("Holland", 32000000);
            City city6 = new City("Amsterdam",7000000);
            City city7 = new City("Rotterdam",2000000);
            City city8 = new City("Eindhoven",1000000);
            City city9 = new City("Lahey",800000);
            City city10 = new City("Utrecht",280000);
            
            City[] cities = { city1, city2, city3, city4, city5, city6, city7, city8, city9, city10 };
            Country allCity = new($"{cities}",500000);
            allCity.FindAllByPopulation(300000, 1000000);
        }
    }
}