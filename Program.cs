namespace LB1_TPR { 
    public class DiscountManager
    {
        public decimal CalculateDiscount(decimal amount, int type, int years)
        {
            decimal result = 0;
            decimal disc = (years > 5) ? (decimal)5 / 100 : (decimal)years / 100;
            if (type == 1)
            {
                result = amount;
            }
            else if (type == 2)
            {
                result = (amount - (0.1m * amount)) - disc * (amount - (0.1m * amount));
            }
            else if (type == 3)
            {
                result = (0.7m * amount) - disc * (0.7m * amount);
            }
            else if (type == 4)
            {
                result = (amount - (0.5m * amount)) - disc * (amount - (0.5m * amount));
            }
            else
            {
                return -1;
            }
            return result;
        }

        public static void Main() 
        {
            DiscountManager clc = new DiscountManager();
            Console.WriteLine(clc.CalculateDiscount(13.72M, 1, 0));
        }
    }
}