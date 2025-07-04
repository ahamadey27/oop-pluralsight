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

        //private UnitType unitType;
        //private int amountInStock = 0;
        //private bool isBelowStockThreshold = false;

        public string Name
        {
            get { return name; }
            set
            {
                name = value.Length > 50 ? value[..50] : value; //[..int] range operator that restricts amount of characters to amount after ..
            }
        }

        public string? Description
        {
            get { return description; }
            set
            {
                if (value == null)
                {
                    description = string.Empty;
                }
                else
                {
                    description = value.Length > 250 ? value[..250] : value;
                }
            }
        }

        public int Id { get; set; }

        public UnitType UnitType { get; set; }
        public int AmountInStock { get; private set; }
        public bool IsBelowStockThreshold { get; private set; }

        public Product(int id) : this(id, string.Empty) //constructor
        {
           
        }

        public Product (int id, string name)
        {
            Id = id;
            Name = name;
            Description = description;
            UnitType = UnitType;
        }

        public Product(int id, string? description, UnitType unitType, int maxAmountInStock)
        {
            Id = id;
            Name = name;
            Description = description; 
        }


        public void UseProduct(int items)
        {
            if (items <= AmountInStock)
            {
                //use the items
                AmountInStock -= items;

                UpdateLowStock();

                Log($"Amount in stock updated. Now {AmountInStock} items in stock");
            }
            else
            {
                Log($"Not enough items in stock for {CreateSimpleProductRepresentation()} {AmountInStock} " +
                    $"available but {items} requested.");
            }
        }

        public void IncreaseStock()
        {
            AmountInStock++;
        }

        public void DecreaseStock(int items, string reason)
        {
            if (items <= AmountInStock)
            {
                //decrease stock with the specified number of items
                AmountInStock -= items;
            }
            else
            {
                AmountInStock = 0;
            }

            UpdateLowStock();
            Log(reason);
        }

        public string DisplayFullDetails()
        {
            StringBuilder sb = new(); //build or modify strings efficiently, especially in loops or when doing a lot of concatenation.
            //ToDo: add price here too
            sb.Append($"{id} {name} \n{description}\n{AmountInStock} items in stock");

            if (IsBelowStockThreshold)
            {
                sb.Append("\n!!STOCK LOW!!");
            }

            return sb.ToString(); //converts final result back to regular string
        }

        private void UpdateLowStock()
        {
            if (AmountInStock < 10) //fixed value for now
            {
                IsBelowStockThreshold = true;
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
