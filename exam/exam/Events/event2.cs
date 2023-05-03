using System;
using System.Collections.Generic;
using System.Text;

namespace Events
{

    public delegate void LowInventoryhandler(int salesValue);
    public delegate void HighInventoryhandler(int purchaseValue);
    internal class InventoryManager
    {
        public event LowInventoryhandler Inventory_Low;
        public event HighInventoryhandler Inventory_High;

        private int TotalInventory = 0;

        public int GetInventoryStatus => TotalInventory;
        //{
        //    get
        //    {
        //        return TotalInventory;
        //    }
        //}

        public int MaxInventoryLimit = 100;

        public int MinInventoryLimit = 10;

        public int Sales {

            set
            {
                if (TotalInventory - value < MinInventoryLimit)
                {
                    Low_Inventory();
                }
                else

                {
                    TotalInventory -= value;
                    Console.WriteLine("Total goods sold" + value);
                }
            }
        
        }

        private void Low_Inventory(int inventoryvalue)
        {
            if(Inventory_Low != null)
            {
                Inventory_Low(inventoryvalue);
            }
            else
                //throw new NotImplementedException();
                Console.WriteLine("Nothing To Purchase");
        }

        public int Purchase {
            set
            {

                if(TotalInventory + value < MaxInventoryLimit) 
                
                {
                    High_Inventory(inventoryvalue);
                }
                else
                {
                    TotalInventory += value;
                    Console.WriteLine("Total goods Purchased" + value);
                }
                
                
            }
        
        }

        private void High_Inventory(int inventoryValue)
        {
            if (Inventory_High != null)
            {
                Inventory_High(inventoryValue);
            }
            else
                //throw new NotImplementedException();
                Console.WriteLine("Nothing To sales");
        }
    }
}
