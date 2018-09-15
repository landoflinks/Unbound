﻿using System.Windows.Input;
using Microsoft.Maps.MapControl.WPF;
using Unbound.Models;

namespace Unbound.ViewModels
{
    public class MapActions : BaseProperty
    {
        MapInfo mapData = new MapInfo();
        private readonly Map _mapName = mapData.name;
         
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
