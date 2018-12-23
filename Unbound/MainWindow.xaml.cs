using System.Windows;
using Microsoft.Maps.MapControl.WPF;

namespace Unbound
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Switches between map layers.
        private void btn_mapChange_Click(object sender, RoutedEventArgs e)
        {
            if (unboundMap.Mode.ToString() == "Microsoft.Maps.MapControl.WPF.RoadMode")
            {
                // Switch to Aerial/Satellite map with labels.
                unboundMap.Mode = new AerialMode(true);
                btn_mapChange.Content = "Road";
            }
            else
            {
                // Switch to the standard road map.
                unboundMap.Mode = new RoadMode();
                btn_mapChange.Content = "Satellite";
            }
        }

        // Manually zooms the map inward.
        private void btn_zoomIn_Click(object sender, RoutedEventArgs e)
        {
            unboundMap.ZoomLevel += 1;
        }

        // Manually zooms the map outward.
        private void btn_zoomOut_Click(object sender, RoutedEventArgs e)
        {
            unboundMap.ZoomLevel -= 1;
        }
    }
}
