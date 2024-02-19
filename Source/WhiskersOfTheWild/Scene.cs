using System.Windows;

namespace Whiskers_Of_The_Wild.Source.WhiskersOfTheWild
{
    public abstract class Scene(string name)
    {
        private readonly string _name = name.ToLower();

        public abstract void Build();

        public Window GetWindow() => WindowDisplay.GetWindow();

        public Application GetApplication() => WindowDisplay.GetApplication();

        public string GetName() => _name;
    }
}
