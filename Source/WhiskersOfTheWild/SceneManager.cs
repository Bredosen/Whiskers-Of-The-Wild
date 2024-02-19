namespace Whiskers_Of_The_Wild.Source.WhiskersOfTheWild
{
    public class SceneManager
    {

        private static readonly HashSet<Scene> _sceneMatrix = new();

        private static string _activeScene = "";

        public static void SetActiveScene(string activeScene) => _activeScene = activeScene;

        public static string GetActiveScene() => _activeScene;

        public static void Register(Scene scene)
        {
            if (Contains(scene.GetName())) throw new Exception("Scene with given name already exists!");

            GetScenes().Add(scene);
        }

        public static bool Contains(string sceneName)
        {
            foreach (Scene scene in GetScenes()) if (scene.GetName().Equals(sceneName.ToLower())) return true;
            return false;
        }

        public static Scene Retrieve(string sceneName)
        {
            foreach (Scene scene in GetScenes()) if (scene.GetName().Equals(sceneName.ToLower())) return scene;
            throw new NullReferenceException("Could not retrieve scene with given name.");
        }

        public static HashSet<Scene> GetScenes() => _sceneMatrix;
    }
}
