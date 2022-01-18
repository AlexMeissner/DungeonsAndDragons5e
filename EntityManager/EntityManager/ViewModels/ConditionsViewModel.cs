using System.Collections.ObjectModel;
using EntityManager.Utility;

namespace EntityManager.ViewModels
{
    public class ConditionsViewModel : BaseViewModel
    {
        public ObservableCollection<ConditionViewModel> Conditions { get; set; } = new();

        public ConditionsViewModel()
        {
            string filePath = FilePath.GetConditionFilePath();
            var conditions = DataParser.Deserialize<ObservableCollection<ConditionViewModel>>(filePath);
            Conditions = conditions ?? new();
        }

        public override void Save()
        {
            string filePath = FilePath.GetConditionFilePath();
            DataParser.Serialize(filePath, Conditions);
        }
    }
}