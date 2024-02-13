namespace hw_3.DIP
{
    internal class FilmCinema : ITypeMovie
    {
        public string Title;
        public FilmCinema(string title)
        {
            Title = title;
        }

        public void play()
        {
            Console.WriteLine(string.Format("Пленочное кино {0} проигрывается", Title));
        }
    }
}