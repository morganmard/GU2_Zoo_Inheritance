namespace GU1_Zoo;

class Program
{
    static void Main()
    {
        Console.WriteLine("Zoo's\n");

        var africanZoo = new csAfricanZoo();
        var nordicZoo = new csNordicZoo();
        var birdZoo = new csBirdZoo();

        Console.WriteLine(africanZoo);
        Console.WriteLine();

        Console.WriteLine(nordicZoo);
        Console.WriteLine();

        Console.WriteLine(birdZoo);
        Console.WriteLine();
    }
}