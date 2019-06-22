using System;
using System.Collections.Generic;
using System.Text;
using Discord.WebSocket;

namespace DiscordBotCore.Discord.Entities
{
    class DiscordBotConfig
    {
        public string Token { get; set; }
        public DiscordSocketConfig SocketConfig { get; set; }
    }
}
