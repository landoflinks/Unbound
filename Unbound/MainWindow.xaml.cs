using System;
using System.Net;
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

        // Geocodes an address and finds its lat/long.
        public XmlDocument FindCoords(string address)
        {
            string mapKey = "AlUeSTQVv9GwuYMLV1Iyp3aiOgetXonrVPy8lFwNo5OBNqYQkKudpzbPm7FbURCg";

            // Create a REST geocode request using the MS Locations API.
            string request = "http://dev.virtualearth.net/REST/v1/Locations/" + address + "?o=xml&key=" + mapKey;

            // Send the request.
            XmlDocument response = GetResponse(request);

            MessageBox.Show(response.ToString());

            return (response);
        }

        // Submit the REST geocode request and grab a response.
        private XmlDocument GetResponse(string url)
        {
            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
            {
                if (response.StatusCode != HttpStatusCode.OK)
                    throw new Exception(String.Format("Server error (HTTP {0}: {1}).",
                    response.StatusCode,
                    response.StatusDescription));
                XmlDocument document = new XmlDocument();
                document.Load(response.GetResponseStream());
                return document;
            }
        }
    }
}
