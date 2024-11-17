using Observer.Publisher;
using Observer.Subscriber;

// Create a stock and an investor
Stock stock = new("TATAMOTORS", 774.30);
Investor investor1 = new("Parth Baudhanwala");
Investor investor2 = new("Ratan Tata");

// Subscribe to the event
stock.PriceChanged += investor1.OnPriceChanged;
stock.PriceChanged += investor2.OnPriceChanged;

// Change the stock price and trigger notifications
stock.Price = 735.03; // Both investors will be notified
stock.Price = 824.50; // Notification happens again

// Detach an observer
stock.PriceChanged -= investor2.OnPriceChanged;
stock.Price = 1025.75; // Only Parth Baudhanwala will be notified
