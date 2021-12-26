using System.Collections.ObjectModel;
using EntityManager.Utility;

namespace EntityManager.ViewModels
{
    public class MonstersViewModel : BaseViewModel
    {
        public ObservableCollection<Monster> Monsters { get; set; }

        public MonstersViewModel()
        {
            string filePath = FilePath.GetMonsterFilePath();
            var monsters = DataParser.Deserialize<ObservableCollection<Monster>>(filePath);
            Monsters = monsters ?? new();
        }

        public override void Save()
        {
            string filePath = FilePath.GetMonsterFilePath();
            DataParser.Serialize(filePath, Monsters);
        }
    }
}