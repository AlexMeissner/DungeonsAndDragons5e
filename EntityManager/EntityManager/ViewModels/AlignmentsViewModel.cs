using System.Collections.ObjectModel;
using EntityManager.Utility;

namespace EntityManager.ViewModels
{
    public class AlignmentsViewModel : BaseViewModel
    {
        public ObservableCollection<AlignmentViewModel> Alignments { get; set; } = new();

        public AlignmentsViewModel()
        {
            string filePath = FilePath.GetAlignmentsFilePath();
            var alignments = DataParser.Deserialize<ObservableCollection<AlignmentViewModel>>(filePath);
            Alignments = alignments ?? new();
        }

        public override void Save()
        {
            string filePath = FilePath.GetAlignmentsFilePath();
            DataParser.Serialize(filePath, Alignments);
        }
    }
}