using Adapter.Adaptee;
using Adapter.Model;
using Adapter.Target;
using System.Text.Json;
using System.Xml.Serialization;

namespace Adapter;

public class MovieAdapter : MovieManager, IMovie
{
    private readonly JsonSerializerOptions options = new()
    {
        WriteIndented = true
    };

    public override string GetMovies()
    {
        string movieXml = base.GetMovies();

        using StringReader stringReader = new(movieXml);

        XmlSerializer xmlSerializer = new(typeof(List<Movie>));
        List<Movie> movies = (List<Movie>)xmlSerializer.Deserialize(stringReader)!;

        string movieJson = JsonSerializer.Serialize(movies, options);
        return movieJson;
    }
}

