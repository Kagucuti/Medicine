using MedicineDesktop.Auth;
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

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private  bool access = true;
        public MainWindow()
        {
            InitializeComponent();
            Navigate(new Authorization());
        }
        private void Navigate(Page page)
        {
            StartFrame.NavigationService.Navigate(page);
            while (StartFrame.NavigationService.RemoveBackEntry() != null)
            {
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (access)
            {
                Navigate(new Registration());
                this.Height = 600;
                Sign.Content = "Sign in";
            }
            else
            {
                Navigate(new Authorization());
                this.Height = 500;
                Sign.Content = "Sign up";
            }
            access = !access;
        }
    }
}