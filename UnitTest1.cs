namespace LB1_TPR
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCalculation_type1()
        {
            decimal amount = 16.04M;
            int type = 1;
            int years = 6;
            decimal expected = 16.04M;
            DiscountManager discountManager = new DiscountManager();

            decimal actual = discountManager.CalculateDiscount(amount, type, years);
            Assert.AreEqual(expected, actual, 0, "t1");
        }
        [TestMethod]
        public void TestCalculation_type2()
        {
            decimal amount = 13.72M;
            int type = 2;
            int years = 13;
            decimal expected = 11.7306M;
            DiscountManager discountManager = new DiscountManager();

            decimal actual = discountManager.CalculateDiscount(amount, type, years);
            Assert.AreEqual(expected, actual, 0, "t2");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidUserTypeException),
         "Неправильний тип користувача.")]
        public void TestCalculation_WrongTypeInput()
        {
            decimal amount = 13.72M;
            int type = 5;
            int years = 13;
            DiscountManager discountManager = new DiscountManager();

            discountManager.CalculateDiscount(amount, type, years);

        }

    }
}
