using System.IO;

namespace EntityManager.Utility
{
    public static class FilePath
    {
        private static string FindFilePathRecursive(string fileName, string path)
        {
            foreach (var directory in Directory.EnumerateDirectories(path))
            {
                if (Path.GetFileName(directory) == "Data")
                {
                    return Path.Combine(directory, fileName);
                }
            }

            var parentPath = Directory.GetParent(path);

            if (parentPath != null)
            {
                return FindFilePathRecursive(fileName, parentPath.FullName);
            }

            return string.Empty;
        }

        public static string GetMonsterFilePath()
        {
            return FindFilePathRecursive("monster.json", Directory.GetCurrentDirectory());
        }

        public static string GetSpellFilePath()
        {
            return FindFilePathRecursive("spell.json", Directory.GetCurrentDirectory());
        }

        public static string GetEquipmentFilePath()
        {
            return FindFilePathRecursive("equipment.json", Directory.GetCurrentDirectory());
        }

        public static string GetRaceFilePath()
        {
            return FindFilePathRecursive("race.json", Directory.GetCurrentDirectory());
        }

        public static string GetClassFilePath()
        {
            return FindFilePathRecursive("class.json", Directory.GetCurrentDirectory());
        }

        public static string GetBackgroundFilePath()
        {
            return FindFilePathRecursive("background.json", Directory.GetCurrentDirectory());
        }
    }
}