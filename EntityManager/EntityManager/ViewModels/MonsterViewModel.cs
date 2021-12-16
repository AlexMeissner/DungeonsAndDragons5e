using System.Windows.Media.Imaging;

namespace EntityManager
{
    public class MonsterViewModel : BaseViewModel
    {
        public BitmapImage Image { get; set; } = new BitmapImage(new System.Uri(@"W:\Projects\Coding\Dungeons and Dragons Tabletop\DungeonsAndDragonsTabletop\Resources\Images\LoginScreen.png"));
    }
}