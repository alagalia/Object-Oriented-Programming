namespace EnvironmentSystem
{
    using EnvironmentSystem.Core;

    public class EnvironmentSystemMain
    {
        static void Main()
        {
            var engine = new EnhancedEngine(new KeyControler());
            engine.Run();
        }
    }
}
