using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_OOP
{
    public struct Price
    {
        int cents;
        int roubles;

        public int Cents
        {
            get { return cents; }
            set
            {
                if (cents < 100)
                {
                    cents = value;
                }
                else
                {
                    cents = value % 100;
                    roubles = value / 100;
                }
            }
        }

        public int Roubles
        {
            get
            {
                return roubles;
            }
            set
            {
                roubles = value;
            }
        }

        public static Price operator +(Price o1, Price o2)
        {
            Price newPrice = new Price();
            newPrice.roubles = o1.Roubles + o2.Roubles;
            newPrice.cents = o1.cents + o2.cents;
            return newPrice;
        }

        public static Price operator -(Price o1, Price o2)
        {
            Price newPrice = new Price();
            newPrice.roubles = o1.Roubles - o2.Roubles;
            if (o1.cents < o2.cents)
                newPrice.roubles--;
            newPrice.cents = Math.Abs(o1.cents - o2.cents);
            return newPrice;
        }
    }
}
