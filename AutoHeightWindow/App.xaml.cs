using Avalonia;
using Avalonia.Markup.Xaml;

namespace AutoHeightWindow
{
    public class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
