using System;
using System.Collections.Generic;
using System.Text;

namespace DiscordBotCore
{
    class Item
    {
        //
        public string ID { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }

        //
        public float Cost { get; set; }
        public float Value { get; set; }

        //
        public bool IsSellable { get; set; }
        public bool IsBuyable { get; set; }
        public bool CanMultiple { get; set; }
        
    }
}
