using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Discordbot.Modules
{
    public class ping : ModuleBase<SocketCommandContext>
    {
        [Command("ping")]
        public async Task PingAsync()
        {
            await ReplyAsync("Hello World!");
        }

        [Command("insult")]
        public async Task insultAsync()
        {
            await ReplyAsync("Jävla mögmaskin!");
        }
    }
}
