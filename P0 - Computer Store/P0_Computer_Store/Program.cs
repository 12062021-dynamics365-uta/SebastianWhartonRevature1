using System;

namespace P0_Computer_Store
{ 

    public class Program
    {
        public static int CartID { get; set; }
        public static int ProductID { get; set; }
        public static int ProductQuantity { get; set; }
        public static float ItemTotal { get; set; }


        static void Main(string[] args)
        {
            //Uncomment later
            //Mapper mapper = new Mapper();
            DBAccess dba = new DBAccess();
            DataManager dm = new DataManager(dbaccess);


            //CartLogic cartLogic = new CartLogic(); //calling cart class
            Dbconnection database = new Dbconnection();


            bool logout = false;
            do //run until user logs out.
            {
                Console.WriteLine("Welcome to Computer Warehouse!");
                Console.WriteLine("------------------------------");
                Console.WriteLine("Have you shopped with us before?");
                Console.WriteLine("1) Yes");
                Console.WriteLine("2) No");
                Console.WriteLine("3) I'm an admin");
                string userCategory = Console.ReadLine();

                if (userCategory == "1")  //Returning Customer
                {
                    //add user input as variables and check customer accounts for existing account
                    Console.WriteLine("Please confirm user information.");
                    //Console.Write(GetStoreList());
                    Console.Write("Username: ");
                    string custUser = Console.ReadLine();  //creating customer username and password var
                    Console.Write("Password: ");
                    string custPass = Console.ReadLine();

                    Customer customerLogin = new Customer(custUser.ToLower, custPass.ToLower);
                    DBAccess customerConfirm = new DBAccess();

                    //CustomerID = customerConfirm.getCustomers    //active cust.getActiveCustID(customer username and password vars);


                    //Display Store table
                    if (customerLogin)
                    {
                        Console.WriteLine("Welcome back! Please select a location");
                        string storeSelect = Console.ReadLine();

                        //Display product table by store
                        if(storeSelect == "1") //For product pages -- price, product name, description
                        {
                            //Display products for Denver
                            Console.WriteLine("Below are the products in stock for Computer Warehouse in Denver.");
                            Console.WriteLine("Please select an item to add it to your cart");
                            Console.WriteLine("1) View Cart"); //Link to Cart display
                            //Insert Store table. First product starts with 2

                        }
                        else if(storeSelect == "2")
                        {
                            //Display products for Nashville
                            Console.WriteLine("Below are the products in stock for Computer Warehouse in Nashville.");
                            Console.WriteLine("Please select an item to add it to your cart");
                            Console.WriteLine("1) View Cart"); //Link to Cart display
                            //Insert Store table. First product starts with 2
                        }
                        else if (storeSelect == "3")
                        {
                            //Display products for Las Vegas
                            Console.WriteLine("Below are the products in stock for Computer Warehouse in Las Vegas.");
                            Console.WriteLine("Please select an item to add it to your cart");
                            Console.WriteLine("1) View Cart"); //Link to Cart display
                            //Insert Store table. First product starts with 2
                        }
                        else if (storeSelect == "4")
                        {
                            //Display products for Dallas
                            Console.WriteLine("Below are the products in stock for Computer Warehouse in Dallas.");
                            Console.WriteLine("Please select an item to add it to your cart");
                            Console.WriteLine("1) View Cart"); //Link to Cart display
                            //Insert Store table. First product starts with 2
                        }
                        else
                        {
                            Console.WriteLine("Invalid entry");
                            logout = true;
                        }

                        View Cart()
                            Console.WriteLine("Your cart");
                            //Add selections. Put this method in product pages
                    }
                    else
                    {
                        Console.WriteLine("Invalid entry");
                        logout = true;
                    }


                }
                else if (!customerLogin)
                {

                }

            }
            while (!logout);





            //If returning customer, returning customer, or admin

            //else if (userCategory == "2") //New Customer
            //{
            //    Console.WriteLine("Hello new customer");

            //}
            //else if (userCategory == "3")  //Admin
            //{
            //    Console.WriteLine("Please confirm administrator account");
            //    Console.ReadLine();

            //}
            //else
            //{
            //    Console.WriteLine("Error: Invalid input. Please try again.");

            //};














            //if ( custUser !=   )     //If in db (case insensitive)
            //{
            //  Console.WriteLine();
            //}
            //else                   //If not in db
            //{
            //    Console.WriteLine();
            //}











            // 0) Display Indicator





            // 1) If returning customer Display
            //////Console.WriteLine("Please confirm your account information.");
            //////Console.Write("Username: ");   
            //////string custUser = Console.ReadLine();
            //////Console.Write("Password: ");
            //////string custPass = Console.ReadLine();

            // 1.1) If matches customer records, continue to store selection Display
            // 1.2) If doesn't match customer records Display

            //if (custUser = )  // If = to value in username column in customer table
            //{
            //    Console.WriteLine();
            //    Console.ReadLine();
            //}
            //else
            //{
            //    Console.WriteLine();
            //    Console.ReadLine();
            //}












            Console.WriteLine("Login Unsuccessful. Incorrect account information. Please try again.");
            Console.WriteLine("Username: ");
            Console.WriteLine("Password: ");
            // Repeat this response until the user enters valid info
            // Once valid, continue to 1.1

            // 2) If new customer Display 
            Console.WriteLine("Please enter information to create a new account");
            Console.WriteLine("Username: ");
            Console.WriteLine("Password: ");
            //Add customer information to customer table

            //
            //
            //

            // 1.1) Store Selection Display
            // Display store selection table data
            // User selects a number- Taken to (1.3), a prompt specific to that store location which displays 
            // the product selection table.

            // 1.3) Product Selection Display
            // Check inventory table and make sure every item at this location that has at least 1 Quantity is displayed.
            // User selects 1) to view cart (1.4) or they select a number that corresponds to a product in the prompt.
            // the corresponding item is added to cart

            // When an item is selected, add the inventory id to
            // - customer cart,
            // - customer order history,
            // - store order history

            // 1.4) Cart Display
            // (1.4.1) 1- Checkout- Purchase all items in cart
            // (1.4.2) 2- Cancel Purchase - Exit to product selection 1.3 and clear cart
            // (1.4.3) 3-n Product price, name, and description. n is the number of options with unique IDs plus 2
            //             Orders must update customer order history, store order history, & inventory must adjust the quantity
            //         4- (not a selectable option) Display Order total (sum + 8.25% sales tax)


            // 1.4.1) Checkout Display

            // 1.4.2) Cancel Purchase Display



            //3) If Administrator Display
            //Console.WriteLine("Please confirm your account information.");
            //Console.Write("Username: ");   //add user input as variables and check admin accounts for existing account
            //string custUser Console.ReadLine();
            //Console.Write("Password: ");
            //string custPass Console.ReadLine();

            // 3.1) If existing Display- I would like to...
            //          3.1.1) Manage Inv- Display every product's name, price, store id, and quantity by using inventory id
            //                             Select product to adjust quantity, input number under 200 to select new quantity.
            //                             [Back] takes you to 3.1

            //          3.1.2) View past sales- Display store selection, then display selected location's order history. [Back] takes you to 3.1

            //          3.1.3) Sign Out [end]
            //


            //Make sure to end route with Console.ReadLine(); because this allows the final prompt to display rather than quickly exiting





            static void ConfirmUser()
            {
                Console.WriteLine();
            }






















            /*Prompts
            Returning Customer

            Console.WriteLine("Welcome back! Which location will you be shopping at today?");



            Console.WriteLine("Enjoy browsing our wide selection of computer components. Select an item's corresponding number to add it to your cart");
            Console.WriteLine("1)Purchase all items in cart");
            Console.WriteLine("2)Clear cart");
            Console.WriteLine("3)Price, Product name, Product description");

            1
            Console.WriteLine("Order complete. Order number is ____ . Thank you for shopping with us");
            Console.Readline();

            2
            Console.WriteLine("Your cart is now empty. Please select an item to add to your cart");















            */
        }
    }
}

