namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperMario superMario = new SuperMario();

            Music music = new Music();

            Speed speed = new Speed();

            superMario.GainedMushroom += music.ChangeMusic;
            superMario.GainedMushroom += speed.SpeedUp;

            superMario.GainSpecialStar(20);

            System.Threading.Thread.Sleep(10000);
        }
    }
}
