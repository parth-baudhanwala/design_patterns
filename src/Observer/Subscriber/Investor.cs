using Observer.Event;

namespace Observer.Subscriber;

// Observer class that subscribes to the event
public class Investor
{
    private readonly string _name;

    public Investor(string name)
    {
        _name = name;
    }

    public void OnPriceChanged(object sender, PriceChangedEventArgs e)
    {
        Console.WriteLine($"Investor {_name} notified: {e.Symbol}'s new price is Rs. {e.NewPrice}");
    }
}
