using System.Text.Json;

namespace Projekt_AWzorek_167366
{
    internal static class Program
    {
       public static AppConfig? Config { get; set; }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            string fileName = "config.json";
            
            string rawData = File.ReadAllText(fileName);

            var settings = JsonSerializer.Deserialize<AppConfig>(rawData);

            if (settings== null)
            {
                // If deserialization fails, create a default config
                var newSettings = new AppConfig("Segoe UI", 800, 600, "#FFFFFF");
                File.WriteAllText(fileName, JsonSerializer.Serialize(newSettings));
            }
            Config = settings;

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}