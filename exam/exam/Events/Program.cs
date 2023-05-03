using System;

namespace Events
{
    internal class Program
    {

        public static void Low_Inventory_Message(int salesValue)
        {
            Console.WriteLine("we need to sale " + salesValue + "TQ Customer.");
            Console.WriteLine("Please purchase more good to sale ");
        }
        public static void High_Inventory_Message(int purchseValue)
        {
            Console.WriteLine("you are trying to purchase {0} from vendor.", purchseValue);
            Console.WriteLine("Please don't purchase goods now wearhouse is Full");
        }

        static void Main(string[] args)
        {
            //EventTestClass etc = new EventTestClass();
            //EventDemoClass app = new EventDemoClass();

            //etc.valueChanged += new EventTestClass.valueChangedEventHandler(app.ChangedOfValue);
            //etc.SetValue(3);
            //etc.SetValue(5);
            //Console.ReadLine();


            Console.WriteLine("Welcome to My Business");

            InventoryManager IM = new InventoryManager();
            Console.WriteLine("Current Inv Value is :" + IM.GetInventoryStatus);

            IM.Inventory_Low += new LowInventoryhandler(Program.Low_Inventory_Message);
            IM.Inventory_High += new HighInventoryhandler(Program.High_Inventory_Message);


            IM.Purchase = 50;
            Console.WriteLine("50 Products Purchased.");

            IM.Sales = 5;
            Console.WriteLine("5 Products Sold");

            IM.Purchase = 60;
            Console.WriteLine("60 Products Purchased");

            IM.Sales = 40;
            Console.WriteLine("40 Products sold");

        }
    }

    public class EventTestClass
    {
        private int nValue;

        public delegate void valueChangedEventHandler();

        public event valueChangedEventHandler valueChanged;

        protected virtual void OnValueChanged()
        {
            if (valueChanged != null)
            {
                valueChanged();
            }
                
            else
            {
                Console.WriteLine("Event fired. No handler!");
            }
        }

        public EventTestClass(int nValue)
        {
           // this.nValue = nValue;
           SetValue(nValue);
            
        }

        public EventTestClass()
        {
        }

        public void SetValue(int nV)
        {
            if(nValue!= nV) {
            nValue = nV;
            OnValueChanged();
            
            }
        }

       
    }
    public class EventDemoClass
    {
        public void ChangedOfValue()
        {
            Console.WriteLine("Handler called and value is changed");
        }
    }
}
