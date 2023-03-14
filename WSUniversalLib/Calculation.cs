using System;

namespace WSUniversalLib
{
    public class Calculation
    {
        public static int GetQuantityForProduct(int productType, int materialType, int count, float width, float length)
        {
            double koeffProductType, koeffMaterialType;

            if (width <= 0 || length <= 0 || count <= 0)
            {
                return -1;
            }

            switch(productType)
            {
                case 1:
                    koeffProductType = 1.1;
                    break;
                case 2:
                    koeffProductType = 2.5;
                    break;
                case 3:
                    koeffProductType = 8.43;
                    break;
                default:
                    return -1;
            }

            switch (materialType)
            {
                case 1:
                    koeffMaterialType = 1.003;
                    break;
                case 2:
                    koeffMaterialType = 1.0012;
                    break;
                default:
                    return -1;
            }

            double square = width * length;
            int quantity = (int)Math.Ceiling(count * square * koeffMaterialType * koeffProductType);
            return quantity;
        }
    }
}
