using System;
using System.Threading.Tasks;
using Microsoft.Maps.MapControl.WPF;
using Unbound.Models;

namespace Unbound.ViewModels
{
    class UnboundVM : BaseVM
    {
        private UnboundModel unboundModel;
        private double zoom;
        private string selectedMapMode;
        private bool appIsSearching;

        public string MapKeyKey
        {
            get { return unboundModel.Key; }
        }

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
