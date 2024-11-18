using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp9
{
    public delegate void PriceChangedHandler(decimal oldPrice, decimal newPrice);
    class Stock
    {
        string symbol;
        decimal price;

        public Stock(string symbol) => this.symbol = symbol;
        public event PriceChangedHandler PriceChanged;

        public decimal Price {
            get => price;

            set {
                if (price == value)  return;
               
                decimal oldPrice = price;
                price = value;

                if (PriceChanged != null) {
                    PriceChanged(oldPrice, price);
                }
            }
        }
    }
}
