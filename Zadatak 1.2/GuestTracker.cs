namespace Zad2
{
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