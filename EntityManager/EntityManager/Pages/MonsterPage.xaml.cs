using System.Linq;
using System.Windows;
using System.Windows.Input;
using System.Windows.Controls;
using System.Collections.ObjectModel;
using EntityManager.Windows;
using EntityManager.Controls;
using EntityManager.ViewModels;

namespace EntityManager.Pages
{
    public partial class MonsterPage : Page
    {
        public MonstersViewModel ViewModel => DataContext as MonstersViewModel ?? new();

        public MonsterPage()
        {
            InitializeComponent();
        }

        private void OnEditMonster(object sender, MouseButtonEventArgs e)
        {
            if (sender is MonsterCardControl control)
            {
                Monster monster = (Monster)control.DataContext;
                MonsterCreationWindow window = new(monster);

                if (window.ShowDialog() == true && window.Monster != null)
                {
                    int index = ViewModel.Monsters.IndexOf(monster);
                    ViewModel.Monsters[index] = window.Monster;
                    SortMonsters();
                }
            }
        }

        private void OnAddMonster(object sender, RoutedEventArgs e)
        {
            MonsterCreationWindow window = new();

            if (window.ShowDialog() == true && window.Monster != null)
            {
                ViewModel.Monsters.Add(window.Monster);
                SortMonsters();
            }
        }

        private void SortMonsters()
        {
            ViewModel.Monsters = new ObservableCollection<Monster>(ViewModel.Monsters.OrderBy(x => x.Name));
        }
    }
}