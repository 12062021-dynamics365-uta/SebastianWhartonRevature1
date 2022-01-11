using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Storage
{
    public interface IDBAccess
    {
        public void confirmCust(string Username1, string Password1);
        public void addCust(string Username2, string Password2);
        public void confirmAdmin(string Username3, string Password3);
        public void getStores();



        //public List<Products> getStoreProducts(int store_id);

        public void addToCart(string StoreSelect);

        public void removeFromCart();

        public void clearCart();

        //public void clearCart();



        public void getInventory(string Inventory);

        public void getAdmins(string Admins);
        //List<Customer> GetCustomers();
    }
}
