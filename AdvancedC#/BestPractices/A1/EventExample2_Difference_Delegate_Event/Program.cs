namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Restaurant restaurant = new Restaurant();

            Table table = new Table();

            
            restaurant.Customer += table.BookTable;//dont use only = operator with event

            restaurant.AddCustomer( "Nazım Hikmet" );

            System.Threading.Thread.Sleep(5000);
        }
    }
}
