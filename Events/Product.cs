using System;

namespace Events
{
    public delegate void StockControl();
    public class Product
    {
        private int _stock;

        public Product(int stock)
        {
            _stock = stock;
        }

        public event StockControl StockControlEvent;
        public string Name { get; set; }

        public int Stock
        {
            get => _stock;
            set
            {
                _stock = value;
                if (value <= 15)
                {
                    StockControlEvent?.Invoke();
                }
            }
        }

        public void Sell(int amount)
        {
            Stock -= amount;
            Console.WriteLine("Stok Adedi: " + Stock);
        }
    }
}