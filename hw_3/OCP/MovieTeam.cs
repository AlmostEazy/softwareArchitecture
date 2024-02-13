using hw_3.SRP;

namespace hw_3.OCP
{
    public class MovieTeam
    {
        public Movie Movie { get; }

        public MovieTeam(Movie movie)
        {
            Movie = movie;
        }   

        public void getTeam(ITeam team)
        {
            Console.WriteLine("Участники съемочного процесса фильма " + Movie.Title + ": ");
            team.getMembers();
        }
    }
}