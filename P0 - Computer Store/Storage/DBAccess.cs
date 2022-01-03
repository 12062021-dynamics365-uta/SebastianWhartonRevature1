using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage
{

    //establish db connection
    public class DBAccess //: IDBAccess
    {
        readonly string db = "Data source = SEBASTIANPC\\SQLEXPRESS04; initial Catalog = ComputerWarehouse; integrated security = true";
        public readonly SqlConnection connect;
        //public readonly IMapper Mapper;

        public DBAccess()
        {
            this.connect = new SqlConnection(this.db);
            connect.Open();
            this.Mapper = new Mapper();
        }

        public void List<Stores> GetStores()
        {
            string sqlQuery = "SELECT * FROM Stores;";
            List<Stores> store = new List<Stores>();
            using (SqlCommand cmd = new SqlCommand(sqlQuery, this.connect))
            {
                SqlDataReader datareader = cmd.ExecuteReader();
                store = this.Mapper.EntityToStores(datareader);
                this.connect.Close();
            }
            return store;
        }








    }
 }




        //db methods

        //internal List<Customer> GetCustomers()
        //{
        //    string sqlQuery = "SELECT * FROM CustomerAccounts;";
        //    List<Customer> customers = new List<GetCustomers>();
        //    using (SqlCommand cmd = new SqlCommand(sqlQuery, this.connect)) ;
        //    {
        //        SqlDataReader db = connect.ExecuteReader();
        //        customers = this.Mapper.EntToCart(db);
        //        this.connect.Close();
        //    }
        //    return customers;
        //};




        //public void addCust(string Username, string Password)
        //{
        //    SqlCommand command;
        //    command = connect.CreateCommand();

        //    if(CustomerID > 0)
        //    {
        //        string queryString = "INSERT INTO Customers(cust_id, cust_user, cust_pass) VALUES ('" + cust_id + "', '" + cust_user + ", " + cust_pass + "');";
        //        //command.ExecuteNonQuery();

        //        using (command = new SqlCommand(query, connect))
        //        {
        //            using (SqlDataReader reader = command.ExecuteReader())
        //            {
        //                while (reader.Read())
        //                {
        //                    for (int i = 0; i < reader.FieldCount; i++)
        //                    {
        //                        Console.WriteLine(reader.GetValue(i));
        //                    }
        //                    Console.WriteLine();
        //                }
        //                reader.Close();
        //            }
        //        }
        //    }
            
        //}

        
        













//        public void GetStoreList()
//        {
//            dbconnection.Open();
//            SqlCommand cmd = new SqlCommand(queryString, dbconnection);
//            SqlDataReader dr = cmd.ExecuteReader();
//            while (dr.Read())
//            {
//                Console.WriteLine(dr.[0].ToString() + "   " + dr.[1].ToString() + "   " + dr.[2].ToString());
//            }
//            dbconnection.Close();
//        }

//        public void getUsername(string Username)
//        {
//            throw new NotImplementedException();
//        }

//        public void getPassword(string Password)
//        {
//            throw new NotImplementedException();
//        }

//        public void getStores()
//        {
//            throw new NotImplementedException();
//        }

//        public void getStoreMenu(string StoreSelect)
//        {
//            throw new NotImplementedException();
//        }

//        public void getCart()
//        {
//            throw new NotImplementedException();
//        }

//        public void getInventory(string Inventory)
//        {
//            throw new NotImplementedException();
//        }

//        public void getAdmins(string Admins)
//        {
//            throw new NotImplementedException();
//        }

//        string query2 = "SELECT CartID FROM ShoppingCart;";
//    }
//        using (SqlCommand cmd = new SqlCommand(query2, this.connect)){}


        
//    }
//}
