using System;
using System.Windows;
using System.Xml;
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
        private void Btn_mapChange_Click(object sender, RoutedEventArgs e)
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
        private void Btn_zoomIn_Click(object sender, RoutedEventArgs e)
        {
            unboundMap.ZoomLevel += 1;
        }

        // Manually zooms the map outward.
        private void Btn_zoomOut_Click(object sender, RoutedEventArgs e)
        {
            unboundMap.ZoomLevel -= 1;
        }

        // Returns the latitude/longitude for a location.
        private void MapSearch()
        {
            string address;
            string mapKey = "AlUeSTQVv9GwuYMLV1Iyp3aiOgetXonrVPy8lFwNo5OBNqYQkKudpzbPm7FbURCg";

            address = SearchTextBox.Text;

            //Send REST request using the Microsoft Locations API.
            string request = "http://dev.virtualearth.net/REST/v1/Locations/" + address + "?o=xml&key=" + mapKey;

            //Grab the response.
            //XmlDocument response = GetXmlResponse(request);
        }
    }
}
