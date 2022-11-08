using Faker; // käyttämällä tätä riviä, ohjelma ymmärtää että käytetään Faker-kirjastoa, jolloin Faker.Name.FullName()- edessä Faker-referenssi on tarpeeton. 

internal class Program
{
    private static void Main(string[] args)
    {
        for (int i = 1; i <= 3; i++)
        {
            var name = Name.FullName(); //tämä on metodi, joka saatiin kun lisättiin NuGet - Faker.NET ohjelmapaketti
        var city = Address.City();
        var id = Identification.SocialSecurityNumber();
        Console.WriteLine($"Hello {name} from {city} id {id}");
        }
        
    }
}