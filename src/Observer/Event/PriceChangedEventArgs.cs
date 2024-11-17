namespace Observer.Event;

// Event arguments to provide more details about the event
public class PriceChangedEventArgs : EventArgs
{
    public PriceChangedEventArgs(string symbol, double newPrice)
    {
        Symbol = symbol;
        NewPrice = newPrice;
    }

    public string Symbol { get; }
    public double NewPrice { get; }
}
