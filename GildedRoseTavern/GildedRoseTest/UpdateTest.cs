namespace GildedRoseTest
{
    [TestClass]
    public class UpdateTest
    {
        [TestMethod]
        public void Test1_WhenGivenProductReturnsUpdatedSellInValue()
        {
            Product myproduct = new Product("Bread", 35, 40);
            myproduct.UpdateProduct();
            Assert.AreEqual(34, myproduct.SellIn);


        }
        [TestMethod]
        public void Test2_WhenGivenProductReturnsUpdatedQualityValue()
        {
            Product myproduct = new Product("Bread", 35, 40);
            myproduct.UpdateProduct();
            Assert.AreEqual(39, myproduct.Quality);


        }
        [TestMethod]
        public void Test3_GivenQualitylessthanZeroReturnsZero()
        {
            Product cheese = new Product("cheese", 30, -5);
            cheese.UpdateProduct();
            Assert.AreEqual(0, cheese.Quality);
        }
        [TestMethod]
        public void Test4_GivenSellInValueZeroReturnsDoubleDecrease()
        {
            Product cheese = new Product("cheese", 0, 16);
            cheese.UpdateProduct();
            Assert.AreEqual(14, cheese.Quality);
        }
        [TestMethod]
        public void Test5_GivenAgedBrieReturnsEspecialQuality()
        {
            Product cheese = new Product("Aged Brie", 5, 16);
            cheese.UpdateProduct();
            Assert.AreEqual(17, cheese.Quality);
        }
        [TestMethod]
        public void Test6_GivenSulfurasReturnsSameQuality()
        {
            Product sulfuras = new Product("Sulfuras", 5, 16);
            sulfuras.UpdateProduct();
            Assert.AreEqual(80, sulfuras.Quality);
        }
        [TestMethod]
        public void Test7_GivenBackstagePassesReturnEspecialQuality()
        {
            Product passes = new Product("Backstage passes", 6, 16);
            passes.UpdateProduct();
            Assert.AreEqual(19, passes.Quality);
        }
        [TestMethod]
        public void Test8_GivenConjuredReturnsDoubleQualityDecrease()
        {
            Product conjured = new Product("Conjured", 6, 16,"a");
            conjured.UpdateProduct();
            Assert.AreEqual(14, conjured.Quality);
        }
        [TestMethod]
        public void Test9_GivenEmptyConjuredPropertyReturnsNormalDecrease()
        {
            Product conjured = new Product("Conjured", 6, 16, "");
            conjured.UpdateProduct();
            Assert.AreEqual(15, conjured.Quality);
        }
    }
}