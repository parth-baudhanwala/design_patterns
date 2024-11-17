using Observer.Event;

namespace Observer.Publisher;

// The Subject/Publisher class that holds or publish the event
public class Stock
{
    private double _price;

    public Stock(string symbol, double price)
    {
        Symbol = symbol;
        _price = price;
    }

    // Declare the delegate and event
    public delegate void PriceChangedHandler(object sender, PriceChangedEventArgs e);
    public event PriceChangedHandler? PriceChanged;

    public string Symbol { get; }

    public double Price
    {
        get => _price;
        set
        {
            if (_price != value)
            {
                _price = value;

                // Notify subscribers about the price change
                OnPriceChanged(new PriceChangedEventArgs(Symbol, Price));
            }
        }
    }

    protected virtual void OnPriceChanged(PriceChangedEventArgs e)
    {
        PriceChanged?.Invoke(this, e);
    }
}
