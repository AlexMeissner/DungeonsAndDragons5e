using System.Windows.Controls;

namespace EntityManager
{
    public partial class MonsterControl : UserControl
    {
        public MonsterViewModel ViewModel { get; set; } = new MonsterViewModel();

        public MonsterControl()
        {
            InitializeComponent();
        }
    }
}