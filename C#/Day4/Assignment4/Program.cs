using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Furniture
    {
        public int OrderId;
        public string OrderDate;
        public string FurnitureType;
        public int Qty;
        public int TotalAmount;
        public string PaymentMode;

        public virtual void GetData()
        {
            OrderId = new Random().Next();
            Console.WriteLine("Enter the Order date:");
            OrderDate = Console.ReadLine();
            Console.WriteLine("Enter the quantity:");
            Qty = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the payment mode (credit/debit card)");
            PaymentMode = Console.ReadLine();
        }

        public virtual void ShowData()
        {
            Console.WriteLine($"Order Id:{OrderId}");
            Console.WriteLine($"Order date:{OrderDate}");
            Console.WriteLine($"Quantity:{Qty}");
            Console.WriteLine($"Payment Mode:{PaymentMode}");
        }
    }

    class Chair : Furniture
    {
        public string ChairType;
        public string Purpose;
        public string WoodType;
        public int Rate;

        public override void GetData()
        {
            base.GetData();
            FurnitureType = "Chair";
            Console.WriteLine("Enter Chair Type (Wood/Steel/Plastic):");
            ChairType = Console.ReadLine();
            if (ChairType.Equals("Wood", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Enter the Wood Type (Teak Wood/Rose Wood):");
                WoodType = Console.ReadLine();
            }
            else if (ChairType.Equals("Steel", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Enter the steel type ( Gray Steel/Green Steel/Brown Steel)");
                WoodType = Console.ReadLine();
            }
            else if (ChairType.Equals("Plastic", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Enter Plastic Color (Green/Red/Blue/White):");
                WoodType = Console.ReadLine();
            }
            Console.WriteLine("Enter the Purpose (Home/Office):");
            Purpose = Console.ReadLine();
            Console.WriteLine("Enter Rate:");
            Rate = int.Parse(Console.ReadLine());
            TotalAmount = Rate * Qty;

        }
        public override void ShowData()
        {
            base.ShowData();
            Console.WriteLine($"Furniture type:{FurnitureType}");
            Console.WriteLine($"Chair Type: {ChairType}");
            Console.WriteLine($"Purpose: {Purpose}");
            Console.WriteLine($"Wood Type or Steel type or Plastic Color: {WoodType}");
            Console.WriteLine($"Rate: {Rate}");
            Console.WriteLine($"Total Amount {TotalAmount}");
        }
    }
    class Cot : Furniture
    {
        public string CotType;
        public string WoodType;
        public string Capacity;
        public int Rate;

        public override void GetData()
        {
            base.GetData();
            FurnitureType = "Cot";
            Console.WriteLine("Enter Cot Type (Wood/Steel):");
            CotType = Console.ReadLine();
            if (CotType.Equals("Wood", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Enter Wood Type (Teak Wood/Rose Wood):");
                WoodType = Console.ReadLine();
            }
            else if (CotType.Equals("Steel", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Enter steel type (Gray Steel/Green Steel/Brown Steel):");
                WoodType = Console.ReadLine();
            }
            Console.WriteLine("Enter Capacity (Single/Double):");
            Capacity = Console.ReadLine();
            Console.WriteLine("Enter Rate:");
            Rate = int.Parse(Console.ReadLine());
            TotalAmount = Rate * Qty;
        }

        public override void ShowData()
        {
            base.ShowData();
            Console.WriteLine($"Furniture type:{FurnitureType}");
            Console.WriteLine($"Cot Type: {CotType}");
            Console.WriteLine($"Wood Type: {WoodType}");
            Console.WriteLine($"Capacity: {Capacity}");
            Console.WriteLine($"Rate: {Rate}");
            Console.WriteLine($"Total Amount {TotalAmount}");

        }
    }
    internal class Assignment4
    {
        static void Main()
        {
            do
            {
                Console.WriteLine("Enter the Furniture Type");
                Console.WriteLine("1.Chair");
                Console.WriteLine("2.Cot");
                Console.WriteLine("3.Exit");
                Console.WriteLine("Choose one....");
                int ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        {
                            Chair chair = new Chair();
                            chair.GetData();
                            Console.WriteLine();
                            chair.ShowData();
                        }
                        break;
                    case 2:
                        {
                            Cot cot = new Cot();
                            cot.GetData();
                            Console.WriteLine();
                            cot.ShowData();
                        }
                        break;
                    case 3:
                        {
                            Environment.Exit(0);
                        }
                        break;
                }
            } while (true);

        }
    }
}