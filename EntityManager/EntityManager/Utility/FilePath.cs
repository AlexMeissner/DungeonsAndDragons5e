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
            return FindFilePathRecursive("monsters.json", Directory.GetCurrentDirectory());
        }

        public static string GetSpellFilePath()
        {
            return FindFilePathRecursive("spells.json", Directory.GetCurrentDirectory());
        }

        public static string GetEquipmentFilePath()
        {
            return FindFilePathRecursive("equipment.json", Directory.GetCurrentDirectory());
        }

        public static string GetRaceFilePath()
        {
            return FindFilePathRecursive("races.json", Directory.GetCurrentDirectory());
        }

        public static string GetClassFilePath()
        {
            return FindFilePathRecursive("classes.json", Directory.GetCurrentDirectory());
        }

        public static string GetBackgroundFilePath()
        {
            return FindFilePathRecursive("backgrounds.json", Directory.GetCurrentDirectory());
        }

        public static string GetConditionFilePath()
        {
            return FindFilePathRecursive("conditions.json", Directory.GetCurrentDirectory());
        }

        public static string GetTraitsFilePath()
        {
            return FindFilePathRecursive("traits.json", Directory.GetCurrentDirectory());
        }

        public static string GetAlignmentsFilePath()
        {
            return FindFilePathRecursive("alignments.json", Directory.GetCurrentDirectory());
        }
    }
}