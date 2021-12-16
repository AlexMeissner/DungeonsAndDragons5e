using System.Windows.Media.Imaging;

namespace EntityManager.Data
{
    public struct Monster
    {
        public string GUID { get; set; }

        public BitmapImage Image { get; set; }

        public string Name { get; set; }

        public uint Strength { get; set; }
        public uint Dexterity { get; set; }
        public uint Constitution { get; set; }
        public uint Intelligence { get; set; }
        public uint Wisdom { get; set; }
        public uint Charisma { get; set; }

        public string Size { get; set; }
        public string Alignment { get; set; }

        public uint ArmorClass { get; set; }
        public uint HitPoints { get; set; }
        public string HitDice { get; set; }
        public string[] Movement { get; set; }

        public string[] Senses { get; set; }
        public string[] Languages { get; set; }
        public double ChallangeRating { get; set; }
        public uint ExperiencePoints { get; set; }

        public Action[] Actions { get; set; }
    }
}
