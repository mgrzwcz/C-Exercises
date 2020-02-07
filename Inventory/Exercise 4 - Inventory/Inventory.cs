using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4___Inventory
{
    class Inventory
    {

        public string ItemNumber { get; set; }

        public string ItemDescription { get; set; }

        private int quantityStored;

        public int QuantityStored
        {
            get { return quantityStored; }
            set { if (value >= 0) quantityStored = value; }
        }

        private decimal pricePerItem;

        public decimal PricePerItem
        {
            get { return pricePerItem; }
            set { if (value >= 0) pricePerItem = value; }
        }

        public Inventory() : this("1", "N/A", 0, 0)
        {

        }
        

        public Inventory(string ItemNumber, string ItemDescription, int QuantityStored, decimal PricePerItem)
        {
            this.ItemNumber = ItemNumber;
            this.ItemDescription = ItemDescription;
            this.QuantityStored = QuantityStored;
            this.PricePerItem = PricePerItem;
        }

        public decimal GetTotalCost(int QuantityStored, decimal PricePerItem)
        {
            return QuantityStored * PricePerItem;
        }
        public override string ToString()
        {
            return $"Item number: {ItemNumber}{Environment.NewLine}Item description: {ItemDescription}{Environment.NewLine}"
               + $"Quantity: {QuantityStored}{Environment.NewLine}Price: {PricePerItem} euro(s){Environment.NewLine}"
               + $"Total cost: {GetTotalCost(QuantityStored, PricePerItem)} euro(s) {Environment.NewLine}";
        }
    }
}
