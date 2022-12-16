namespace Zad2
{
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
}