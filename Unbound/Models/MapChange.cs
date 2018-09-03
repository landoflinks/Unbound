using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unbound.Models
{
    public class MapChange
    {
        private readonly Func<string, string> _mapMode;

        public MapChange(Func<string, string> mapMode)
        {
            _mapMode = mapMode;
        }

        public string ConvertText(string mode)
        {
            return _mapMode(mode);
        }
    }
}
