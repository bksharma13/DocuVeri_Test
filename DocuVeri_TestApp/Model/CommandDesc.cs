using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocuVeri_TestApp.Model
{
    public class CommandDesc
    {
        private static Dictionary<string, string> CommandList = new Dictionary<string, string>();

        static CommandDesc()
        {
            // Possible Hot temp Commands
            CommandList.Add("1H", "Sandals");
            CommandList.Add("2H", "Sun visor");
            CommandList.Add("4H", "T-shirt");
            CommandList.Add("6H", "Shorts");
            CommandList.Add("7H", "Leaving house");
            CommandList.Add("8H", "Removing PJs");

            // Possible Cold temp Commands
            CommandList.Add("1C", "Boots");
            CommandList.Add("2C", "Hat");
            CommandList.Add("3C", "Socks");
            CommandList.Add("4C", "Shirt");
            CommandList.Add("5C", "Jacket");
            CommandList.Add("6C", "Pants");
            CommandList.Add("7C", "Leaving house");
            CommandList.Add("8C", "Removing PJs");
        }

        public static string GetCommandDec(string key)
        {
            if (!CommandList.Keys.Contains(key))
            {
                return null;
            }

            return CommandList[key];
        }
    }
}
