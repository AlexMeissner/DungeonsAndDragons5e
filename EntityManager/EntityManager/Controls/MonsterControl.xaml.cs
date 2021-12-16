using System;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using EntityManager.Data;

namespace EntityManager
{
    public partial class MonsterControl : UserControl
    {
        public MonsterControl()
        {
            InitializeComponent();

            List<Monster> items = new();

            for (int i = 0; i < 25; ++i)
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
                monster.HitPoints = 1;
                monster.HitDice = "1W4 - 1";
                monster.Movement = new string[] { "1.5m", "fliegend 18m" };
                monster.Senses = new string[] { "Dunkelsicht 36m", "passive Wahrnehmung 13" };
                monster.Languages = new string[] { "Eulisch", "Allgemeinsprache" };
                monster.ChallangeRating = 0;
                monster.ExperiencePoints = 10;
                monster.Actions = new Data.Action[]
                {
                    new Data.Action(){Name = "Test 1", Type="Nahkampf-Waffenangriff", Description = "sdfguhs dsfiouh fsipdfh s ifsiufsdifh spdfs idfsi udfisudhfipsudhfisdhf  if sifu sidu fhsiudf s ipd gsiu sdiu sd" },
                    new Data.Action(){Name = "Test 2", Description = "pdsui his hbsi spiu isadsiuv sdiu vpsidvipusd visdv iujspdviujpsd iuvpsdiu vsdiuv sdiuvsdiuvsdipuvbsdpi uv bsdpiu v" }
                };
                items.Add(monster);
            }

            ItemsCtr.ItemsSource = items;
        }
    }
}
