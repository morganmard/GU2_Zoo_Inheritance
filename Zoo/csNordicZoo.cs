namespace GU1_Zoo;

using Seido.Utilities.SeedGenerator;

public class csNordicZoo : csZoo
{
        public enum enAnimalKindNordic { Moose, Wolf, Deer, Fox }

        private int nrWolves { get; init; }

        public csNordicZoo()
        {
                Name = "Reference Zoo Nordic";
                var rnd = new csSeedGenerator();

                foreach (var kind in Enum.GetValues(typeof(enAnimalKindNordic)))
                {
                        int nrAnimals = rnd.Next(1, 6);
                        for (int i = 0; i < nrAnimals; i++)
                        {
                                ListOfAnimal.Add(new csAnimal(rnd) { Kind = (enAnimalKind)kind });

                                if (ListOfAnimal[^1].Kind == enAnimalKind.Wolf)
                                {
                                        nrWolves++;
                                }
                        }
                }
        }

        public override string ToString()
        {
                string ret = $"The {Name} zoo has a total of {ListOfAnimal.Count} animals (which includes {nrWolves} wolves) they are: \n";
                foreach (var animal in ListOfAnimal)
                {
                        ret += $"\t{animal.Age,2} year old {animal.Mood,7} {animal.Kind,9}  {animal.Name,-10}\n";
                }
                ret += "\n";
                return ret;
        }
}


