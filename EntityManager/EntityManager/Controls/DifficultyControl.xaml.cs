using System.Windows;
using System.Windows.Controls;
using EntityManager.Data;

namespace EntityManager.Controls
{
    public partial class DifficultyControl : UserControl
    {
        public static readonly DependencyProperty DifficultyProperty = DependencyProperty.Register("Difficulty", typeof(MonsterDifficulty), typeof(DifficultyControl), new PropertyMetadata(default));

        public MonsterDifficulty Difficulty
        {
            get { return (MonsterDifficulty)GetValue(DifficultyProperty); }
            set { SetValue(DifficultyProperty, value); }
        }

        public DifficultyControl()
        {
            InitializeComponent();
        }
    }
}
