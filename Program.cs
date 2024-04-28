using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace LB1_TPR
{
    public class DiscountManager
    {
        private readonly Dictionary<int, Func<decimal, int, decimal, decimal>> discountFormulas;

        public DiscountManager()
        {
            discountFormulas = new Dictionary<int, Func<decimal, int, decimal, decimal>>
            {
                { 1, (price, customerLoyaltyYears, maximumDiscountPercent) => price },
                { 2, (price, customerLoyaltyYears, maximumDiscountPercent) => price*0.9M - (Math.Min((decimal)customerLoyaltyYears / 100, maximumDiscountPercent)*(price*0.9M)) },
                { 3, (price, customerLoyaltyYears, maximumDiscountPercent) => price*0.7M - (Math.Min((decimal)customerLoyaltyYears / 100, maximumDiscountPercent)*(price*0.7M)) },
                { 4, (price, customerLoyaltyYears, maximumDiscountPercent) => price*0.5M - (Math.Min((decimal)customerLoyaltyYears / 100, maximumDiscountPercent)*(price*0.5M)) }
            };
        }

        public decimal CalculateDiscount(decimal price, int type, int customerLoyaltyYears)
        {
            if (!discountFormulas.ContainsKey(type))
                return -1;

            decimal maximumDiscountPercent = 0.05m;
            return discountFormulas[type](price, customerLoyaltyYears, maximumDiscountPercent);
        }

        public static void Main()
        {
            DiscountManager clc = new DiscountManager();
            Console.WriteLine(clc.CalculateDiscount(13.72M, 1, 0));
        }
    }
}
