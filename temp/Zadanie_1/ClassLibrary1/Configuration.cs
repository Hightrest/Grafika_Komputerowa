using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public static class Configuration
    {
        public static string ConnectionString { get => @"Data Source=COMPHT\hp;Initial Catalog=Northwind;Integrated Security=True"; }
    }
}
