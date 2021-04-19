using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Map
    {
        private string mapName;
        private string mapType;
        private string mapNumber;

        public string MapName { get => mapName; set => mapName = value; }
        public string MapType { get => mapType; set => mapType = value; }
        public string MapNumber { get => mapNumber; set => mapNumber = value; }
    }
}
