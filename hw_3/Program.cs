using hw_3.SRP;
using hw_3.OCP;
using hw_3.LSP;
using hw_3.ISP;
using hw_3.DIP;

//SRP
Movie movie1 = new Movie("Терминатор 2", 1991);
MovieProfit movieProfit1 = new MovieProfit(movie1, 102000000, 521000000);
movieProfit1.estimateBoxOffice();
Console.WriteLine();

//OCP
MovieTeam movieTeam = new MovieTeam(movie1);
movieTeam.getTeam(new Actors());
movieTeam.getTeam(new Makers());
Console.WriteLine();

//LSP
List<IActor> actors = [new MainActor("Арнольд Шварценеггер", "Т-800"),
    new MainActor("Эдвард Фёрлонг", "Джон Коннор"),
    new CrowdActor("Роберт Патрик"),
    new CrowdActor("Эрл Боэн")];
foreach (IActor actor in actors)
{
    Console.WriteLine(actor.getName() + ", " + actor.getPosition());
}
Console.WriteLine();

//ISP
Director director = new("Джеймс Кэмерон", true);
Operator oper = new("Адам Гринберг", true);
Console.WriteLine(director.getName() + ", " + director.getMovieRole() + ", " + director.CreateScript());
Console.WriteLine(oper.getName() + ", " + oper.getMovieRole() );
Console.WriteLine();

//DIP
List<ITypeMovie> movies = [new FilmCinema("1 + 1"), new DigitalCinema("Легенда"), new DigitalCinema("Мгла")];
Cinema cinema = new Cinema(4, movies);
cinema.playMovie();
