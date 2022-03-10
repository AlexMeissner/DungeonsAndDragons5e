using System.Collections.ObjectModel;

namespace EntityManager.ViewModels
{
    public class RaceViewModel : BaseViewModel
    {
        public string GUID { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public double Movement { get; set; } = 0.0;
        public uint MinAge { get; set; } = 0;
        public uint MaxAge { get; set; } = 0;
        public double MinSize { get; set; } = 0.0;
        public double MaxSize { get; set; } = 0.0;
        public string SizeCategory { get; set; } = string.Empty;
        public AlignmentViewModel Alignment { get; set; } = new();
        public AttributesViewModel Attributes { get; set; } = new();
        public ObservableCollection<TraitViewModel> Traits { get; set; } = new();
        public ObservableCollection<string> Languages { get; set; } = new();
    }
}