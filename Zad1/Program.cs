namespace Zad1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DogShelter shelter = new DogShelter();
            shelter.Add(new Dog("Suzy", "Golden Retriever", 9));
            shelter.Add(new Dog("Bella", "Boston Terrier", 3));
            shelter.Add(new Dog("Charlie","Labrador Retriever", 6));
            shelter.Add(new Dog("Max","Shih Tzu", 2));
            shelter.Add(new Dog("Rex","Irish Setter", 11));
            shelter.Add(new Dog("Lucy","French Bulldog", 4));
            shelter.Add(new Dog("Toto","Cocker Spaniel", 8));
            shelter.Add(new Dog("Daisy","Border Collie", 13));
            shelter.Add(new Dog("Milo","Cavalier King Charles", 5));
            shelter.Add(new Dog("Luna","Basset Hound", 1));
            string[] dogNames = { "Suzy", "Bella", "Charlie", "Max", "Rex", "Lucy", "Toto", "Daisy", "Milo", "Luna" };
            Random generator = new Random();
            Console.WriteLine(shelter);
            int totalDays = 0;
            while(shelter.Count > 0)
            {
                int adoptions = generator.Next(1, 5);
                if (adoptions <= shelter.Count) 
                {
                    int days = generator.Next(3, 14);
                    for (int i = 0; i < adoptions; i++)
                    {
                        int randomNameIndex = generator.Next(0, dogNames.Length);
                        try
                        {
                            shelter.Adopt(dogNames[randomNameIndex]);
                        }
                        catch (NoSuchDogInShelterException e)
                        {
                            Console.WriteLine(e.Message);
                            i--;
                        }
                    }
                    totalDays += days;
                }
            }
            Console.WriteLine($"All dogs were adopted in {totalDays} days.");
            Console.WriteLine(shelter);
        }
    }

}
