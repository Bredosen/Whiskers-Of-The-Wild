using System.Windows;

namespace Whiskers_Of_The_Wild.Source.WhiskersOfTheWild
{
    public class WindowDisplay
    {

        private static readonly Application _application = new();
        private static readonly Window _window = new();

        public static void RunWindow()
        {
            GetApplication().Run(GetWindow());
        }


        public static Application GetApplication() => _application;

        public static Window GetWindow() => _window;
    }
}
