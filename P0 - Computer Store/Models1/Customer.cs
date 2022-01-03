using System;

namespace Models1
{
    public class Customer
    {
        public List<Customer> customers; //new customers
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public Customer currentUser;


        public Customer(string custUser, string custPass)
        {
            custuser = Username;
            custpassword = Password;
        }

        public void custLogin(string custUser, string custPass)
        {
            //create method to confirm login
            

        }




    }
}
