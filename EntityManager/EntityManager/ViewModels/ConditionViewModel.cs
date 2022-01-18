using System.Collections.ObjectModel;

namespace EntityManager.ViewModels
{
    public class ConditionViewModel : BaseViewModel
    {
        public class ConditionContent
        {
            public string Content { get; set; } = string.Empty;
        }

        public string GUID { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public ObservableCollection<ConditionContent> Effects { get; set; } = new();
    }
}