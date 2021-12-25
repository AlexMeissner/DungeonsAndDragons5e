namespace EntityManager.ViewModels
{
    public class MonsterHitInfo : BaseViewModel
    {
        public uint HitPoints { get; set; }
        public string HitDice { get; set; } = string.Empty;
    }
}