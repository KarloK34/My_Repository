namespace Zad2
{
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
}