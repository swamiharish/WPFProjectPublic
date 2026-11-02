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

namespace WPFRevised
{
    /// <summary>
    /// Interaction logic for ResourceStyles.xaml
    /// </summary>
    public partial class ResourceStyles : Window
    {
        public ResourceStyles()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Resources["MyButtonStyle"] = new SolidColorBrush(Colors.Red);
        }
    }
}