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
    /// Interaction logic for BoardRow.xaml
    /// </summary>
    public partial class BoardRow : UserControl
    {
        public BoardRow()
        {
            InitializeComponent();
        }

        public BoardTile getColumn(int i)
        {
            switch (i)
            {
                case 0: return Col0;
                case 1: return Col1;
                case 2: return Col2;
                case 3: return Col3;
                case 4: return Col4;
                case 5: return Col5;
                case 6: return Col6;
                case 7: return Col7;
                case 8: return Col8;
                case 9: return Col9;
                case 10: return Col10;
                case 11: return Col11;
                default: return null;
            }
        }
    }
}
