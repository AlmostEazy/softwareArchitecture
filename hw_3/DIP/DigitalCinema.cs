namespace hw_3.DIP
{
    internal class DigitalCinema : ITypeMovie
    {
        public string Title;

        public DigitalCinema(string title)
        {
            Title = title;
        }

        public void play()
        {
            Console.WriteLine(string.Format("Цифровое кино {0} проигрывается", Title));
        }
    }
}