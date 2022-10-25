namespace ClassLibrary
{
    public class Episode
    {
        private int viewers;
        private double reviewSum;
        private double highestReview;

        public Episode() { viewers = 0; reviewSum = highestReview = 0; }
        public Episode(int viewers, double reviewSum, double highestReview)
        {
            this.viewers = viewers;
            this.reviewSum = reviewSum;
            this.highestReview = highestReview;
        }

        public double GetMaxScore()
        {
            return highestReview;
        }
        public void AddView(double score)
        {
            viewers++;
            reviewSum += score;
            if (score > highestReview) highestReview = score;
        }
        public double GetAverageScore()
        {
            return reviewSum / viewers;
        }
        public int GetViewerCount()
        {
            return viewers;
        }
    }
}