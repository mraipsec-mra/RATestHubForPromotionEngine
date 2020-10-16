using System;
using TextToAsciiArt;

namespace PromotionEngineConsoleHub
{
    /// <summary>
    /// Main Program
    /// </summary>
    class Program
    {
        /// <summary>
        /// Main Method
        /// </summary>
        /// <returns>An Integer</returns>
        static int Main()
        {
            IArtWriter writer;
            ArtSetting artSettings;
            PrintInAscii(out writer, out artSettings);
            Console.WriteLine("===================================================");
            writer.WriteConsole("Promotion Engine", artSettings);
            Console.WriteLine("===================================================");
            Console.ReadLine();
            return 0;
        }

        /// <summary>
        /// Print In Ascii Text
        /// </summary>
        /// <param name="writer">IWriter</param>
        /// <param name="artSettings">Art Settings</param>
        private static void PrintInAscii(out IArtWriter writer, out ArtSetting artSettings)
        {
            writer = new ArtWriter();
            artSettings = new ArtSetting
            {
                ConsoleSpeed = 90,
                IsBreakSpace = true,
                SpaceWidth = 1,
                Text = "|",
                BgText = " "
            };
        }
    }
}
