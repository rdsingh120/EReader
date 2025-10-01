using DotNetEnv;
using System.Windows;

namespace EReader
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            Env.Load();
            base.OnStartup(e);
        }
    }

}
