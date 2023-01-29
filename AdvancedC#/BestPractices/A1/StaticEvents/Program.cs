namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Restaurant restaurant = new Restaurant();

            Reception reception = new Reception();

            Table table = new Table();

            restaurant.AddCustomer("Nazım Hikmet");

            System.Threading.Thread.Sleep(5000);
        }
    }
}
