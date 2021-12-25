using System.Collections.Generic;
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
        public MonsterHitInfo HitInfo { get; set; }
        public List<string> Movement { get; set; }

        public List<string> Senses { get; set; }
        public List<string> Languages { get; set; }
        public MonsterDifficulty Difficulty { get; set; }
        public List<Action> Actions { get; set; }
    }
}
