using System;

namespace DTO_Northwnd_Products
{
    public class DTO_Northwnd_Products
    {
        private int ProductID;
        private string ProductName;
        private int SupplierID;
        private int CategoryID;
        private string QuantityPerUnit;
        private double UnitPrice;
        private int UnitsInStock;
        private int UnitsOnOrder;
        private int ReorderLevel;
        private bool Discontinued;

        public int ProductID1 { get => ProductID; set => ProductID = value; }
        public string ProductName1 { get => ProductName; set => ProductName = value; }
        public int SupplierID1 { get => SupplierID; set => SupplierID = value; }
        public int CategoryID1 { get => CategoryID; set => CategoryID = value; }
        public string QuantityPerUnit1 { get => QuantityPerUnit; set => QuantityPerUnit = value; }
        public double UnitPrice1 { get => UnitPrice; set => UnitPrice = value; }
        public int UnitsInStock1 { get => UnitsInStock; set => UnitsInStock = value; }
        public int UnitsOnOrder1 { get => UnitsOnOrder; set => UnitsOnOrder = value; }
        public int ReorderLevel1 { get => ReorderLevel; set => ReorderLevel = value; }
        public bool Discontinued1 { get => Discontinued; set => Discontinued = value; }

        public DTO_Northwnd_Products(int ProductID2, string ProductName2, int SupplierID2, int CategoryID2, string QuantityPerUnit2, double UnitPrice2, int UnitsInStock2, int UnitsOnOrder2, int ReorderLevel2, bool Discontinued2)
        {
            this.ProductID = ProductID2;
            this.ProductName = ProductName2;
            this.SupplierID = SupplierID2;
            this.CategoryID = CategoryID2;
            this.QuantityPerUnit = QuantityPerUnit2;
            this.UnitPrice = UnitPrice2;
            this.UnitsInStock = UnitsInStock2;
            this.UnitsOnOrder = UnitsOnOrder2;
            this.ReorderLevel = ReorderLevel2;
            this.Discontinued = Discontinued2;
        }
    }
}
