using System.Text.Json;
using System.Xml.Serialization;
using Adapter.Adaptee;
using Adapter.Model;
using Adapter.Target;

namespace Adapter;

public class MovieAdapter : MovieManager, IMovie
{
    public override string GetMovies()
    {
        string movieXml = base.GetMovies();

        using StringReader stringReader = new(movieXml);

        XmlSerializer xmlSerializer = new(typeof(List<Movie>));
        List<Movie> movies = (List<Movie>)xmlSerializer.Deserialize(stringReader)!;

        JsonSerializerOptions options = new()
        {
            WriteIndented = true
        };

        string movieJson = JsonSerializer.Serialize(movies, options);
        return movieJson;
    }
}

