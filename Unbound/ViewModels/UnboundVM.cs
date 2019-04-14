using System;
using System.Threading.Tasks;
using Microsoft.Maps.MapControl.WPF;
using Unbound.Models;

namespace Unbound.ViewModels
{
    class UnboundVM : BaseVM
    {
        private Map mapObject;
        private UnboundModel unboundModel;
        private double zoom;
        private string locationSearch;
        private string selectedMapMode;
        private bool appIsSearching;

        public string MapKeyKey
        {
            get { return unboundModel.Key; }
        }

       /* public Map MapObject
        {
            get { return mapObject; }
            set
            {
                mapObject = new UnboundModel();

                Zoom = mapObject.Map.ZoomLevel;
            }
        } */

        public string SelectedMapMode
        {
            get { return selectedMapMode; }
        }

        public double Zoom
        {
            get { return zoom; }
        }
    }
}
