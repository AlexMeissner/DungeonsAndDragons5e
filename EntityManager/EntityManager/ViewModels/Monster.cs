using System.Collections.Generic;

namespace EntityManager.ViewModels
{
    public class Monster : BaseViewModel
    {
        public string GUID { get; set; } = string.Empty;

        public string Image { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        public uint Strength { get; set; }
        public uint Dexterity { get; set; }
        public uint Constitution { get; set; }
        public uint Intelligence { get; set; }
        public uint Wisdom { get; set; }
        public uint Charisma { get; set; }

        public string Size { get; set; } = string.Empty;
        public string Alignment { get; set; } = string.Empty;

        public uint ArmorClass { get; set; }
        public MonsterHitInfo HitInfo { get; set; } = new();
        public List<string> Movement { get; set; } = new();

        public List<string> Senses { get; set; } = new();
        public List<string> Languages { get; set; } = new();
        public MonsterDifficulty Difficulty { get; set; } = new();
        public List<MonsterAction> Actions { get; set; } = new();
    }
}
