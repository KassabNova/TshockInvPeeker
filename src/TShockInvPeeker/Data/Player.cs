using System;

namespace TShockInvPeeker.Data
{
    public class Player
    {
        public byte ID { get; set; }
        public string Username { get; set; }
        public string Group { get; set; }
        public short MaxHP { get; set; }
        public short MaxMana { get; set; }
        public string Inventory { get; set; }
    }
}
