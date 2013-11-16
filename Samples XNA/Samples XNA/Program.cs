namespace FarseerPhysics.SamplesFramework
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        private static void Main(string[] args)
        {
#if NETFX_CORE
              var factory = new MonoGame.Framework.GameFrameworkViewSource<FarseerPhysicsGame>();
            Windows.ApplicationModel.Core.CoreApplication.Run(factory);
#else
            using (FarseerPhysicsGame game = new FarseerPhysicsGame())
            {
                game.Run();
            }
#endif
        }
    }
}