﻿using System;
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
                btn_mapChange.Content = "Aerial";
            }
        }

        #region Find Button
        // Accesses the FindCoords and GetResponse methods to do a successful map search.
        // This is temporary until bindings can be better implemented.
        private void Btn_find_Click(object sender, RoutedEventArgs e)
        {
            XmlDocument coords;
            Location destination = new Location();

            // Send the request for the coordinates.
            coords = FindCoords();

             // Parse out Latitude.
             destination.Latitude = ParseLatLong(coords.InnerXml, "Latitude");

             // Parse out Longitude.
             destination.Longitude = ParseLatLong(coords.InnerXml, "Longitude");

            unboundMap.SetView(destination, 14);
        }

        #region FindCoords
        // Geocodes an address and finds its lat/long.
        public XmlDocument FindCoords()
        {
            string address = SearchTextBox.Text;
            string mapKey = "AlUeSTQVv9GwuYMLV1Iyp3aiOgetXonrVPy8lFwNo5OBNqYQkKudpzbPm7FbURCg";

            // Create a REST geocode request using the MS Locations API.
            string request = "http://dev.virtualearth.net/REST/v1/Locations/" + address + "?o=xml&maxResults=10&key=" + mapKey;

            // Send the request.
            XmlDocument response = GetResponse(request);

            return (response);
        }
        #endregion

        #region GetResponse
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
        #endregion

        #region ParseLatLong
        // Parse the provided coordinate string out of the document.
        private double ParseLatLong(string document, string coordinate)
        {
            int start = document.LastIndexOf("<" + coordinate + ">") + ("<" + coordinate + ">").Length;
            int end = document.LastIndexOf("</" + coordinate + ">");
            string data = document.Substring(start, end - start);

            return Convert.ToDouble(data);
        }
        #endregion
        #endregion
    }
}
