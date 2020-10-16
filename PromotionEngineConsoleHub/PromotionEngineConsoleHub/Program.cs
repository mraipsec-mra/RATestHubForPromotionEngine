using System;
using TextToAsciiArt;

namespace PromotionEngineConsoleHub
{
    class Program
    {
        static int Main(string[] args)
        {
            IArtWriter writer = new ArtWriter();
            var artSettings = new ArtSetting
            {
                ConsoleSpeed = 90,
                IsBreakSpace = true,
                SpaceWidth = 3,
                Text = "|",
                BgText = " "
            };
            writer.WriteConsole("Promotion Engine", artSettings);
            Console.ReadLine();
            return 0;
        }
    }
}
