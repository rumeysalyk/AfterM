using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Restaurant
    {
        private readonly List<string> m_customers = new List<string>();
        public static event Action<string> NewCustomer; 
        public void AddCustomer( string a_customerName )
        {
            m_customers.Add( a_customerName );
            NewCustomer?.Invoke( a_customerName );
        }
    }
    
    public class Reception
    {
        public Reception()
        {
            Restaurant.NewCustomer += ChargeWaiter;
        }
        
        public void ChargeWaiter( string a_customerName )
        {
            Console.WriteLine( $"Charged a waiter for {a_customerName}" );
        }
    }

    public class Table
    {

        public Table()
        {
            Restaurant.NewCustomer += BookTable;
        }
        public void BookTable( string a_customerName )
        {
            Console.WriteLine( $"{ a_customerName} booked a table" );
        }
    }


}
