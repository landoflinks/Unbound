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
        //private Map _mainMap;

        private void RoadMode(Map mapName)
        {
            mapName.Mode = new RoadMode();
        }
        private void AerialMode(Map mapName)
        {
            mapName.Mode = new AerialMode(true);
        }
    }
}
