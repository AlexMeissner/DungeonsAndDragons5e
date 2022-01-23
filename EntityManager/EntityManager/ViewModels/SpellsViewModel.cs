using System.Collections.ObjectModel;
using EntityManager.Utility;

namespace EntityManager.ViewModels
{
    public class SpellsViewModel : BaseViewModel
    {
        public ObservableCollection<SpellViewModel> Spells { get; set; } = new();

        public SpellsViewModel()
        {
            string filePath = FilePath.GetSpellFilePath();
            var spells = DataParser.Deserialize<ObservableCollection<SpellViewModel>>(filePath);
            Spells = spells ?? new();
        }

        public override void Save()
        {
            string filePath = FilePath.GetSpellFilePath();
            DataParser.Serialize(filePath, Spells);
        }
    }
}