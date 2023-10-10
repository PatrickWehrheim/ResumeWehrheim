using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace ResumeWehrheim.Pages
{
    /// <summary>
    /// Interaktionslogik für Schools.xaml
    /// </summary>
    public partial class Schools : Page
    {
        public Schools()
        {
            InitializeComponent();
        }

        public void OnBackClick(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
