namespace XmobiTea.GearN.Helper
{
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json;

    public static class StorageService
    {
        private static string filePath = "storagePrefs.json";
        private static Dictionary<string, string> data { get; }

        static StorageService()
        {
            data = load();
        }

        public static void setString(string key, string value)
        {
            data[key] = value;

            save();
        }

        public static string getString(string key, string defaultValue = "")
        {
            return data.TryGetValue(key, out var value) ? value : defaultValue;
        }

        private static void save()
        {
            var json = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        private static Dictionary<string, string> load()
        {
            Dictionary<string, string> answer = null;

            if (File.Exists(filePath))
            {
                var json = File.ReadAllText(filePath);
                answer = JsonSerializer.Deserialize<Dictionary<string, string>>(json);
            }

            if (answer == null) answer = new Dictionary<string, string>();

            return answer;
        }
    }
}
