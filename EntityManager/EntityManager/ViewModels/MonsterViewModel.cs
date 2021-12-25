using System;
using System.Windows.Media.Imaging;

using System.Windows.Input;
using System.Collections.ObjectModel;
using EntityManager.Windows;
using EntityManager.Data;
using System.Collections.Generic;

namespace EntityManager.ViewModels
{
    public class MonsterViewModel : BaseViewModel
    {
        public ObservableCollection<Monster> Monsters { get; set; }
        public ICommand CreateMonsterCommand { get; set; }

        public MonsterViewModel()
        {
            CreateMonsterCommand = new RelayCommand(OpenMonsterCreationWindow);

            Monsters = new ObservableCollection<Monster>();

            for (int i = 0; i < 27; ++i)
            {
                Monster monster = new();
                monster.GUID = Guid.NewGuid().ToString();
                monster.Name = "Eule";
                monster.Image = new BitmapImage(new Uri(@"W:\Projects\Coding\Dungeons and Dragons Tabletop\DungeonsAndDragonsTabletop\Resources\Images\LoginScreen.png"));
                monster.Strength = 3;
                monster.Dexterity = 13;
                monster.Constitution = 8;
                monster.Intelligence = 2;
                monster.Wisdom = 12;
                monster.Charisma = 7;
                monster.Size = "sehr kleines Tier";
                monster.Alignment = "gesinnungslos";
                monster.ArmorClass = 11;
                monster.HitInfo = new MonsterHitInfo() { HitPoints = 20, HitDice = "1W4 - 1" };
                monster.Movement = new List<string> { "1.5m", "fliegend 18m" };
                monster.Senses = new List<string> { "Dunkelsicht 36m", "passive Wahrnehmung 13" };
                monster.Languages = new List<string> { "Eulisch", "Allgemeinsprache" };
                monster.Difficulty = new MonsterDifficulty() { ChallengeRating = 1.0 / 8.0, ExperiencePoints = 25 };
                monster.Actions = new List<Data.Action>
                {
                    new Data.Action(){Name = "Test 1", Type="Nahkampf-Waffenangriff", Description = "sdfguhs dsfiouh fsipdfh s ifsiufsdifh spdfs idfsi udfisudhfipsudhfisdhf  if sifu sidu fhsiudf s ipd gsiu sdiu sd" },
                    new Data.Action(){Name = "Test 2", Description = "pdsui his hbsi spiu isadsiuv sdiu vpsidvipusd visdv iujspdviujpsd iuvpsdiu vsdiuv sdiuvsdiuvsdipuvbsdpi uv bsdpiu v" }
                };
                Monsters.Add(monster);
            }
        }

        public static void OpenMonsterCreationWindow()
        {
            MonsterCreationWindow window = new();
            window.Show();
        }
    }
}