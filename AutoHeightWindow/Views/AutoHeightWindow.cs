using Avalonia;
using Avalonia.Controls;

namespace AutoHeightWindow
{
    public class AutoHeightWindow : Window
    {
        public StackPanel MainPanel;

        public AutoHeightWindow()
        {
            this.LayoutUpdated += AutoSizeHeight;
            this.VerticalAlignment = Avalonia.Layout.VerticalAlignment.Top;
        }

        public void AutoSizeHeight(object sender, System.EventArgs e)
        {
            MainPanel.Measure(new Size(this.DesiredSize.Width, double.PositiveInfinity));
            this.Height = MainPanel.DesiredSize.Height;
            this.InvalidateMeasure();
        }
    }
}
