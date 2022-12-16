namespace Zad2
{
    public enum Dishes
    {
        Meso,
        Riba,
        Vege
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Invitation[] invitations =
            {
                new Invitation("Kraml",true,0),
                new Invitation("Zorić",true,0),
                new Invitation("Bajer",true,2),
                new Invitation("Šojo",true,1)
            };
            GuestTracker tracker = new GuestTracker();
            foreach(var invitation in invitations)
            {
                tracker.NoteDown(invitation);
            }
            Console.WriteLine(tracker);
        }
    }

    public class Invitation
    {
        private string surname;
        private bool isComing;
        private Dishes dish;

        public Invitation(string surname, bool isComing, int dish)
        {
            this.surname = surname;
            this.isComing = isComing;
            this.dish = (Dishes)dish;
        }

        public string Surname { get { return surname; } }
        public bool IsComing { get { return isComing; } }
        public Dishes Dish { get { return dish; } }

        public override string ToString()
        {
            if (this.isComing)
            {
                return $"{Surname} will eat {dish}";
            }
            else
            {
                return $"{Surname} is not coming";
            }
        }
    }

    public class GuestTracker
    {
        private List<string> surnames;
        private Dictionary<int, Dishes> dishes;

        public GuestTracker()
        {
            surnames = new List<string>();
            dishes = new Dictionary<int, Dishes>();
        }
        public void NoteDown(Invitation guest)
        {
            if (guest.IsComing)
            {
                surnames.Add(guest.Surname);
                if (guest.Dish == Dishes.Meso)
                {
                    dishes.Add(dishes.Count, Dishes.Meso);
                }
                if (guest.Dish == Dishes.Riba)
                {
                    dishes.Add(dishes.Count, Dishes.Riba);
                }
                if (guest.Dish == Dishes.Vege)
                {
                    dishes.Add(dishes.Count, Dishes.Vege);
                }
            }
        }
        public int NumberOfGuests { get { return surnames.Count; } }
        public override string ToString()
        {
            string output = string.Empty;
            for(int i= 0; i < surnames.Count; i++)
            {
                output += $"{surnames[i]}: {dishes[i]}{Environment.NewLine}";
            }
            return output;
        }
    }
}