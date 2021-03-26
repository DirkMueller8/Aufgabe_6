using System.Windows;


namespace Aufgabe_6
{
    // Author: Dirk Mueller
    // Date: 26.03.2021
    //
    // Algorithm:
    // 1. On button click the text in two labels is interchanged
    // 2. On placing a check in a checkbox the size in both labels is increased
    // 3. After unchecking the checkbox the font sizes shall revert to the original
    // (the original font sized is queried on start of the program)


    public partial class MainWindow : Window
    {
        int fontSizeLabelOnStart;
        string tempLabelText;
        const int FONT_SIZE_INCREASE = 4;
        public MainWindow()
        {
            InitializeComponent();

            // Store the font size of the label upon initialization of the WPF form:
            fontSizeLabelOnStart = (int)lbl_1.FontSize;
        }

        private void btnExchange_Click(object sender, RoutedEventArgs e)
        {
            // Code block to swap the content of the two labels:
            tempLabelText = lbl_1.Content.ToString();
            lbl_1.Content = lbl_2.Content;
            lbl_2.Content = tempLabelText;
        }

        private void chbSize_Checked(object sender, RoutedEventArgs e)
        {
            // Increase font size by constant:
            lbl_1.FontSize += FONT_SIZE_INCREASE;
            lbl_2.FontSize += FONT_SIZE_INCREASE;
        }

        private void chbSize_Unchecked(object sender, RoutedEventArgs e)
        {
            // Revert font size to the initial value in both labels:
            lbl_1.FontSize = fontSizeLabelOnStart;
            lbl_2.FontSize = fontSizeLabelOnStart;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}