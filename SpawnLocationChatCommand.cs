using System;
using Terraria.ModLoader;

namespace TrenycsChatCommands
{
    class SpawnLocationChatCommand : Terraria.ModLoader.ModCommand
    {
        public override CommandType Type
        {
            get { return CommandType.Chat; }
        }

        public override string Command
        {
            get { return "spawnloc"; }
        }

        public override string Usage
        {
            get { return "/spawnloc"; }
        }

        public override string Description
        {
            get { return "Displays the x, y coordinates of your current spawn location"; }
        }

        public override void Action(CommandCaller caller, string input, string[] args)
        {
            caller.Reply(
                String.Format(
                    @"spawnloc: {0}, {1}",
                        caller.Player.SpawnX, caller.Player.SpawnY
                )
            );
        }
    }
}
