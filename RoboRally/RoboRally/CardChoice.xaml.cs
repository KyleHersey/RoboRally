using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RoboRally
{
    /// <summary>
    /// Interaction logic for CardChoice.xaml
    /// </summary>
    public partial class CardChoice : UserControl
    {
        public MovementCard loadedCard;

        public CardChoice()
        {
            InitializeComponent();
        }

        public CardChoice(MovementCard mc)
        {
            InitializeComponent();
            setCard(mc);
        }

        public void RemoveCard()
        {
            loadedCard = null;
            Movement.Text = "";
            Priority.Text = "";
        }

        public void setCard(MovementCard mc){
            loadedCard = mc;
            Movement.Text = Enum.GetName(typeof(moveCard) , loadedCard.movement);
            Priority.Text = loadedCard.priority.ToString();
        }
    }
}
