using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maps.MapControl.WPF;

namespace Unbound.ViewModels
{
    public class MapActions : BaseProperty
    {
        private void ChangeMapMode(Map name, string mapMode)
        {
            switch (mapMode)
            {
                case "Aerial":
                    name.Mode = new AerialMode(false);
                    break;
                case "AerialWithLabels":
                    name.Mode = new AerialMode(true);
                    break;
                case "Road":
                    name.Mode = new RoadMode();
                    break;
                default:
                    name.Mode = new RoadMode();
                    break;
            }
        }
    }
}
