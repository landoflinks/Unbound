using System;
using System.Net;
using System.Windows;
using System.Xml;

namespace Unbound
{
    class Coords
    {
        // Variables
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public Coords()
        {
            Latitude = 41.850033;
            Longitude = -87.6500523;
        }

        // Get the lat/long out of the provided XML.
        public void GetCoordinates(XmlDocument document)
        {
            // Parse out Latitude.

            // Parse out Longitude.
        }

        // Parse the provided coordinate out of the document.
        private double ParseLatLong(XmlDocument document, string coordinate)
        {

            return Convert.ToDouble(coordinate);
        }
    }
}
