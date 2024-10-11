namespace GU1_Zoo;

using Seido.Utilities.SeedGenerator;

public class csAfricanZoo : csZoo
{
        public enum enAnimalKindAfrican { Crocodile = 4, Elephant, Lion, Monkey }

        private int amountMeat { get; init; }

        public csAfricanZoo()
        {
                Name = "Reference Zoo African";
                var rnd = new csSeedGenerator();

                foreach (var kind in Enum.GetValues(typeof(enAnimalKindAfrican)))
                {
                        int nrAnimals = rnd.Next(1, 6);
                        for (int i = 0; i < nrAnimals; i++)
                        {
                                ListOfAnimal.Add(new csAnimal(rnd) { Kind = (enAnimalKind)kind });

                                switch ((enAnimalKindAfrican)ListOfAnimal[^1].Kind)
                                {
                                        case enAnimalKindAfrican.Crocodile:
                                                amountMeat += 10;
                                                break;
                                        case enAnimalKindAfrican.Lion:
                                                amountMeat += 5;
                                                break;
                                        default:
                                                break;
                                }
                        }
                }
        }

        public override string ToString()
        {
                string ret = $"The {Name} zoo requires {amountMeat} kg of meat and has the follow animals: \n";
                foreach (var animal in ListOfAnimal)
                {
                        ret += $"\t{animal.Age,2} year old {animal.Mood,7} {animal.Kind,9}  {animal.Name,-10}\n";
                }
                ret += "\n";
                return ret;
        }
}