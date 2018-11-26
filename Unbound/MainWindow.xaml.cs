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

        private void btn_mapChange_Click(object sender, RoutedEventArgs e)
        {
            if (unboundMap.Mode.ToString() == "Microsoft.Maps.MapControl.WPF.RoadMode")
            {
                unboundMap.Mode = new AerialMode(true);
                btn_mapChange.Content = "Road";
            }
            else
            {
                unboundMap.Mode = new RoadMode();
                btn_mapChange.Content = "Satellite";
            }
        }
    }
}
