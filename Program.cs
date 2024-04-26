namespace LB1_TPR { 
    public class DiscountManager
    {
        public decimal CalculateDiscount(decimal price, int type, int customerLoyaltyYears)
        {
            int maximumYearsDiscount = 5;
            decimal priceAfterDiscount = 0;
            decimal disc = (customerLoyaltyYears > maximumYearsDiscount) ? (decimal)maximumYearsDiscount / 100 : (decimal)customerLoyaltyYears / 100;
            if (type == 1)
            {
                priceAfterDiscount = price;
            }
            else if (type == 2)
            {
                priceAfterDiscount = (price - (0.1m * price)) - disc * (price - (0.1m * price));
            }
            else if (type == 3)
            {
                priceAfterDiscount = (0.7m * price) - disc * (0.7m * price);
            }
            else if (type == 4)
            {
                priceAfterDiscount = (price - (0.5m * price)) - disc * (price - (0.5m * price));
            }
            else
            {
                return -1;
            }
            return priceAfterDiscount;
        }

        public static void Main() 
        {
            DiscountManager clc = new DiscountManager();
            Console.WriteLine(clc.CalculateDiscount(13.72M, 1, 0));
        }
    }
}