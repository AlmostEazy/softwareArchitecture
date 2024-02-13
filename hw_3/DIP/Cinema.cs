namespace hw_3.DIP
{
    internal class Cinema
    {
        private int NumberOfHalls;
        private List<ITypeMovie> Movies;

        public Cinema(int numberOfHalls, List<ITypeMovie> movies)
        {
            NumberOfHalls = numberOfHalls;
            Movies = movies;
        }

        public void playMovie()
        {
            Random random = new Random();
            for (int i = 0; i < NumberOfHalls; i += 1) {
               Movies[Math.Abs((random.Next() % Movies.Count))].play();
            }
        }
    }
}