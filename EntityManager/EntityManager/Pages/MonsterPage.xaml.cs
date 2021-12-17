using System.Windows.Controls;
using EntityManager.ViewModels;

namespace EntityManager.Pages
{
    public partial class MonsterPage : UserControl
    {
        public MonsterViewModel ViewModel { get; set; } = new MonsterViewModel();

        public MonsterPage()
        {
            InitializeComponent();
        }
    }
}