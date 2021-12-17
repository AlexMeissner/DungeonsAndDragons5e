using System.Windows.Input;
using System.Windows.Media;

namespace EntityManager.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public enum SelectedButton
        {
            Monster,
            Spells,
            Equipment,
            Races,
            Classes,
            Backgrounds
        }

        private SolidColorBrush ButtonColor(SelectedButton button)
        {
            return Button == button ? Brushes.Black : Brushes.LightGray;
        }

        public SolidColorBrush MonsterColor => ButtonColor(SelectedButton.Monster);
        public SolidColorBrush SpellColor => ButtonColor(SelectedButton.Spells);
        public SolidColorBrush EquipmentColor => ButtonColor(SelectedButton.Equipment);
        public SolidColorBrush RaceColor => ButtonColor(SelectedButton.Races);
        public SolidColorBrush ClassesColor => ButtonColor(SelectedButton.Classes);
        public SolidColorBrush BackgroundsColor => ButtonColor(SelectedButton.Backgrounds);

        public SelectedButton Button { get; set; } = SelectedButton.Monster;

        public ICommand MonsterCommand { get; set; }
        public ICommand SpellCommand { get; set; }
        public ICommand EquipmentCommand { get; set; }
        public ICommand RaceCommand { get; set; }
        public ICommand ClassesCommand { get; set; }
        public ICommand BackgroundsCommand { get; set; }

        public BaseViewModel Content { get; set; } = new MonsterViewModel();

        public MainViewModel()
        {
            MonsterCommand = new RelayCommand(OpenMonsterPanel);
            SpellCommand = new RelayCommand(OpenSpellPanel);
            EquipmentCommand = new RelayCommand(OpenEquipmentPanel);
            RaceCommand = new RelayCommand(OpenRacePanel);
            ClassesCommand = new RelayCommand(OpenClassPanel);
            BackgroundsCommand = new RelayCommand(OpenBackgroundPanel);
        }

        public void OpenMonsterPanel()
        {
            Button = SelectedButton.Monster;
            Content = new MonsterViewModel();
        }

        public void OpenSpellPanel()
        {
            Button = SelectedButton.Spells;
            Content = new SpellsViewModel();
        }

        public void OpenEquipmentPanel()
        {
            Button = SelectedButton.Equipment;
            Content = new EquipmentViewModel();
        }

        public void OpenRacePanel()
        {
            Button = SelectedButton.Races;
            Content = new RacesViewModel();
        }

        public void OpenClassPanel()
        {
            Button = SelectedButton.Classes;
            Content = new ClassesViewModel();
        }

        public void OpenBackgroundPanel()
        {
            Button = SelectedButton.Backgrounds;
            Content = new BackgroundsViewModel();
        }
    }
}