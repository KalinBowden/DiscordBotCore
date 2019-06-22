using System;
using System.Collections.Generic;
using System.Text;

namespace DiscordBotCore.Models
{
    class Plant : Item
    {
        //
        public int Health { get; set; } = 100;
        public int GrowthPercentage { get; set; } = 0;
        public int HydrationLevel { get; set; } = 0;
        public int SoilQuaility { get; set; } = 100;

        //
        public bool IsHarvestable { get; set; } = false;
    }
}
