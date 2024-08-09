using Adapter.Model;
using System.Xml.Serialization;

namespace Adapter.Adaptee;

public class MovieManager
{
    private readonly List<Movie> _movies;

    public MovieManager()
    {
        _movies =
        [
            new Movie(1, "Batman Begins", 8.2M),
            new Movie(2, "The Dark Knight", 9.0M),
            new Movie(3, "The Dark Knight Rises", 8.4M)
        ];
    }

    public virtual string GetMovies()
    {
        using StringWriter stringWriter = new();
        XmlSerializer xmlSerializer = new(_movies.GetType());
        xmlSerializer.Serialize(stringWriter, _movies);
        return stringWriter.ToString();
    }
}
