namespace EntityManager.ViewModels
{
    public class SpellViewModel : BaseViewModel
    {
        public string GUID { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public uint Level { get; set; } = 0;
        public bool IsCantrip => Level == 0;
        public bool IsSpell => Level > 0;
        public bool IsRitual { get; set; } = false;
        public string CastingTime { get; set; } = string.Empty;
        public string Range { get; set; } = string.Empty;
        public bool IsVerbal { get; set; } = false;
        public bool IsSomatic { get; set; } = false;
        public string Material { get; set; } = string.Empty;
        public string Duration { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}