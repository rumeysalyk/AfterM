
public class TestDelegate
{
    public delegate void Tester( int num );

    public Tester TestDelegateObject;

    public TestDelegate()
    {
        TestDelegateObject = ExampleFunction;
        TestDelegateObject( 1254 );
        TestDelegateObject?.Invoke( 1254 );
    }

    public void ExampleFunction( int a_num )
    {
        Console.WriteLine( "Tested delegate" + a_num );
    }
}