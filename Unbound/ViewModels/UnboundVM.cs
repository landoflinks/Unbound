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
    }
}
