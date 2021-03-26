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

namespace Aufgabe_6
{
    // Author: Dirk Mueller
    // Date: 26.03.2021
    //
    // Algorithm:
    // 1. On button click the text in two labels is interchanged
    // 2. On placing a check in a checkbox the size in both labels is increased
    // 3. After unchecking the checkbox the font sizes shall revert to the original


    public partial class MainWindow : Window
    {
        string tempLabelText;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnExchange_Click(object sender, RoutedEventArgs e)
        {
            tempLabelText = lbl_1.Content.ToString();
            lbl_1.Content = lbl_2.Content;
            lbl_2.Content = tempLabelText;
        }
    }
}
