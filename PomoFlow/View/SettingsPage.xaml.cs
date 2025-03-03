using PomoFlow.ViewModel;
using System.Windows.Controls;

namespace PomoFlow.View
{
    /// <summary>
    /// Interaktionslogik für SettingsPage.xaml
    /// </summary>
    public partial class SettingsPage : Page
    {
        SettingsViewModel viewModel = new SettingsViewModel();
        
        public SettingsPage()
        {
            InitializeComponent();

            DataContext = viewModel;
        }
    }
}
