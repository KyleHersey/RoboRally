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
    /// Interaction logic for PlayArea.xaml
    /// </summary>
    public partial class PlayArea : UserControl
    {
        public PlayArea()
        {
            InitializeComponent();
        }

        public event EventHandler<RoutedEventArgs> ClickedOKHandler;
        private void ClickedOK(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Clicked ok and playarea saw it");
            ClickedOKHandler(sender, e);
        }

        private void ClickedChoice(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine("Clicked choice and playarea saw it");
            CardChoice card = (CardChoice)sender;
            card.RemoveCard();
        }

        private void ClickedChoosable(object sender, MouseButtonEventArgs e)
        {

            //get clicked choice
            CardChoice card = (CardChoice)sender;

            //find open choice slot
            if (Card0.loadedCard == null)
            {
                Card0.setCard(card.loadedCard);
            }
            else if (Card1.loadedCard == null)
            {
                Card1.setCard(card.loadedCard);
            }
            else if (Card2.loadedCard == null)
            {
                Card2.setCard(card.loadedCard);
            }
            else if (Card3.loadedCard == null)
            {
                Card3.setCard(card.loadedCard);
            }
            else if (Card4.loadedCard == null)
            {
                Card4.setCard(card.loadedCard);
            }
        }
    }
}
