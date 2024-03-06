using Adapter;

MovieAdapter movieAdapter = new();
string movieJson = movieAdapter.GetMovies();

Console.WriteLine(movieJson);
