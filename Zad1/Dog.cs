namespace Zad1
{
    public class Dog
    {
        private string name;
        private string breed;
        private int age;

        public Dog(string name, string breed, int age)
        {
            this.name = name;
            this.breed = breed;
            this.age = age;
        }

        public string Name { get { return name; } }
        public string Breed { get { return breed; } }
        public int Age { get { return age; } }

        public override string ToString()
        {
            return $"Name:{Name} Breed:{Breed} Age:{Age}";
        }

    }
}
