using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Newtonsoft.Json;
using NUnit.Framework;

namespace UIFrameworkBase.Settings
{
    public class SettingsLoader
    {
        public static Settings LoadSettings()
        {
            var directory = TestContext.CurrentContext.TestDirectory;
            var fileInput = File.ReadAllText(Path.Combine(directory, "Settings.json"));
            var settings = new Settings();
           
            JsonConvert.PopulateObject(fileInput, settings);


            Console.WriteLine($"Settings: {settings.ChromeBinaryPath}; {settings.BaseUrl}" );

            return settings;
        }
    }
}