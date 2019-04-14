using System;
using System.Net;
using System.Threading.Tasks;
using Microsoft.Maps.MapControl.WPF;

namespace Unbound.Models
{
    class UnboundModel
    {
        private const string key = "AlUeSTQVv9GwuYMLV1Iyp3aiOgetXonrVPy8lFwNo5OBNqYQkKudpzbPm7FbURCg";
        public Map Map { get; }

        public string Key
        {
            get { return key; }
        }

        public UnboundModel(Map map)
        {
            Map = map;
            //LoadMap();
        }

        private void LoadMap()
        {
            Map.Mode = new RoadMode();
            Map.ZoomLevel = 4;
        }
    }
}
