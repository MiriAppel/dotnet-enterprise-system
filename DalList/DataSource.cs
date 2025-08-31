using DalApi;
using DO;

namespace Dal;

internal static class DataSource
{
    /// <summary>
    /// רשימות עבור הישויות
    /// </summary>
    internal static List<Product?> Products = new List<Product?>();
    internal static List<Sale?> Sales = new List<Sale?>();
    internal static List<Customer?> Customers = new List<Customer?>();

    /// <summary>
    /// מחלקה ליצירת מספרים אוטומטיים
    /// </summary>
    internal static class Config
    {
        internal const int ProductMinCode = 100;
        internal const int SaleMinCode = 200;

        private static int ProductIndex = ProductMinCode;
        private static int SaleIndex = SaleMinCode;

        public static int ProductId
        {
            get
            {
                return ProductIndex++;
            }
        }
        public static int SaleId
        {
            get
            {
                return SaleIndex++;
            }
        }
    }
}
