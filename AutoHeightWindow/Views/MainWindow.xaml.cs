using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace AutoHeightWindow.Views
{
    public class MainWindow : AutoHeightWindow
    {
        public MainWindow()
        {
            this.Width = 300;
            this.CanResize = false;
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            InitializeComponent();

            // Assign MainPanel for window measurement
            MainPanel = this.Find<StackPanel>("MainPanel");
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        private void AddTextBlock(object sender, object args)
        {
            TextBlock newRow = new TextBlock();
            newRow.Text = "I'm a new row!";

            this.Find<StackPanel>("TextBlocks").Children.Add(newRow);

        }
    }
}
