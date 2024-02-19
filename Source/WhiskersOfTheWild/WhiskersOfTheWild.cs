namespace Whiskers_Of_The_Wild.Source.WhiskersOfTheWild
{
    public partial class WhiskersOfTheWild
    {

        public void Initialize()
        {
        }

        public void Terminate()
        {

        }

    }

    public partial class WhiskersOfTheWild
    {
        private static readonly WhiskersOfTheWild _instance = new();

        private WhiskersOfTheWild() { }

        [STAThread]
        public static void Main()
        {
            GetInstance().Initialize();
            GetInstance().Terminate();
        }

        public static WhiskersOfTheWild GetInstance() => _instance;
    }
}
