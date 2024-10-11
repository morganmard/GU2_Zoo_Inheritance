namespace GU1_Zoo;

class Program
{
    static void Main()
    {
        Console.WriteLine("Zoo's\n");

        var africanZoo = new csAfricanZoo();
        var nordicZoo = new csNordicZoo();
        var birdZoo = new csBirdZoo();

        List<csZoo> list = [africanZoo, nordicZoo, birdZoo];

        foreach (csZoo zoo in list)
        {
            Console.WriteLine(zoo);
        }
    }
}