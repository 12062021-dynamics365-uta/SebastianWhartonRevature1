using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Storage
{
    public class Mapper : IMapper
    {
        public int EntToCustomer(SqlDataReader dataReader)
        {
            int customer_id = 0;
            string username1 = " ";
            string password1 = " ";

            while (dataReader.Read())
            {
                Customer newCust = new Customer(username1, password1)
                {
                    customer_id = customer_id,
                }
                    customer_id
            }
        }

        public List<CartList> EntToCart(SqlDataReader dataReader)
        {
            throw new NotImplementedException();
        }





        //Mark example
        public List<Stores> EntityToStores(SqlDataReader dataReader)
        {
            List<Stores> Store = new List<Stores>();
            while (dataReader.Read())
            {
                Stores s = new Stores()
                {
                    store_id = Convert.ToInt32(dataReader[0].ToString()),
                    store_locations = dataReader[1].ToString(),
                };
                Stores.Add(s);
            }
            return Store;
        }






    }
}
