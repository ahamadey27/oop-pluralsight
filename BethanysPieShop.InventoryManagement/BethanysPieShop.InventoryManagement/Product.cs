using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShop.InventoryManagement
{
    public class Product
    {
        private int id;
        private string name = string.Empty;
        private string? description;

        private int maxItemsStocked = 0;

        private UnitType unitType;
        private int amountInStock = 0;
        private bool isBelowStockThreshold = false;

        public void UseProduct(int items)
        {
            if (items <= amountInStock)
            {
                //use the items
                amountInStock -= items;

                UpdateLowStock();

                Log($"Amount in stock updated. Now {amountInStock} items in stock");
            }
            else
            {
                Log($"Not enough items in stock for {CreateSimpleProductRepresentation()} {amountInStock} " +
                    $"available but {items} requested.");
            }
        }

        public void IncreaseStock()
        {
            amountInStock++;
        }

        public void DecreaseStock(int items, string reason)
        {
            if (items <= amountInStock)
            {
                //decrease stock with the specified number of items
                amountInStock -= items;
            }
            else
            {
                amountInStock = 0;
            }

            UpdateLowStock();
            Log(reason);
        }

        private void UpdateLowStock()
        {
            if (amountInStock < 10) //fixed value for now
            {
                isBelowStockThreshold = true;
            }
        }

        private void Log(string message)
        {
            //can be written to a file
            Console.WriteLine(message);
        }

        private string CreateSimpleProductRepresentation()
        {
            return $"Product {id} ({name})";
        }

    }
}
