using System;


namespace ConsoleApp1
{
    public class Restaurant
    {
        public delegate void NewCustomer( string a_customer );
        public event NewCustomer Customer;


        public void AddCustomer( string a_customerName )
        {
            Customer?.Invoke( a_customerName );
        }
    }
    

    public class Table
    {
        public void BookTable( string a_customerName )
        {
            Console.WriteLine( $"{ a_customerName} booked a table" );
        }
    }


}
