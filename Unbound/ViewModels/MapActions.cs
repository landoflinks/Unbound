using System.Windows.Input;
using Microsoft.Maps.MapControl.WPF;

namespace Unbound.ViewModels
{
    public class MapActions : BaseProperty
    {
        Map _mapName;

        private void RoadMode()
        {
            _mapName.Mode = new RoadMode();
        }
        private void AerialMode()
        {
            _mapName.Mode = new AerialMode(true);
        }
        public ICommand RoadMap
        {
            get { return new BaseCommand(RoadMode); }
        }

        public ICommand AerialMap
        {
            get { return new BaseCommand(AerialMode); }
        }

    }
}
