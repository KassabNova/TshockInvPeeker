using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TShockInvPeeker.Data
{
    public class Item
    {
        public ushort itemID { get; set; }
        public byte prefixID { get; set; }
        public string itemName { get; set; }
        public string prefixName { get; set; }
        public ushort ammount { get; set; }

    }
}
