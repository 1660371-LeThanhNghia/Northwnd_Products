using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DAL_Northwnd_Products
{
    class DBConnect
    {
        private SqlConnection _conn = new SqlConnection(@"Data Source=DESKTOP-OL81NRF\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True;");
    }

    
}