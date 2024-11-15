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
                int colorNumber = color.Next(1, 6);
                switch (colorNumber)
                {
                    case 1:
                        colorCode.Append("Rood,");
                        break;
                    case 2:
                        colorCode.Append("Geel,");
                        break;
                    case 3:
                        colorCode.Append("Orangje,");
                        break;
                    case 4:
                        colorCode.Append("Wit,");
                        break;
                    case 5:
                        colorCode.Append("Groen,");
                        break;
                    case 6:
                        colorCode.Append("Blauw,");
                        break;
                }
            }
            colorCode.Length -= 1;
            mastermindCode.Title = colorCode.ToString();
        }
    }
}