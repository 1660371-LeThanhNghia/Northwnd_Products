using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL_Northwnd_Products;
using DTO_Northwnd_Products;

namespace BUS_Northwnd_Products
{
    public class BUS_Northwnd_Products
    {
        DAL_Northwnd_Products dalNorthwnd_Products = new DAL_Northwnd_Products();
        public DataTable getNorthwnd_Products()
        {
            return dalNorthwnd_Products.getNorthwnd_Products();
        }

        public bool insertNorthwnd_Products()
        {
            return dalNorthwnd_Products.insertNorthwnd_Products()
        }

        public bool updateNorthwnd_Products()
        {
            return dalNorthwnd_Products.updateNorthwnd_Products()
        }

        public bool deleteNorthwnd_Products()
        {
            return dalNorthwnd_Products.deleteNorthwnd_Products()
        }
    }
}
