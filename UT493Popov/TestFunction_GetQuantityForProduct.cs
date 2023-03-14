using Microsoft.VisualStudio.TestTools.UnitTesting;
using WSUniversalLib;

namespace UT493Popov
{
    [TestClass]
    public class TestFunction_GetQuantityForProduct
    {

        [TestMethod]
        public void GetQuantityForProduct_NonExistentProductType()
        {
            float width = 20, length = 45;
            int productType = 4, materialType = 1, count = 15, quantity;
            int expected = -1;

            quantity = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);

            Assert.AreEqual(expected, quantity);
        }

        [TestMethod]
        public void GetQuantityForProduct_NonExistentMaterialType()
        {
            float width = 20, length = 45;
            int productType = 3, materialType = 3, count = 15, quantity;
            int expected = -1;
  
            quantity = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);

            Assert.AreEqual(expected, quantity);
        }

        [TestMethod]
        public void GetQuantityForProduct_ProductType1()
        {
            float width = 10, length = 20;
            int productType = 1, materialType = 1, count = 10, quantity;
            int expected = 2207;

            quantity = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);

            Assert.AreEqual(expected, quantity);
        }

        [TestMethod]
        public void GetQuantityForProduct_ProductType2()
        {
            float width = 10, length = 20;
            int productType = 2, materialType = 1, count = 10, quantity;
            int expected = 5015;

            quantity = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);

            Assert.AreEqual(expected, quantity);
        }

        [TestMethod]
        public void GetQuantityForProduct_ProductType3()
        {
            float width = 10, length = 20;
            int productType = 3, materialType = 1, count = 10, quantity;
            int expected = 16911;

            quantity = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);

            Assert.AreEqual(expected, quantity);
        }

        [TestMethod]
        public void GetQuantityForProduct_MaterialType1()
        {
            float width = 10, length = 20;
            int productType = 3, materialType = 1, count = 10, quantity;
            int expected = 16911;

            quantity = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);

            Assert.AreEqual(expected, quantity);
        }

        [TestMethod]
        public void GetQuantityForProduct_MaterialType2()
        {
            float width = 10, length = 20;
            int productType = 3, materialType = 2, count = 10, quantity;
            int expected = 16881;

            quantity = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);

            Assert.AreEqual(expected, quantity);
        }

        [TestMethod]
        public void GetQuantityForProduct_ImpossibleWidth()
        {
            float width = -10, length = 20;
            int productType = 1, materialType = 1, count = 10, quantity;
            int expected = -1;

            quantity = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);

            Assert.AreEqual(expected, quantity);
        }

        [TestMethod]
        public void GetQuantityForProduct_ImpossibleLength()
        {
            float width = 10, length = -20;
            int productType = 1, materialType = 1, count = 10, quantity;
            int expected = -1;

            quantity = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);

            Assert.AreEqual(expected, quantity);
        }

        [TestMethod]
        public void GetQuantityForProduct_ImpossibleCount()
        {
            float width = 10, length = 20;
            int productType = 1, materialType = 1, count = -10, quantity;
            int expected = -1;

            quantity = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);

            Assert.AreEqual(expected, quantity);
        }
    }
}
