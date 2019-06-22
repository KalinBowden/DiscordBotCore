using System;
using DiscordBotCore.Discord;
using DiscordBotCore.Discord.Entities;

namespace DiscordBotCore
{
    class Program
    {
        //
        

        static void Main(string[] args)
        {
            DiscordUnity.RegisterTypes();
            Console.WriteLine("Hello Discord!");

            //
            var discordBotConfig = new DiscordBotConfig
            {
                Token = "ABC",
                SocketConfig = SocketConfig.GetDefault()
            };

            var connection = DiscordUnity.Resolve<Connection>();

            Console.ReadKey();
        }
    }
}
