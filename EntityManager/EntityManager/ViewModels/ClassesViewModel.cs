using System.Collections.ObjectModel;
using EntityManager.Utility;

namespace EntityManager.ViewModels
{
    public class ClassesViewModel : BaseViewModel
    {
        public ObservableCollection<ClassViewModel> Classes { get; set; } = new();

        public ClassesViewModel()
        {
            string filePath = FilePath.GetClassFilePath();
            var classes = DataParser.Deserialize<ObservableCollection<ClassViewModel>>(filePath);
            Classes = classes ?? new();
        }

        public override void Save()
        {
            string filePath = FilePath.GetClassFilePath();
            DataParser.Serialize(filePath, Classes);
        }
    }
}