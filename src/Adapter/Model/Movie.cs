using System.Xml.Serialization;

namespace Adapter.Model;

[Serializable]
public class Movie
{
    public Movie() { }

    public Movie(int id, string name, decimal rating)
    {
        Id = id;
        Name = name;
        Rating = rating;
    }

    [XmlAttribute]
    public int Id { get; set; }

    [XmlAttribute]
    public string? Name { get; set; }

    [XmlAttribute]
    public decimal Rating { get; set; }
}
