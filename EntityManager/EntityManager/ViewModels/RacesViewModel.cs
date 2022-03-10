using System.Collections.ObjectModel;
using EntityManager.Utility;

namespace EntityManager.ViewModels
{
    public class RacesViewModel : BaseViewModel
    {
        public ObservableCollection<RaceViewModel> Races { get; set; } = new();

        public RacesViewModel()
        {
            string filePath = FilePath.GetClassFilePath();
            var races = DataParser.Deserialize<ObservableCollection<RaceViewModel>>(filePath);
            Races = races ?? new();
        }

        public override void Save()
        {
            string filePath = FilePath.GetClassFilePath();
            DataParser.Serialize(filePath, Races);
        }
    }
}