namespace GU1_Zoo;

using Seido.Utilities.SeedGenerator;

public class csBirdZoo : csZoo
{
        public enum enAnimalKindBird { Eagle = 8, Hawk, Owl, Parrot }

        private int nrParrots { get; init; }

        public csBirdZoo()
        {
                Name = "Reference Zoo Bird";
                var rnd = new csSeedGenerator();

                foreach (var kind in Enum.GetValues(typeof(enAnimalKindBird)))
                {
                        int nrAnimals = rnd.Next(1, 6);
                        for (int i = 0; i < nrAnimals; i++)
                        {
                                ListOfAnimal.Add(new csAnimal(rnd) { Kind = (enAnimalKind)kind });

                                if (ListOfAnimal[^1].Kind == enAnimalKind.Parrot)
                                {
                                        nrParrots++;
                                }
                        }
                }
        }

        public override string ToString()
        {
                string ret = $"The {Name} zoo has a total of {ListOfAnimal.Count} birds (which includes {nrParrots} parrots) they are: \n";
                foreach (var animal in ListOfAnimal)
                {
                        ret += $"\t{animal.Age,2} year old {animal.Mood,7} {animal.Kind,9}  {animal.Name,-10}\n";
                }
                ret += "\n";
                return ret;
        }
}


