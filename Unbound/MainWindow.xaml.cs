using System.Windows;
using Microsoft.Maps.MapControl.WPF;

namespace Unbound
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Sets focus on map (Allows use of +/- keys).
            unboundMap.Focus();
        }

        private void btn_mapChange_Click(object sender, RoutedEventArgs e)
        {
            // Switch between map types.
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
    }
}
