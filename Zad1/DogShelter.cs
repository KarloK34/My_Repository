namespace Zad1
{
    public class DogShelter
    {
        List<Dog> dogs;
        public DogShelter()
        {
            dogs = new List<Dog>();
        }

        public void Add(Dog dog)
        {
            dogs.Add(dog);
        }

        public int Count { get { return dogs.Count; } }
        public void Adopt(string name)
        {
            foreach (var dog in dogs)
            {
                if (dog.Name == name) { dogs.Remove(dog); return; }
            }
            throw new NoSuchDogInShelterException($"There is no dog named {name} in shelter.");
        }

        public override string ToString()
        {
            string output = string.Empty;
            foreach(var dog in dogs)
            {
                output += $"{dog}{Environment.NewLine}";
            }
            return output;
        }

        public DogShelter(DogShelter shelter)
        {
            dogs = new List<Dog>();
            foreach (var dog in shelter.dogs)
            {
                this.dogs.Add(dog);
            }
        }
    }
}
