using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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

namespace TheWpfApp.Views
{
    /// <summary>
    /// Interaction logic for TicTacToe.xaml
    /// </summary>
    public partial class TicTacToeUserControl : UserControl
    {
        bool B  = false;
 string[,] Mat = new string[3,3];
        public TicTacToeUserControl()
        {
            InitializeComponent();
        }

        private void Loc_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            if (button.Content == null)
            {
                int Col = int.Parse(button.Name.Last().ToString());
                int Row = int.Parse(button.Name[3].ToString());

                if (B)
                {

                    button.Content = Mat[Row, Col] = "X";
                }
                else
                {

                    button.Content = Mat[Row, Col] = "O";
                }
                if (Check_Win(Row, Col) == true) {
                    MessageBox.Show("YOU WIN");
                        }
                B = !B;
            }

        }
        private bool Check_Win(int Row, int Col)
        {
            string check = Mat[Row,Col];
            bool CRow = true, CCol = true, CCross = true, CCross1=true;
            for (int i = 0; i < 3; i++)
            {
                CRow &= check == Mat[Row, i];
                CCol &= check == Mat[i, Col];
                CCross &= check == Mat[i, i];
                CCross1 &= check == Mat[i, 2 - i];
                
            }
            return CRow || CCol || CCross || CCross1;
            //0.2 1.1 2.0
            // i+x=2 i=0 x=2-i
                   
        }
               

    }
}
