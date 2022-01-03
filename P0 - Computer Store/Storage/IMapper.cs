using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Storage
{
    internal interface IMapper
    {
        public int EntToCustomer(SqlDataReader dataReader);

        //List<CartList> EntToCart(SqlDataReader dataReader);

        public int EntityToStores(SqlDataReader dataReader);

        
    }
}
