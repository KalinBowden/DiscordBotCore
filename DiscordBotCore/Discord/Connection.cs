using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.WebSocket;
using DiscordBotCore.Discord.Entities;

namespace DiscordBotCore.Discord
{
    class Connection
    {
        private DiscordSocketClient _client;
        private DiscordLogger _logger;


        public Connection(DiscordBotConfig config)
        {
            _client = new DiscordSocketClient(config.SocketConfig);
        }


        public Connection(DiscordLogger logger)
        {
            _logger = logger;
        }


        internal async Task ConnectAsync(DiscordBotConfig config)
        {
            _client = new DiscordSocketClient(config.SocketConfig);

            _client.Log += Log;
        }

        private Task Log(LogMessage arg)
        {
            throw new NotImplementedException();
        }
    }
}
