using System.Collections.ObjectModel;
using EntityManager.Utility;

namespace EntityManager.ViewModels
{
    public class TraitsViewModel : BaseViewModel
    {
        public ObservableCollection<TraitViewModel> Traits { get; set; } = new();

        public TraitsViewModel()
        {
            string filePath = FilePath.GetTraitsFilePath();
            var traits = DataParser.Deserialize<ObservableCollection<TraitViewModel>>(filePath);
            Traits = traits ?? new();
        }

        public override void Save()
        {
            string filePath = FilePath.GetTraitsFilePath();
            DataParser.Serialize(filePath, Traits);
        }
    }
}