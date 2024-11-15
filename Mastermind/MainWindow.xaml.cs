using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Mastermind
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void mastermindCode_Loaded(object sender, RoutedEventArgs e)
        {
            StringBuilder colorCode = new StringBuilder();
            Random color = new Random();
            for (int i = 0; i < 4; i++)
            {
                int colorNumber = color.Next(1, 7);
                switch (colorNumber)
                {
                    case 1:
                        colorCode.Append("Rood, ");
                        break;
                    case 2:
                        colorCode.Append("Geel, ");
                        break;
                    case 3:
                        colorCode.Append("Orangje, ");
                        break;
                    case 4:
                        colorCode.Append("Wit, ");
                        break;
                    case 5:
                        colorCode.Append("Groen, ");
                        break;
                    case 6:
                        colorCode.Append("Blauw, ");
                        break;
                }
            }
            colorCode.Length -= 2;
            mastermindCode.Title = colorCode.ToString();
        }

        private void ComboBox_Selection(object sender, SelectionChangedEventArgs e)
        {
            if (sender == firstComboBox && firstComboBox.SelectedItem != null)
            {
                switch (firstComboBox.SelectedIndex)
                {
                    case 0:
                        firstColor.Background = new SolidColorBrush(Colors.White);
                        break;
                    case 1:
                        firstColor.Background = new SolidColorBrush(Colors.Red);
                        break;
                    case 2:
                        firstColor.Background = new SolidColorBrush(Colors.Orange);
                        break;
                    case 3:
                        firstColor.Background = new SolidColorBrush(Colors.Yellow);
                        break;
                    case 4:
                        firstColor.Background = new SolidColorBrush(Colors.Green);
                        break;
                    case 5:
                        firstColor.Background = new SolidColorBrush(Colors.Blue);
                        break;
                }
            }
            if (sender == secondComboBox)
            {
                switch (secondComboBox.SelectedIndex)
                {
                    case 0:
                        secondColor.Background = new SolidColorBrush(Colors.White);
                        break;
                    case 1:
                        secondColor.Background = new SolidColorBrush(Colors.Red);
                        break;
                    case 2:
                        secondColor.Background = new SolidColorBrush(Colors.Orange);
                        break;
                    case 3:
                        secondColor.Background = new SolidColorBrush(Colors.Yellow);
                        break;
                    case 4:
                        secondColor.Background = new SolidColorBrush(Colors.Green);
                        break;
                    case 5:
                        secondColor.Background = new SolidColorBrush(Colors.Blue);
                        break;
                }
            }
            if (sender == thirdComboBox)
            {
                switch (thirdComboBox.SelectedIndex)
                {
                    case 0:
                        thirdColor.Background = new SolidColorBrush(Colors.White);
                        break;
                    case 1:
                        thirdColor.Background = new SolidColorBrush(Colors.Red);
                        break;
                    case 2:
                        thirdColor.Background = new SolidColorBrush(Colors.Orange);
                        break;
                    case 3:
                        thirdColor.Background = new SolidColorBrush(Colors.Yellow);
                        break;
                    case 4:
                        thirdColor.Background = new SolidColorBrush(Colors.Green);
                        break;
                    case 5:
                        thirdColor.Background = new SolidColorBrush(Colors.Blue);
                        break;
                }
            }
            if (sender == fourthComboBox)
            {
                switch (fourthComboBox.SelectedIndex)
                {
                    case 0:
                        fourthColor.Background = new SolidColorBrush(Colors.White);
                        break;
                    case 1:
                        fourthColor.Background = new SolidColorBrush(Colors.Red);
                        break;
                    case 2:
                        fourthColor.Background = new SolidColorBrush(Colors.Orange);
                        break;
                    case 3:
                        fourthColor.Background = new SolidColorBrush(Colors.Yellow);
                        break;
                    case 4:
                        fourthColor.Background = new SolidColorBrush(Colors.Green);
                        break;
                    case 5:
                        fourthColor.Background = new SolidColorBrush(Colors.Blue);
                        break;
                }
            }
        }
    }
}